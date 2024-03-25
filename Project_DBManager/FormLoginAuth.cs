﻿using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DBManager
{
    public partial class FormLoginAuth : Form
    {
        public FormLoginAuth(string pos, Bitmap img)
        {
            InitializeComponent();
            label6.Text = pos.ToUpper();
            pictureBox1.BackgroundImage = img;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Form_Staff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống");
                return;
            }
            if(AccountDAO.Instance.checkLogin(textBox_Username.Text, textBox_Password.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không hợp lệ");
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                bt_login.PerformClick();
            }
        }
        private void textBox_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }
    }
}