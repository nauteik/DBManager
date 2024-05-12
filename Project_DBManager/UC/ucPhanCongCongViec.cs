using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucPhanCongCongViec : UserControl
    {
        private Account account;
        private List<Task> listTask;
        private List<TaskDetail> listTaskDetail;
        private bool isSetup = false;
        public ucPhanCongCongViec()
        {
            InitializeComponent();
            cb_ViTri.SelectedIndex = 0;
            cbLoc.SelectedIndex = 0;
        }
        public void loadTask(Account account)
        {
            this.account = account;
            this.listTask = TaskDAO.Instance.getListTask(account.UserID);
            this.listTaskDetail = TaskDAO.Instance.getListTaskDetail(account.UserID);
            if (isSetup == false)
            {
                if(account.Level == 1)
                {
                    lb_ChonViTri.Text = "Chọn nhân viên";
                    dtgv_CongViec.Columns["ViTri"].HeaderText = "Nhân viên";
                    cb_ViTri.Items.Clear();
                    List<string> staffList = TaskDAO.Instance.getStaffNameList(StaffDAO.Instance.getDeptIDByUserID(account.Level));
                    foreach(string temp in staffList)
                    {
                        cb_ViTri.Items.Add(temp);
                    }
                    dtgv_CongViec.DataSource = getFilteredTaskDetail();
                    return;
                }
            }
           
            dtgv_CongViec.DataSource = getFilteredTask();
        }
        private void btn_TaoCongViec_Click(object sender, EventArgs e)
        {
            string dept = cb_ViTri.Text;
            string taskName = tb_TenCongViec.Text;
            string deadline = dtpk_Deadline.Value.ToString("MM-dd-yyyy");
            string assignDate = DateTime.Now.ToString("MM-dd-yyyy");
            string description = tb_GhiChu.Text;
            int userID = account.UserID;
            bool isSucceed = false;
            if(account.Level == 1)
            {
                isSucceed = TaskDAO.Instance.createTaskDetail(userID, dept, taskName, description, deadline, assignDate);
            }
            else
            {
                isSucceed = TaskDAO.Instance.createTask(userID, dept, taskName, description, deadline, assignDate);
            }
            
            if (isSucceed)
            {
                MessageBox.Show("Tạo công việc thành công");
                loadTask(this.account);
            }
            else
            {
                MessageBox.Show("Tạo công việc thất bại");
            }

        }
        private List<Task> getFilteredTask()
        {
            List<Task> tempListTask = listTask;
            //switch (cb_SapXep.SelectedItem.ToString())
            //{
            //    case "Tên nhân viên (A-Z)": tempListStaff = tempListStaff.OrderBy(staff => staff.Name).ToList(); break;
            //    case "Tên nhân viên (Z-A)": tempListStaff = tempListStaff.OrderByDescending(staff => staff.Name).ToList(); break;
            //    case "Chức vụ (Cao-thấp)": tempListStaff.Sort(new StaffComparer()); tempListStaff.Reverse(); break;
            //    case "Chức vụ (Thấp-cao)": tempListStaff.Sort(new StaffComparer()); break;
            //    case "Vị trí": tempListStaff = tempListStaff.OrderBy(staff => staff.Dept).ToList(); break;
            //}
            switch (cbLoc.SelectedItem.ToString())
            {
                case "Đã hoàn thành": tempListTask = tempListTask.Where(task => task.IsCompleted == true).ToList(); break;
                case "Chưa hoàn thành": tempListTask = tempListTask.Where(task => task.IsCompleted == false).ToList(); break;
            }
            string value = tb_TimKiem.Text.ToLower();
            tempListTask = tempListTask.Where(task => task.TaskTitle.ToLower().Contains(value) || task.AssignDate.ToLower().Contains(value) || task.Deadline.ToLower().Contains(value) || task.Department.ToLower().Contains(value) || task.Description.ToLower().Contains(value)).ToList();
            return tempListTask;

        }
        private List<TaskDetail> getFilteredTaskDetail()
        {
            List<TaskDetail> tempListTaskDetail = listTaskDetail;
            //switch (cb_SapXep.SelectedItem.ToString())
            //{
            //    case "Tên nhân viên (A-Z)": tempListStaff = tempListStaff.OrderBy(staff => staff.Name).ToList(); break;
            //    case "Tên nhân viên (Z-A)": tempListStaff = tempListStaff.OrderByDescending(staff => staff.Name).ToList(); break;
            //    case "Chức vụ (Cao-thấp)": tempListStaff.Sort(new StaffComparer()); tempListStaff.Reverse(); break;
            //    case "Chức vụ (Thấp-cao)": tempListStaff.Sort(new StaffComparer()); break;
            //    case "Vị trí": tempListStaff = tempListStaff.OrderBy(staff => staff.Dept).ToList(); break;
            //}
            switch (cbLoc.SelectedItem.ToString())
            {
                case "Đã hoàn thành": tempListTaskDetail = tempListTaskDetail.Where(task => task.IsCompleted == true).ToList(); break;
                case "Chưa hoàn thành": tempListTaskDetail = tempListTaskDetail.Where(task => task.IsCompleted == false).ToList(); break;
            }
            string value = tb_TimKiem.Text.ToLower();
            tempListTaskDetail = tempListTaskDetail.Where(task => task.TaskTitle.ToLower().Contains(value) || task.AssignDate.ToLower().Contains(value) || task.Deadline.ToLower().Contains(value) || task.Department.ToLower().Contains(value) || task.Description.ToLower().Contains(value)).ToList();
            return tempListTaskDetail;

        }
        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listTask is null)
            {
                return;
            }
            if(account.Level == 1) { dtgv_CongViec.DataSource = getFilteredTaskDetail(); return; }
            dtgv_CongViec.DataSource = getFilteredTask();

        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(listTask is null)
            {
                return;
            }
            if (account.Level == 1) { dtgv_CongViec.DataSource = getFilteredTaskDetail(); return; }
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
                if(account.Level == 1)
                {
                    isSucceed = TaskDAO.Instance.completeTaskDetail(taskID);
                }
                else
                {
                    isSucceed = TaskDAO.Instance.completeTask(taskID);
                }
                if (isSucceed) MessageBox.Show("Xác nhận hoàn thành thành công");
                    else MessageBox.Show("Xác nhận hoàn thành thất bại");
            }
            loadTask(this.account);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
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
                if (account.Level == 1)
                {
                    isSucceed = TaskDAO.Instance.removeTaskDetail(taskID);
                }
                else
                {
                    isSucceed = TaskDAO.Instance.removeTask(taskID);
                }
                if (isSucceed) MessageBox.Show("Xóa công việc thành công");
                else MessageBox.Show("Xóa công việc thất bại");
            }
            loadTask(this.account);
        }
    }
}
