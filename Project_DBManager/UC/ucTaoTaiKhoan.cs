﻿using Project_DBManager.DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucTaoTaiKhoan : UserControl
    {
        public ucTaoTaiKhoan()
        {
            InitializeComponent();
            cb_ChucVu.SelectedIndex = 0;
            cb_GioiTinh.SelectedIndex = 0;
            cb_ViTri.SelectedIndex = 0;
        }
        public bool validate(string text)
        {
            return Regex.IsMatch(text, @"^[A-Za-z][A-Za-z0-9@#%&\'\-\s\.\,*]*$");
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
            if (username == "") { MessageBox.Show("Tài khoản không được để trống"); return; }
            if (!validate(username)) { MessageBox.Show("Tài khoản không được có dấu"); return; }
            if (matKhau == "") { MessageBox.Show("Mật khẩu không được để trống"); return; }
            if (!validate(matKhau)) { MessageBox.Show("Mật khẩu không được có dấu"); return; }
            if (hoTen == "") { MessageBox.Show("Họ tên không được để trống"); return; }
            if (cccd == "") { MessageBox.Show("CCCD không được để trống"); return; }
            if (email == "") { MessageBox.Show("Email không được để trống"); return; }
            if (address == "") { MessageBox.Show("Địa chỉ không được để trống"); return; }
            if (AccountDAO.Instance.validateEmail(email) == false) { MessageBox.Show("Địa chỉ email đã tồn tại"); return; }
            if (AccountDAO.Instance.validateUsername(username) == false) { MessageBox.Show("Tên tài khoản đã tồn tại"); return; }
            bool isSucceed = AccountDAO.Instance.createAccount(username, matKhau, email, pos_ID, hoTen, ngaySinh, gender, address, cccd, sdt, dept);
            if (isSucceed)
            {
                MessageBox.Show("Tạo tài khoản thành công");
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
    }
}
