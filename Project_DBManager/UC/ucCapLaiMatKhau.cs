using Project_DBManager.DAO;
using Project_DBManager.DTO;
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
            if (e.KeyCode == Keys.Enter)
            {
                List<AccountWithPhone> tempListAccount = listAccount;
                string value = tb_TimKiem.Text;
                tempListAccount = tempListAccount.Where(acc => acc.Username.ToLower().Contains(value.ToLower()) || acc.Password.ToLower().Contains(value.ToLower()) || acc.Email.ToLower().Contains(value.ToLower()) || acc.Sdt.ToLower().Contains(value.ToLower())).ToList();
                dtgv_Account.DataSource = tempListAccount;
            }
        }
    }
}
