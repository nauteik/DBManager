using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DAO
{
    public class ActDAO
    {
        private static ActDAO instance;

        public static ActDAO Instance { get => instance == null ? new ActDAO() : instance; set => instance = value; }

        public List<Act> getListActEmployee(int userID)
        {
            List<Act> list = new List<Act>();
            string query = "SELECT UF.Name, U.Pos_ID, DM.Department_ID, AL.ActTime, AL.Content, AL.Act_ID From Activity_Log AL, Users U, User_Info UF, Department_Member DM WHERE UF.User_ID = U.User_ID AND U.User_ID = AL.User_ID AND AL.User_ID = DM.User_ID AND U.User_ID = " + userID;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows)
            {
                list.Add(new Act(row));
            }
            list.Reverse();
            return list;
        }

        public List<Act> getListActLeader(int deptID)
        {
            List<Act> list = new List<Act>();
            string query = "SELECT UF.Name, U.Pos_ID, DM.Department_ID, AL.ActTime, AL.Content, AL.Act_ID From Activity_Log AL, Users U, User_Info UF, Department_Member DM WHERE UF.User_ID = U.User_ID AND U.User_ID = AL.User_ID AND AL.User_ID = DM.User_ID AND U.Pos_ID <= 1 AND Department_ID = " + deptID;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Act(row));
            }
            list.Reverse();
            return list;
        }

        public List<Act> getListActManager(int posID)
        {
            List<Act> list = new List<Act>();
            string query = "SELECT UF.Name, U.Pos_ID, DM.Department_ID, AL.ActTime, AL.Content, AL.Act_ID From Activity_Log AL, Users U, User_Info UF, Department_Member DM WHERE UF.User_ID = U.User_ID AND U.User_ID = AL.User_ID AND AL.User_ID = DM.User_ID AND U.Pos_ID <= " + posID;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Act(row));
            }
            list.Reverse();
            return list;
        }
        public void createAct(int userID, string content, DateTime now)
        {
            string query = string.Format("INSERT INTO Activity_Log VALUES ({0}, N'{1}', '{2}')", userID, content, now.ToString("MM-dd-yyyy HH:mm:ss"));
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
