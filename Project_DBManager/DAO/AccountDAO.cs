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
        private string username;
        private string userID;
        public static AccountDAO Instance
        {
            get { if(instance == null) instance = new AccountDAO(); return instance; }
            set { AccountDAO.instance = value; }
        }
        public bool checkLogin(string username, string password, int level)
        {
         
            string query = "SELECT * FROM Users as U join Position as P on U.Pos_ID = P.Pos_ID WHERE U.Username = @Username AND U.Password = @Password AND U.IsEnable = 1 AND P.Level = @Level";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, level });
            this.username = username;
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
        public DataTable getAccountInfoByUsername(string username)
        {
            string query = "SELECT Username, User_Email, IsEnable, Pos_Name, Name, FORMAT(Birth, 'dd-MM-yyyy') as Birth, Gender, Address, ID_Card, Department_Name " +
                            "FROM Users as U join Position as P ON U.Pos_ID = P.Pos_ID join User_Info as UF on U.User_ID = UF.User_ID join Department_Member as DM on U.User_ID = DM.User_ID join Department D on D.Department_ID = DM.Department_ID " +
                            "WHERE U.Username = @Username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {username});
        }

        public int getLevelByName(string name)
        {
            string query = "SELECT Pos_ID FROM Users U, User_Info UI Where U.User_ID = UI.User_ID AND UI.Name = @Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {name});
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"].ToString());
        }

        public string getUserNameOfAccountLogin()
        {
            return this.username;
        }
    }
}
