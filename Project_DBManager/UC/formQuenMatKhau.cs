using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class formQuenMatKhau : Form
    {
        public formQuenMatKhau()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private async void bt_login_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbEmail).IsNullOrEmpty() == false) { return; }
            if (AccountDAO.Instance.validateEmail(tbEmail.Text) == true) { errorProvider1.SetError(tbEmail, "Địa chỉ email không tồn tại"); }
            if (errorProvider1.GetError(tbEmail).IsNullOrEmpty() == false) { return; }
            string query = string.Format("SELECT Username, Password From Users WHERE User_Email = '{0}'", tbEmail.Text);
            DataRow row = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            string username = row["Username"].ToString();
            string password = row["Password"].ToString();
            string content = string.Format("Tên tài khoản: {0} <br> Mật khẩu: {1}",username, password);
            await SendEmail.Instance.sendEmail(tbEmail.Text, content);
        }
    }
}
