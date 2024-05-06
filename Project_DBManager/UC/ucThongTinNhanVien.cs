using Project_DBManager.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class ucThongTinNhanVien : UserControl
    {
        private int userID;
        public ucThongTinNhanVien()
        {
            InitializeComponent();
        }

        public int UserID { get => userID; set => userID = value; }

        public void loadInfo(int userID)
        {
            DataTable data = AccountDAO.Instance.getAccountInfoByUserID(userID);
            DataRow row = data.Rows[0];
            tbHoTen.Text = row["Name"].ToString();
            lbTitleName.Text = tbHoTen.Text;
            tbIDC.Text = row["ID_Card"].ToString();
            tbEmail.Text = row["User_Email"].ToString();
            cb_ChucVu.Items.Remove("Quản lý");
            switch (row["Pos_Name"].ToString())
            {
                case "Employee": cb_ChucVu.SelectedIndex = 0; lbTitlePosition.Text = "Employee"; break;
                case "Leader": cb_ChucVu.SelectedIndex = 1; lbTitlePosition.Text = "Leader"; break;
                case "Manager": cb_ChucVu.Items.Add("Quản lý"); cb_ChucVu.SelectedIndex = 2; lbTitlePosition.Text = "Manager"; break;
            }

            tbAddress.Text = row["Address"].ToString();
            cb_ViTri.SelectedIndex = cb_ViTri.FindStringExact(row["Department_Name"].ToString());
            dtpk_Birth.Value = DateTime.ParseExact(row["Birth"].ToString(), "dd-MM-yyyy", null);
            cb_GioiTinh.SelectedIndex = cb_GioiTinh.FindStringExact(row["Gender"].ToString());
            int isEnable = Convert.ToInt32(row["IsEnable"]);
            switch (isEnable)
            {
                case 0: cb_TrangThai.SelectedIndex = 1; break;
                case 1: cb_TrangThai.SelectedIndex = 0; break;
            }
            this.userID = userID;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string hoTen = tbHoTen.Text;
            string cccd = tbIDC.Text;
            string email = tbEmail.Text;
            string position = cb_ChucVu.Text;
            string address = tbAddress.Text;
            string dept = cb_ViTri.Text;
            string gender = cb_GioiTinh.Text;
            string birth = dtpk_Birth.Value.ToString("MM-dd-yyyy");
            int userID = this.userID;
            int isEnable = cb_TrangThai.SelectedIndex == 1 ? 0 : 1;
            bool isSucceed = AccountDAO.Instance.updateAccountInfoByUserID(hoTen, cccd, email, position, address, dept, birth, gender, userID, isEnable);
            if (isSucceed)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }


        }
    }
}

