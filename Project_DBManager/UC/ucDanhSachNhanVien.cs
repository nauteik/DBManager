using Microsoft.Office.Interop.Excel;
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
    public partial class ucDanhSachNhanVien : UserControl
    {
        private List<Staff> listStaff;
        private Account account;
        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            cb_SapXep.SelectedIndex = 0;
            cbLoc.SelectedIndex = 0;
        }
        public void loadStaff(Account account)
        {
            this.account = account;
            listStaff = StaffDAO.Instance.getListStaff(account);
            listStaff = listStaff.Where(staff => InformationDAO.Instance.getLevelByPosition(staff.Position) <= account.Level).ToList();
            dtgv_Staff.DataSource = listStaff;
        }





        public class StaffComparer : IComparer<Staff>
        {
            public int Compare(Staff x, Staff y)
            {
                if (x.Position.Equals(y.Position))
                    return 0;
                if (x.Position == "CEO")
                    return 1;
                if (y.Position == "CEO")
                    return -1;
                if (x.Position == "Quản lý")
                    return 1;
                if (x.Position == "Tổ trưởng" && y.Position != "Quản lý")
                    return 1;
                return -1;
            }
        }

        private void btn_XuatDuLieu_Click(object sender, System.EventArgs e)
        {
            ExportToExcel(dtgv_Staff, false);
        }
        private void ExportToExcel(DataGridView dgv, bool exportAll)
        {
            string text;
            if (exportAll)
            {
                text = "Bạn có muốn tải xuống tất cả dữ liệu?";
            }
            else
            {
                text = "Bạn có muốn tải xuống dữ liệu đã được chọn?";
            }
            DialogResult result = MessageBox.Show(text, "Tải xuống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            // Create a new Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create a new Excel workbook
            Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Create a new Excel worksheet
            Worksheet worksheet = workbook.Sheets[1] as Worksheet;
            worksheet.Name = "Danh sách nhân viên";
            // export header
            for (int column = 2; column < dgv.ColumnCount - 1; column++)
            {
                worksheet.Cells[1, column - 1] = dgv.Columns[column].HeaderText;
            }
            int skippedRow = 0;
            // export content
            for (int row = 2; row < dgv.RowCount + 2; row++) // Sau khi export header, dòng trống tiếp theo trong excel có row index là 2
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv.Rows[row - 2].Cells[1] as DataGridViewCheckBoxCell; // ColumnCheckbox co index la 2,
                if ((checkBoxCell == null || Convert.ToBoolean(checkBoxCell.Value) == false) && exportAll == false)
                {
                    skippedRow++;
                    continue;
                }
                for (int column = 2; column < dgv.ColumnCount - 1; column++)
                {
                    object cellValue = dgv.Rows[row - 2].Cells[column].Value;
                    if (cellValue != null)
                    {
                        if (dgv.Columns[column].HeaderText == "Số điện thoại")
                        {
                            worksheet.Cells[row - skippedRow, column - 1] = "'" + cellValue.ToString();
                            continue;
                        }
                        worksheet.Cells[row - skippedRow, column - 1] = cellValue.ToString();
                    }
                    else
                    {
                        worksheet.Cells[row - skippedRow, column - 1] = ""; // hoặc giá trị mặc định khác tuỳ ý
                    }
                }
            }

            worksheet.Columns.AutoFit();
            excel.Visible = true;

            // Release Excel objects from memory
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }

        private void pb_TaiXuong_Click(object sender, EventArgs e)
        {
            ExportToExcel(dtgv_Staff, true);
        }

        private void pb_TaiXuong_MouseEnter(object sender, EventArgs e)
        {
            pb_TaiXuong.BackColor = Color.LightGray;
        }

        private void pb_TaiXuong_MouseLeave(object sender, EventArgs e)
        {
            pb_TaiXuong.BackColor = Color.White;
        }

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            dtgv_Staff.DataSource = getFilteredDataSource();
        }

        private void cb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_SapXep_SelectedValueChanged(object sender, System.EventArgs e)
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

        private void dtgv_Staff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if(this.account.Level <= 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập");
                    return;
                }
                loadThongTinNhanVien(Convert.ToInt32(dtgv_Staff.Rows[e.RowIndex].Cells[7].Value.ToString()));
            }
        }

        private void dtgv_Staff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.account.Level <= 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập");
                    return;
                }
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
