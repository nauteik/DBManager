using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucXemCongViec : UserControl
    {
        private Account account;
        private List<AssignTask> listTask;
        public ucXemCongViec()
        {
            InitializeComponent();
            cbLoc.SelectedIndex = 0;
        }

        public void loadTask(Account account)
        {
            this.account = account;
            string query = "";
            if (account.Level == 1)
            {
                int deptID = StaffDAO.Instance.getDeptIDByUserID(account.UserID);
                query = "SELECT * From Task WHERE Department_ID = " + deptID;
            }
            else
            {
                query = "SELECT * From Task_Detail Where Receiver_ID = " + account.UserID;
            }
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<AssignTask> tempList = new List<AssignTask>();
            foreach (DataRow row in table.Rows)
            {
                tempList.Add(new AssignTask(row, account.Level));
            }
            listTask = tempList;
            dtgv_CongViec.DataSource = getFilteredTask();
        }
        public List<AssignTask> getFilteredTask()
        {
            List<AssignTask> tempListTask = listTask;

            switch (cbLoc.SelectedItem.ToString())
            {
                case "Đã hoàn thành": tempListTask = tempListTask.Where(task => task.IsCompleted == true).ToList(); break;
                case "Chưa hoàn thành": tempListTask = tempListTask.Where(task => task.IsCompleted == false).ToList(); break;
            }
            string value = tb_TimKiem.Text.ToLower();
            tempListTask = tempListTask.Where(task => task.TaskTitle.ToLower().Contains(value) || task.AssignDate.ToLower().Contains(value) || task.Deadline.ToLower().Contains(value) || task.Sender.ToLower().Contains(value) || task.Description.ToLower().Contains(value)).ToList();
            return tempListTask;
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTask is null)
            {
                return;
            }
            dtgv_CongViec.DataSource = getFilteredTask();
        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (listTask is null)
            {
                return;
            }
            dtgv_CongViec.DataSource = getFilteredTask();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dtgv_CongViec;
            for (int row = 0; row < dgv.RowCount; row++) // Sau khi export header, dòng trống tiếp theo trong excel có row index là 2
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv.Rows[row].Cells[0] as DataGridViewCheckBoxCell; // ColumnCheckbox co index la 2,
                if (checkBoxCell == null || Convert.ToBoolean(checkBoxCell.Value) == false)
                {
                    continue;
                }
                int taskID = Convert.ToInt32(dtgv_CongViec.Rows[row].Cells["TaskID"].Value.ToString());
                bool isSucceed = false;
                if (account.Level == 1) isSucceed = TaskDAO.Instance.completeTask(taskID);
                if (account.Level == 0) isSucceed = TaskDAO.Instance.completeTaskDetail(taskID);
                if (isSucceed) 
                {
                    MessageBox.Show("Xác nhận hoàn thành thành công");
                    ActDAO.Instance.createAct(account.UserID, "Xác nhận hoàn thành công việc \"" + dtgv_CongViec.Rows[row].Cells["TaskTitle"].Value.ToString() + "\"", DateTime.Now);
                } 
                else MessageBox.Show("Xác nhận hoàn thành thất bại");
            }
            loadTask(this.account);
        }
    }
}
