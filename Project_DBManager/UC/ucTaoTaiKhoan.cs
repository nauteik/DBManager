using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DBManager.UC
{
    public partial class ucTaoTaiKhoan : UserControl
    {
        public Account account;
        public ucTaoTaiKhoan()
        {
            InitializeComponent();
            cb_ChucVu.SelectedIndex = 0;
            cb_GioiTinh.SelectedIndex = 0;
            cb_ViTri.SelectedIndex = 0;
            this.errorProvider1.Icon = new Icon(this.errorProvider1.Icon, 16, 16);
        }
       
        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text;
            string matKhau = tbMatKhau.Text;
            string hoTen = tbHoTen.Text;
            string cccd = tb_CCCD.Text;
            string email = tbEmail.Text;
            int pos_ID = cb_ChucVu.SelectedIndex;
            string address = tbAddress.Text;
            string dept = cb_ViTri.Text;
            string gender = cb_GioiTinh.Text;
            string ngaySinh = dtpk_Birth.Value.ToString("MM-dd-yyyy");
            string sdt = tb_SDT.Text;
            tbTaiKhoan_KeyUp(sender, e as KeyEventArgs);
            tbMatKhau_TextChanged(sender, e as KeyEventArgs);
            tb_SDT_KeyUp(sender, e as KeyEventArgs);
            tb_CCCD_KeyUp(sender, e as KeyEventArgs);
            tbEmail_KeyUp(sender, e as KeyEventArgs);
            dtpk_Birth_ValueChanged(sender, e);
            if (AccountDAO.Instance.validateEmail(email) == false) { errorProvider1.SetError(tbEmail, "Địa chỉ email đã tồn tại");}
            if (AccountDAO.Instance.validateUsername(username) == false) { errorProvider1.SetError(tbTaiKhoan, "Tên tài khoản đã tồn tại");}
            if (errorProvider1.GetError(tb_SDT).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tb_CCCD).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tbMatKhau).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tbTaiKhoan).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(tbEmail).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(dtpk_Birth).IsNullOrEmpty() == false) return;
            bool isSucceed = AccountDAO.Instance.createAccount(username, matKhau, email, pos_ID, hoTen, ngaySinh, gender, address, cccd, sdt, dept);
            if (isSucceed)
            {
                MessageBox.Show("Tạo tài khoản thành công");
                ActDAO.Instance.createAct(account.UserID, "Tạo tài khoản " + tbTaiKhoan.Text, DateTime.Now);
                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
                tbHoTen.Text = "";
                tb_CCCD.Text = "";
                tbEmail.Text = "";
                tbAddress.Text = "";
                tb_SDT.Text = "";
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
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


        private void tbTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError(tbTaiKhoan, null);
            if (Service.Validator.Instance.validEncode(tbTaiKhoan.Text) != "")
            {
                errorProvider1.SetError(tbTaiKhoan, Service.Validator.Instance.validEncode(tbTaiKhoan.Text));
            }
            else
            {
                errorProvider1.SetError(tbTaiKhoan, null);
            }
        }

        private void tb_CCCD_KeyUp(object sender, KeyEventArgs e)
        {
            if (Service.Validator.Instance.validPhone(tb_CCCD.Text) != "")
            {
                errorProvider1.SetError(tb_CCCD, Service.Validator.Instance.validPhone(tb_CCCD.Text));
            }
            else
            {
                errorProvider1.SetError(tb_CCCD, null);
            }
        }

        private void tbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError(tbEmail, null);
            if (Service.Validator.Instance.validEmail(tbEmail.Text) != "")
            {
                errorProvider1.SetError(tbEmail, Service.Validator.Instance.validEmail(tbEmail.Text));
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
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

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (Service.Validator.Instance.validEncode(tbMatKhau.Text) != "")
            {
                errorProvider1.SetError(tbMatKhau, Service.Validator.Instance.validEncode(tbMatKhau.Text));
            }
            else
            {
                errorProvider1.SetError(tbMatKhau, null);
            }
        }
    }
}
