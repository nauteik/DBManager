using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class AssignTask
    {
        private bool isChecked;
        private string taskTitle;
        private string sender;
        private string assignDate;
        private string deadline;
        private string description;
        private bool isCompleted;
        private int taskID;

        public AssignTask(DataRow row, int level)
        {
            isChecked = false;
            taskTitle = row["Task_Title"].ToString();
            if(level == 0) taskID = Convert.ToInt32(row["TaskDetail_ID"].ToString());
            if(level == 1) taskID = Convert.ToInt32(row["Task_ID"].ToString());
            assignDate = Convert.ToDateTime(row["AssignDate"]).ToString("dd-MM-yyyy");
            deadline = Convert.ToDateTime(row["Deadline"]).ToString("dd-MM-yyyy");
            description = row["Task_Description"].ToString();
            isCompleted = Convert.ToInt32(row["IsCompleted"].ToString()) == 0 ? false : true;
            sender = StaffDAO.Instance.getStaffNameByUserID(Convert.ToInt32(row["Sender_ID"].ToString()));
        }

        public string TaskTitle { get => taskTitle; set => taskTitle = value; }

        public string Sender { get => sender; set => sender = value; }
        public string AssignDate { get => assignDate; set => assignDate = value; }
        public string Deadline { get => deadline; set => deadline = value; }
        public string Description { get => description; set => description = value; }
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
        public int TaskID { get => taskID; set => taskID = value; }
    }
}
