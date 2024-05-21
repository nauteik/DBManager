using Project_DBManager.DAO;
using Project_DBManager.DTO;
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
    public partial class ucTrangChu : UserControl
    {
        public Account account;
        public List<Act> listAct;
        public ucTrangChu()
        {
            InitializeComponent();
        }
        public void loadAct(Account account)
        {
            this.account = account;
            switch (account.Level)
            {
                case 0: listAct = ActDAO.Instance.getListActEmployee(account.UserID); break;
                case 1: listAct = ActDAO.Instance.getListActLeader(StaffDAO.Instance.getDeptIDByUserID(account.UserID)); break;
                case 2: listAct = ActDAO.Instance.getListActManager(account.Level); break;
                case 3: listAct = ActDAO.Instance.getListActManager(account.Level); break;
            }
            lb_WelcomeBack.Text = "Welcome back, " + StaffDAO.Instance.getStaffNameByUserID(account.UserID);
            dtgv_Staff.DataSource = listAct;
            cbLoc.SelectedIndex = 0;
        }
        private List<Act> getFilteredDataSource()
        {
            List<Act> tempListAct = listAct;
            switch (cbLoc.SelectedItem.ToString())
            {
                case "Ăn uống": tempListAct = tempListAct.Where(act => act.Dept == "Ăn uống").ToList(); break;
                case "Du lịch": tempListAct = tempListAct.Where(act => act.Dept == "Du lịch").ToList(); break;
                case "Mua sắm": tempListAct = tempListAct.Where(act => act.Dept == "Mua sắm").ToList(); break;
                case "Giải trí": tempListAct = tempListAct.Where(act => act.Dept == "Giải trí").ToList(); break;
                case "Quà tặng": tempListAct = tempListAct.Where(act => act.Dept == "Quà tặng").ToList(); break;
                case "Làm đẹp": tempListAct = tempListAct.Where(act => act.Dept == "Làm đẹp").ToList(); break;
            }

            string value = tb_TimKiem.Text.ToLower();
            tempListAct = tempListAct.Where(act => act.Dept.Contains(value) || act.Content.ToLower().Contains(value) || act.Name.ToLower().Contains(value) || act.Position.ToLower().Contains(value) || act.Date.ToLower().Contains(value)).ToList();
            return tempListAct;
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv_Staff.DataSource = getFilteredDataSource();
        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgv_Staff.DataSource = getFilteredDataSource();
            }
        }
    }
}
