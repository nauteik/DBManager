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
        private string taskName;
        private string dept;
        private string deadline;
        private string content;

        public string TaskName { get => taskName; set => taskName = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Deadline { get => deadline; set => deadline = value; }
        public string Content { get => content; set => content = value; }

        public Task(DataRow row)
        {

        }
    }
}
