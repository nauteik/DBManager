﻿using Microsoft.Office.Interop.Excel;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Project_DBManager
{
    public partial class ucDanhSachNhanVien : UserControl
    {
        private List<Staff> listStaff;
        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            cb_SapXep.SelectedIndex = 0;
            cbLoc.SelectedIndex = 0;
        }
        public void loadStaff(Account account)
        {
            listStaff = StaffDAO.Instance.getListStaff(account);
            dtgv_Staff.DataSource = listStaff;
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
            // export header
            for (int column = 2; column < dgv.ColumnCount-1; column++)
            {
                worksheet.Cells[1, column-1] = dgv.Columns[column].HeaderText;
            }
            int skippedRow = 0;
            // export content
            for (int row= 2; row < dgv.RowCount+2; row++) // Sau khi export header, dòng trống tiếp theo trong excel có row index là 2
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv.Rows[row - 2].Cells[1] as DataGridViewCheckBoxCell; // ColumnCheckbox co index la 2,
                if ((checkBoxCell == null || Convert.ToBoolean(checkBoxCell.Value) == false) && exportAll == false)
                {
                    skippedRow++;
                    continue;
                }
                for (int column = 2; column < dgv.ColumnCount-1; column++)
                {
                    object cellValue = dgv.Rows[row-2].Cells[column].Value;
                    if (cellValue != null)
                    {
                        if (dgv.Columns[column].HeaderText == "Số điện thoại")
                        {
                            worksheet.Cells[row - skippedRow, column-1] = "'" + cellValue.ToString();
                            continue;
                        }
                        worksheet.Cells[row - skippedRow , column-1] = cellValue.ToString();
                    }
                    else
                    {
                        worksheet.Cells[row - skippedRow, column-1] = ""; // hoặc giá trị mặc định khác tuỳ ý
                    }
                }
            }
            
            worksheet.Columns.AutoFit();
            // Save the Excel file
            // Save the workbook with desired file name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "exportExcel.xlsx";

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

        private void tb_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dtgv_Staff.DataSource = getFilteredDataSource();
                tb_TimKiem.Text = "";
            }

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
                case "Manager": tempListStaff = tempListStaff.Where(staff => staff.Position == "Manager").ToList(); break;
                case "Leader": tempListStaff = tempListStaff.Where(staff => staff.Position == "Leader").ToList(); break;
                case "Employee": tempListStaff = tempListStaff.Where(staff => staff.Position == "Employee").ToList(); break;
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

        private void dtgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                ucThongTinNhanVien1.loadInfo(Convert.ToInt32(dtgv_Staff.Rows[e.RowIndex].Cells[7].Value.ToString()));
                ucThongTinNhanVien1.Visible = true;
            }
        }

        private void dtgv_Staff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgv_Staff.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                ucThongTinNhanVien1.loadInfo(Convert.ToInt32(dtgv_Staff.Rows[e.RowIndex].Cells[7].Value.ToString()));
                ucThongTinNhanVien1.Visible = true;
            }
        }
    }
}