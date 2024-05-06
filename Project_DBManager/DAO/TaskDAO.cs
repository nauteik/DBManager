using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_DBManager.DAO
{
    public class TaskDAO
    {
        private static TaskDAO instance;

        public static TaskDAO Instance { get => instance == null ? new TaskDAO() : instance; set => instance = value; }

        public bool createTask(string dept, string taskName, string deadline, string description)
        {
            int departmentID = InformationDAO.Instance.getDepartmentIDByName(dept);

            string query = string.Format("INSERT INTO Task(Department_ID, TaskName, Deadline, Task_Description, isCompleted) VALUES ({0}, N'{1}', N'{2}', N'{3}', 0)", departmentID, taskName, deadline, description);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public List<Task> getListTask(string dept)
        {

            return null;
        }
    }
}
