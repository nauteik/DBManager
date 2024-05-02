using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class Task
    {
        private string taskTitle;
        private int taskID;
        private string assignDate;
        private string deadline;
        private string description;
        private bool iscompleted;

        public string TaskTitle { get => taskTitle; set => taskTitle = value; }
        public int TaskID { get => taskID; set => taskID = value; }
        public string AssignDate { get => assignDate; set => assignDate = value; }
        public string Deadline { get => deadline; set => deadline = value; }
        public string Description { get => description; set => description = value; }
        public bool Iscompleted { get => iscompleted; set => iscompleted = value; }
        public Task(DataRow row)
        {
            
        }

      
    }
}
