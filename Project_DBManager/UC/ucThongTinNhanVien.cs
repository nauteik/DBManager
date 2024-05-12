using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class ucThongTinNhanVien : UserControl
    {
        private int userID;
        private Account account;
        public ucThongTinNhanVien()
        {
            InitializeComponent();
        }

        public int UserID { get => userID; set => userID = value; }
        public Account Account { get => account; set => account = value; }

        public void loadInfo(int userID)
        {
            DataTable data = AccountDAO.Instance.getAccountInfoByUserID(userID);
            DataRow row = data.Rows[0];
            tbHoTen.Text = row["Name"].ToString();
            lbTitleName.Text = tbHoTen.Text;
            tbIDC.Text = row["ID_Card"].ToString();
            tbEmail.Text = row["User_Email"].ToString();
            tb_SDT.Text = row["PhoneNum"].ToString();
            cb_ChucVu.Enabled = true;
            cb_ChucVu.Items.Remove("Quản lý");
            cb_ChucVu.Items.Remove("CEO");
            string posName = row["Pos_Name"].ToString();
            switch (posName)
            {
                case "Employee": cb_ChucVu.SelectedIndex = cb_ChucVu.FindStringExact("Nhân viên"); lbTitlePosition.Text = "Nhân viên"; break;
                case "Leader": cb_ChucVu.SelectedIndex = cb_ChucVu.FindStringExact("Tổ trưởng"); lbTitlePosition.Text = "Tổ trưởng"; break;
                case "Manager": cb_ChucVu.Items.Add("Quản lý"); cb_ChucVu.SelectedIndex = cb_ChucVu.FindStringExact("Quản lý"); lbTitlePosition.Text = "Quản lý"; break;
                case "CEO": cb_ChucVu.Items.Add("Quản lý"); cb_ChucVu.Items.Add("CEO"); cb_ChucVu.SelectedIndex = cb_ChucVu.FindStringExact("CEO"); lbTitlePosition.Text = "CEO"; cb_ChucVu.Enabled = false; break;
            }
            if(this.account.Level == 3 && (posName == "Employee" || posName == "Leader")) { cb_ChucVu.Items.Add("Quản lý"); }
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
            string sdt = tb_SDT.Text;
            int userID = this.userID;
            int isEnable = cb_TrangThai.SelectedIndex == 1 ? 0 : 1;
            bool isSucceed = AccountDAO.Instance.updateAccountInfoByUserID(hoTen, cccd, email, position, address, dept, birth, gender, userID, sdt, isEnable);
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

