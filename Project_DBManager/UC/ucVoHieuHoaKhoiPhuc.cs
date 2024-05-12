using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucVoHieuHoaKhoiPhuc : UserControl
    {
        private List<Staff> listStaff;
        private Account account;

        public Account Account { get => account; set => account = value; }

        public ucVoHieuHoaKhoiPhuc()
        {
            InitializeComponent();
            cb_SapXep.SelectedIndex = 0;
            cbLoc.SelectedIndex = 0;
        }
        public void loadStaff(Account account)
        {
            this.account = account;
            listStaff = StaffDAO.Instance.getListDisableStaff(account);
            dtgv_Staff.DataSource = listStaff;
        }
        public class StaffComparer : IComparer<Staff>
        {
            public int Compare(Staff x, Staff y)
            {
                if (x.Position.Equals(y.Position))
                    return 0;
                if (x.Position == "Quản lý")
                    return 1;
                if (x.Position == "Tổ trưởng" && y.Position != "Quản lý")
                    return 1;
                return -1;
            }
        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            dtgv_Staff.DataSource = getFilteredDataSource();
        }

        private void cb_SapXep_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listStaff is null)
            {
                return;
            }
            dtgv_Staff.DataSource = getFilteredDataSource();
        }

        private void cbLoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listStaff is null)
            {
                return;
            }
            dtgv_Staff.DataSource = getFilteredDataSource();
        }
        private List<Staff> getFilteredDataSource()
        {
            List<Staff> tempListStaff = listStaff;
            switch (cb_SapXep.SelectedItem.ToString())
            {
                case "Tên nhân viên (A-Z)": tempListStaff = tempListStaff.OrderBy(staff => staff.Name).ToList(); break;
                case "Tên nhân viên (Z-A)": tempListStaff = tempListStaff.OrderByDescending(staff => staff.Name).ToList(); break;
                case "Chức vụ (Cao-thấp)": tempListStaff.Sort(new StaffComparer()); tempListStaff.Reverse(); break;
                case "Chức vụ (Thấp-cao)": tempListStaff.Sort(new StaffComparer()); break;
                case "Vị trí": tempListStaff = tempListStaff.OrderBy(staff => staff.Dept).ToList(); break;
            }
            switch (cbLoc.SelectedItem.ToString())
            {
                case "Quản lý": tempListStaff = tempListStaff.Where(staff => staff.Position == "Quản lý").ToList(); break;
                case "Tổ trưởng": tempListStaff = tempListStaff.Where(staff => staff.Position == "Tổ trưởng").ToList(); break;
                case "Nhân viên": tempListStaff = tempListStaff.Where(staff => staff.Position == "Nhân viên").ToList(); break;
            }
            string value = tb_TimKiem.Text;
            tempListStaff = tempListStaff.Where(staff => staff.Name.ToLower().Contains(value.ToLower()) || staff.Dept.ToLower().Contains(value.ToLower()) || staff.Position.ToLower().Contains(value.ToLower()) || staff.Email.ToLower().Contains(value.ToLower()) || staff.Phone.ToLower().Contains(value)).ToList();
            return tempListStaff;
        }

        private void dtgv_Staff_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv_Staff.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
            }
        }

        private void dtgv_Staff_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv_Staff.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dtgv_Staff;
            for (int row = 0; row < dgv.RowCount; row++) // Sau khi export header, dòng trống tiếp theo trong excel có row index là 2
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv.Rows[row].Cells[1] as DataGridViewCheckBoxCell; // ColumnCheckbox co index la 2,
                if ((checkBoxCell == null || Convert.ToBoolean(checkBoxCell.Value) == false))
                {
                    continue;
                }
                int userID = Convert.ToInt32(dtgv_Staff.Rows[row].Cells[7].Value.ToString());
                bool isSucceed = AccountDAO.Instance.enableAccount(userID);
                if (isSucceed) { MessageBox.Show("Mở khoá thành công"); }
            }
        }
        private void dtgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                loadThongTinNhanVien(Convert.ToInt32(dtgv_Staff.Rows[e.RowIndex].Cells[7].Value.ToString()));
            }
        }
        private void dtgv_Staff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadThongTinNhanVien(Convert.ToInt32(dtgv_Staff.Rows[e.RowIndex].Cells[7].Value.ToString()));
            }
        }
        private void loadThongTinNhanVien(int userID)
        {
            ucThongTinNhanVien1.Account = this.account;
            ucThongTinNhanVien1.loadInfo(userID);
            ucThongTinNhanVien1.Visible = true;
        }
    }
}
