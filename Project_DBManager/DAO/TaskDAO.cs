using Project_DBManager.DTO;
using System.Collections.Generic;
using System.Data;

namespace Project_DBManager.DAO
{
    public class TaskDAO
    {
        private static TaskDAO instance;

        public static TaskDAO Instance { get => instance == null ? new TaskDAO() : instance; set => instance = value; }

        public bool createTask(int senderID, string dept, string taskTitle, string description, string deadline, string assignDate)
        {
            int departmentID = InformationDAO.Instance.getDepartmentIDByName(dept);

            string query = string.Format("INSERT INTO Task(Sender_ID, Department_ID, Task_Title, Task_Description, isCompleted, Deadline, AssignDate) VALUES ({0}, {1}, N'{2}', N'{3}', 0, '{4}', '{5}')", senderID, departmentID, taskTitle, description, deadline, assignDate);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool createTaskDetail(int senderID, string staffName, string taskTitle, string description, string deadline, string assignDate)
        {
            int receiverID = StaffDAO.Instance.getUserIDByName(staffName);

            string query = string.Format("INSERT INTO Task_Detail(Sender_ID, Receiver_ID, Task_Title, Task_Description, isCompleted, Deadline, AssignDate) VALUES ({0}, {1}, N'{2}', N'{3}', 0, '{4}', '{5}')", senderID, receiverID, taskTitle, description, deadline, assignDate);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public List<Task> getListTask(int userID)
        {
            List<Task> list = new List<Task>();
            string query = string.Format("SELECT * From Task WHERE Sender_ID = {0}", userID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row  in table.Rows)
            {
                list.Add(new Task(row));
            }
            return list;
        }
        public List<TaskDetail> getListTaskDetail(int userID)
        {
            List<TaskDetail> list = new List<TaskDetail>();
            string query = string.Format("SELECT * From Task_Detail WHERE Sender_ID = {0}", userID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new TaskDetail(row));
            }
            return list;
        }
        public List<string> getStaffNameList(int deptID)
        {
          
            List<string> staffList = new List<string>();
            string query = "SELECT UF.Name From User_Info UF, Users U, Department_Member DM WHERE UF.User_ID = U.User_ID AND U.Pos_ID = 0 AND DM.User_ID = U.User_ID AND DM.Department_ID = " + deptID;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                staffList.Add(row["Name"].ToString());
            }
            return staffList;
        }
        public bool completeTask(int taskID)
        {
            string query = string.Format("UPDATE Task SET isCompleted = 1 WHERE Task_ID = {0}", taskID);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool completeTaskDetail(int taskID)
        {
            string query = string.Format("UPDATE Task_Detail SET isCompleted = 1 WHERE TaskDetail_ID = {0}", taskID);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool removeTask(int taskID)
        {
            string query = string.Format("DELETE From Task WHERE Task_ID = {0}", taskID);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool removeTaskDetail(int taskID)
        {
            string query = string.Format("DELETE From Task_Detail WHERE TaskDetail_ID = {0}", taskID);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
