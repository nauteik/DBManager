using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using Project_DBManager.UC;
using System;
using System.ComponentModel.DataAnnotations;
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
            tb_SDT_KeyUp(sender, e as KeyEventArgs);
            tbIDC_KeyUp(sender, e as KeyEventArgs);
            tbEmail_TextChanged(sender, e as KeyEventArgs);
            dtpk_Birth_ValueChanged(sender, e);
            if (AccountDAO.Instance.validateEmailExcept(email, userID) == false) { errorProvider1.SetError(tbEmail, "Địa chỉ email đã tồn tại"); }
            if (errorProvider1.GetError(tb_SDT).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tbIDC).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tbEmail).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(dtpk_Birth).IsNullOrEmpty() == false) return;
            bool isSucceed = AccountDAO.Instance.updateAccountInfoByUserID(hoTen, cccd, email, position, address, dept, birth, gender, userID, sdt, isEnable);
            if (isSucceed)
            {
                MessageBox.Show("Cập nhật thành công");
                if(this.Parent as ucDanhSachNhanVien != null)
                    (this.Parent as ucDanhSachNhanVien).loadStaff(this.account);
                if (this.Parent as ucVoHieuHoaKhoiPhuc != null)
                    (this.Parent as ucVoHieuHoaKhoiPhuc).loadStaff(this.account);
                ActDAO.Instance.createAct(account.UserID, "Cập nhật tài khoản nhân viên " + hoTen, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }


        }


        private void tbHoTen_KeyUp(object sender, KeyEventArgs e)
        {
            if(tbHoTen.Text == "")
            {
                errorProvider1.SetError(tbHoTen, "Không được để trống");
            }
            else
            {
                errorProvider1.SetError(tbHoTen, null);
            }
        }

        private void tbIDC_KeyUp(object sender, KeyEventArgs e)
        {
            if (Service.Validator.Instance.validPhone(tbIDC.Text) != "")
            {
                errorProvider1.SetError(tbIDC, Service.Validator.Instance.validPhone(tbIDC.Text));
            }
            else
            {
                errorProvider1.SetError(tbIDC, null);
            }
        }

        

        private void tb_SDT_KeyUp(object sender, KeyEventArgs e)
        {
            if (Service.Validator.Instance.validPhone(tb_SDT.Text) != "")
            {
                errorProvider1.SetError(tb_SDT, Service.Validator.Instance.validPhone(tb_SDT.Text));
            }
            else
            {
                errorProvider1.SetError(tb_SDT, null);
            }
        }

        private void dtpk_Birth_ValueChanged(object sender, EventArgs e)
        {
            if (Service.Validator.Instance.validPastDate(dtpk_Birth.Value) != "")
            {
                errorProvider1.SetError(dtpk_Birth, Service.Validator.Instance.validPastDate(dtpk_Birth.Value));
            }
            else
            {
                errorProvider1.SetError(dtpk_Birth, null);
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (Service.Validator.Instance.validEmail(tbEmail.Text) != "")
            {
                errorProvider1.SetError(tbEmail, Service.Validator.Instance.validEmail(tbEmail.Text));
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            }
        }
    }
}

