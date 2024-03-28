using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    public class AccountDAO
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
        public Account getAccountByUsername(string username)
        {
            string query = "SELECT * FROM Users as U inner join Position as P ON U.Pos_ID = P.Pos_ID WHERE U.Username = @Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if(data.Rows.Count != 0)
                return new Account(data.Rows[0]);
            return null;
        }
    }
}
