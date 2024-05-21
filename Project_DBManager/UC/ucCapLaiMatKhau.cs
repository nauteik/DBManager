using Project_DBManager.DAO;
using Project_DBManager.DTO;
using Project_DBManager.Service;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucCapLaiMatKhau : UserControl
    {
        private List<AccountWithPhone> listAccount;
        public ucCapLaiMatKhau()
        {
            InitializeComponent();
        }
        public void loadAccount()
        {
            listAccount = AccountDAO.Instance.getListAccountWithPhone();
            dtgv_Account.DataSource = listAccount;
        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
                List<AccountWithPhone> tempListAccount = listAccount;
                string value = tb_TimKiem.Text;
                tempListAccount = tempListAccount.Where(acc => acc.Username.ToLower().Contains(value.ToLower()) || acc.Password.ToLower().Contains(value.ToLower()) || acc.Email.ToLower().Contains(value.ToLower()) || acc.Sdt.ToLower().Contains(value.ToLower()) || acc.Name.ToLower().Contains(value.ToLower())).ToList();
                dtgv_Account.DataSource = tempListAccount;
        }

        private async void btn_CapMatKhau_Click(object sender, System.EventArgs e)
        {
            foreach(AccountWithPhone temp in listAccount)
            {
                if (temp.IsChecked)
                {
                    string query = string.Format("SELECT Username, Password From Users WHERE User_Email = '{0}'", temp.Email);
                    DataRow row = DataProvider.Instance.ExecuteQuery(query).Rows[0];
                    string username = row["Username"].ToString();
                    string password = row["Password"].ToString();
                    string content = string.Format("Tên tài khoản: {0} <br> Mật khẩu: {1}", username, password);
                    SendEmail.Instance.sendEmail(temp.Email, content);
                }
            }
            MessageBox.Show("Cấp mật khẩu thành công");
        }
    }
}
