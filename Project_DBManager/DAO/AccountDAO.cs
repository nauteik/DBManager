﻿using Project_DBManager.DTO;
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
        public bool updateAccountInfoByUserID(string hoTen, string cccd, string email, string position, string address, string dept, string birth, string gender, int userID)
        {
            string query = string.Format("UPDATE User_Info SET Name = N'{0}', ID_Card = {1},  Gender = N'{2}', Address = N'{3}', Birth = '{4}' WHERE User_ID = {5}", hoTen, cccd, gender, address, birth, userID);
            bool firstExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            int posID = 0;
            switch (position)
            {
                case "Manager": posID = 2; break;
                case "Leader": posID = 1; break;
                case "Employee": posID = 0; break;
            }
            query = string.Format("UPDATE Users SET User_Email = '{0}', Pos_ID = {1} WHERE User_ID = {2}", email, posID, userID);
            bool secondExecution = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            return firstExecution && secondExecution;
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

    }
}
