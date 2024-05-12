using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance { get => instance == null ? new StaffDAO() : instance; set => instance = value; }
        public List<Staff> getListStaff(Account account)
        {
            string query = "Select UF.Name, P.Pos_Name, D.Department_Name, UF.phoneNum, U.User_Email, U.User_ID From Users U, User_Info UF, Position P, Department_Member DM, Department D Where U.Pos_ID = P.Pos_ID AND U.User_ID = UF.User_ID AND DM.User_ID = U.User_ID AND DM.Department_ID = D.Department_ID AND U.IsEnable = 1";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<Staff> listStaff = new List<Staff>();
            foreach (DataRow row in table.Rows)
            {
                listStaff.Add(new Staff(row));
            }
            return listStaff;
        }
        public List<Staff> getListDisableStaff(Account account)
        {
            string query = "Select UF.Name, P.Pos_Name, D.Department_Name, UF.phoneNum, U.User_Email, U.User_ID From Users U, User_Info UF, Position P, Department_Member DM, Department D Where U.Pos_ID = P.Pos_ID AND U.User_ID = UF.User_ID AND DM.User_ID = U.User_ID AND DM.Department_ID = D.Department_ID AND U.IsEnable = 0";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<Staff> listStaff = new List<Staff>();
            foreach (DataRow row in table.Rows)
            {
                listStaff.Add(new Staff(row));
            }
            return listStaff;
        }
        public string getStaffNameByUserID(int userID)
        {
            string query = "SELECT * From User_Info WHERE User_ID = " + userID;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table.Rows[0]["Name"].ToString();
        }
        public int getUserIDByName(string name)
        {
            string query = string.Format("SELECT * From User_Info WHERE Name = N'{0}' ", name);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return Convert.ToInt32(table.Rows[0]["User_ID"].ToString());
        }
        public int getDeptIDByUserID(int userID)
        {
            string query = "SELECT * From Department_Member WHERE User_ID = " + userID;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return Convert.ToInt32(table.Rows[0]["Department_ID"].ToString());
        }
    }
}
