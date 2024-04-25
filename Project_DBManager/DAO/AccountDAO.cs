using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public DataTable getAccountInfoByUsername(string username)
        {
            string query = "SELECT Username, User_Email, IsEnable, Pos_Name, Name, FORMAT(Birth, 'dd-MM-yyyy') as Birth, Gender, Address, ID_Card, Department_Name " +
                            "FROM Users as U join Position as P ON U.Pos_ID = P.Pos_ID join User_Info as UF on U.User_ID = UF.User_ID join Department_Member as DM on U.User_ID = DM.User_ID join Department D on D.Department_ID = DM.Department_ID " +
                            "WHERE U.Username = @Username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {username});
        }
        public DataTable getAccountInfoByUserID(int userID)
        {
            string query = "SELECT Username, User_Email, IsEnable, Pos_Name, Name, FORMAT(Birth, 'dd-MM-yyyy') as Birth, Gender, Address, ID_Card, Department_Name " +
                            "FROM Users as U join Position as P ON U.Pos_ID = P.Pos_ID join User_Info as UF on U.User_ID = UF.User_ID join Department_Member as DM on U.User_ID = DM.User_ID join Department D on D.Department_ID = DM.Department_ID " +
                            "WHERE U.User_ID = @userID";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { userID });
        }
        public bool updateAccountInfoByUserID(string hoTen, string cccd, string email, string position, string address, string dept, string birth, string gender, int userID, int isEnable)
        {
            string query = string.Format("UPDATE User_Info SET Name = N'{0}', ID_Card = {1},  Gender = N'{2}', Address = N'{3}', Birth = '{4}' WHERE User_ID = {5}", hoTen, cccd, gender, address, birth, userID);
            bool firstExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            int posID = 0;
            switch (position)
            {
                case "Quản lý": posID = 2; break;
                case "Tổ trưởng": posID = 1; break;
                case "Nhân viên": posID = 0; break;
            }
            query = string.Format("UPDATE Users SET User_Email = '{0}', Pos_ID = {1}, IsEnable = {2} WHERE User_ID = {3}", email, posID, isEnable, userID);
            bool secondExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            int departmentID = InformationDAO.Instance.getDepartmentIDByName(dept);
            query = string.Format("UPDATE Department_Member SET Department_ID = {0} WHERE User_ID = {1}", departmentID, userID);
            bool thirdExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            return firstExecution && secondExecution && thirdExecution;
        }
        public bool enableAccount(int userID)
        {
            string query = string.Format("UPDATE Users SET IsEnable = 1 WHERE User_ID = {0}", userID);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public int getLevelByName(string name)
        {
            string query = "SELECT Pos_ID FROM Users U, User_Info UI Where U.User_ID = UI.User_ID AND UI.Name = @Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"].ToString());
        }

        public List<string> getNameList()
        {
            List<string> nameList = new List<string>();
            string query = "SELECT Name FROM User_Info";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                nameList.Add(row["Name"].ToString());
            }
            return nameList;
        }
        
        public int getLevelByContractId(int id)
        {
            string query = "SELECT Pos_ID FROM Users U, Contract C WHERE U.User_ID = C.User_ID AND Contract_ID = @Contract_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {id});
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"].ToString());
        }
        public bool createAccount(string username, string password, string email, int pos_ID, string hoten, string ngaySinh, string gioiTinh, string diaChi, string CCCD, string sdt)
        {
            
            string query = string.Format("INSERT INTO Users(Username, Password, User_Email, IsEnable, Pos_ID) VALUES ('{0}', '{1}', '{2}', 1, {3})",username, password, email, pos_ID);
            bool firstExecetuion = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            if(firstExecetuion == false)
            {
                return false;
            }
            int user_ID = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(string.Format("SELECT User_ID From Users WHERE Username = '{0}'", username)).Rows[0]["User_ID"]);
            query = string.Format("INSERT INTO User_Info (User_ID, Name, Birth, Gender, Address, ID_Card, PhoneNum) VALUES " +
                                    "({0}, N'{1}', '{2}', N'{3}', '{4}', '{5}', '{6}')", user_ID, hoten, ngaySinh, gioiTinh, diaChi, CCCD, sdt);
            bool secondExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            if(secondExecution == false)
            {
                DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM Users WHERE Username = '{0}'", username));
                return false;
            }
            return firstExecetuion && secondExecution;
        }
        public bool validateUsername(string username)
        {
            string query = string.Format("SELECT * FROM Users WHERE Username ={0}", username);
            if(DataProvider.Instance.ExecuteQuery(query).Rows.Count != 0)
            {
                return false;
            }
            return true;
        }
        public bool validateEmail(string email)
        {
            string query = string.Format("SELECT * FROM Users WHERE User_Enmail ={0}", email);
            if (DataProvider.Instance.ExecuteQuery(query).Rows.Count != 0)
            {
                return false;
            }
            return true;
        }
        public List<AccountWithPhone> getListAccountWithPhone()
        {
            string query = "Select Username,Password, phoneNum, User_Email, U.User_ID From Users U, User_Info UF Where U.User_ID = UF.User_ID";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<AccountWithPhone> listAccount= new List<AccountWithPhone>();
            foreach (DataRow row in table.Rows)
            {
                listAccount.Add(new AccountWithPhone(row));
            }
            return listAccount;
        }
       
    }
}
