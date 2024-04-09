using Microsoft.Office.Interop.Excel;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class ucDanhSachNhanVien : UserControl
    {
        private List<Staff> listStaff;
        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            cb_SapXep.SelectedIndex = 0;
        }
        public void loadStaff(Account account)
        {
            listStaff = StaffDAO.Instance.getListStaff(account);
            dtgv_Staff.DataSource = listStaff;
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

        private void cb_SapXep_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if(listStaff is null)
            {
                return;
            }
            List<Staff> tempListStaff = new List<Staff>();
            if(cb_SapXep.SelectedItem.ToString() == "Tên nhân viên (A-Z)")
            {
                tempListStaff = listStaff.OrderBy(staff => staff.Name).ToList();
                dtgv_Staff.DataSource = tempListStaff;
            }
            if (cb_SapXep.SelectedItem.ToString() == "Tên nhân viên (Z-A)")
            {
                tempListStaff = listStaff.OrderByDescending(staff => staff.Name).ToList();
                dtgv_Staff.DataSource = tempListStaff;
            }
            if (cb_SapXep.SelectedItem.ToString() == "Chức vụ (Cao-thấp)")
            {
                tempListStaff = new List<Staff>(listStaff);
                tempListStaff.Sort(new StaffComparer());
                tempListStaff.Reverse();
                dtgv_Staff.DataSource = tempListStaff;
            }
            if (cb_SapXep.SelectedItem.ToString() == "Chức vụ (Thấp-cao)")
            {
                tempListStaff = new List<Staff>(listStaff);
                tempListStaff.Sort(new StaffComparer());
                dtgv_Staff.DataSource = tempListStaff;
            }
            if (cb_SapXep.SelectedItem.ToString() == "Vị trí")
            {
                tempListStaff = listStaff.OrderBy(staff => staff.Dept).ToList();
                dtgv_Staff.DataSource = tempListStaff;
            }

        }
        public class StaffComparer : IComparer<Staff>
        {
            public int Compare(Staff x, Staff y)
            {
                if (x.Position.Equals(y.Position))
                    return 0;
                if (x.Position == "Manager")
                    return 1;
                if (x.Position == "Leader" && y.Position != "Manager")
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
            // Create a new Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create a new Excel workbook
            Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Create a new Excel worksheet
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Danh sách nhân viên";
            worksheet.Columns.AutoFit();
            worksheet.Cells[1, 1] = "asdc";
            // export header
            for (int column = 1; column < dgv.ColumnCount-1; column++)
            {
                worksheet.Cells[1, column] = dgv.Columns[column+1].HeaderText;
            }
            int skippedRow = 0;
            // export content
            for (int row= 2; row < dgv.RowCount+2; row++)
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv.Rows[row - 2].Cells[0] as DataGridViewCheckBoxCell;
                if ((checkBoxCell == null || Convert.ToBoolean(checkBoxCell.Value) == false) && exportAll == false)
                {
                    skippedRow++;
                    continue;
                }
                for (int column = 1; column < dgv.ColumnCount-1; column++)
                {
                    object cellValue = dgv.Rows[row-2].Cells[column+1].Value;
                    if (cellValue != null)
                    {
                        if (dgv.Columns[column+1].HeaderText == "Số điện thoại")
                        {
                            worksheet.Cells[row - skippedRow, column] = "'" + cellValue.ToString();
                            continue;
                        }
                        worksheet.Cells[row - skippedRow , column] = cellValue.ToString();
                    }
                    else
                    {
                        worksheet.Cells[row - skippedRow, column] = ""; // hoặc giá trị mặc định khác tuỳ ý
                    }
                }
            }
            
            worksheet.Columns.AutoFit();
            // Save the Excel file
            // Save the workbook with desired file name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "exportExcel.xlsx"; // Set the default file name to "Book.xlsx"

            // Allow user to choose the path where the file will be saved
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the workbook to the selected path
                workbook.SaveAs(saveFileDialog.FileName);
            }
            excel.Visible = true;

            // Release Excel objects from memory
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

            MessageBox.Show("DataGridView data exported to Excel successfully.");
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

        private void dtgv_Staff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                e.Value = Properties.Resources.arrow;
            }
        }
    }
}
