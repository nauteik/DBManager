using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if(instance == null) instance = new AccountDAO(); return instance; }
            set { AccountDAO.instance = value; }
        }
        public bool checkLogin(string username, string password, int level)
        {

            string query = "SELECT * FROM Users as U join Position as P on U.Pos_ID = P.Pos_ID WHERE U.Username = @Username AND U.Password = @Password AND U.IsEnable = 1 AND P.Level = @Level";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, level });
            return result.Rows.Count > 0;
        }
    }
}
