using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tbPosition.Text = row["Pos_Name"].ToString();
            lbTitlePosition.Text = tbPosition.Text;
            tbAddress.Text = row["Address"].ToString();
            tbDepartment.Text = row["Department_Name"].ToString();
            dtpk_Birth.Value = DateTime.ParseExact(row["Birth"].ToString(), "dd-MM-yyyy", null);
            tbGioiTinh.Text = row["Gender"].ToString();
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
            string position = tbPosition.Text;
            string address = tbAddress.Text;
            string dept = tbDepartment.Text;
            string gender = tbGioiTinh.Text;
            string birth = dtpk_Birth.Value.ToString("MM-dd-yyyy");
            int userID = this.userID;
            if(InformationDAO.Instance.validateGender(gender) == false) { MessageBox.Show("Giới tính không hợp lệ (Nam/Nữ)"); return; }
            if (InformationDAO.Instance.validateDept(dept) == false) { MessageBox.Show("Phòng ban không tồn tại"); return;  }
            if(InformationDAO.Instance.validatePos(position) == false) { MessageBox.Show("Chức vụ không hợp lệ"); return; }
            bool isSucceed = AccountDAO.Instance.updateAccountInfoByUserID(hoTen, cccd, email, position, address, dept, birth, gender, userID);
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

