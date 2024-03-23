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

namespace Project_DBManager
{
    public partial class Login_Form_Staff : Form
    {
        public Login_Form_Staff()
        {
            InitializeComponent();
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
            Login_Form newForm = new Login_Form();
            newForm.Show();
            this.Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "")
            {
                MessageBox.Show("Please enter your username");
            } else if(textBox_Password.Text == "") {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection();
                    // Khúc này code giúp t cái xác minh đăng nhập, SQL t ko connect được nên k code đc 

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
