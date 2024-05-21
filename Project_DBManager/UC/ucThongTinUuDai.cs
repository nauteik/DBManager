using Microsoft.Office.Interop.Excel;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project_DBManager.UC
{

    public partial class ucThongTinUuDai : UserControl
    {
        private List<BrandInfo> listBrand = new List<BrandInfo>();
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public ucThongTinUuDai()
        {
            InitializeComponent();
            loadOffer();
            adjustOrder();
            cbLoc.SelectedIndex = 0;
            cbSapXep.SelectedIndex = 0;
            ucChinhSuaThongTinUuDai1.Hide();
        }

        public void adjustOrder()
        {
            dtgv.Columns["Selected"].DisplayIndex = 0;
            dtgv.Columns["BrandName"].DisplayIndex = 1;
            dtgv.Columns["Type"].DisplayIndex = 2;
            dtgv.Columns["Status"].DisplayIndex = 3;
            dtgv.Columns["Phone"].DisplayIndex = 4;
            dtgv.Columns["Edit"].DisplayIndex = 5;
        }
        public void loadOffer()
        {
            listBrand = BrandDAO.Instance.getListBrandInfo();
            dtgv.DataSource = listBrand;
            dtgv.Columns["Brand_ID"].Visible = false;
            dtgv.Columns["Introduction"].Visible = false;
            dtgv.Columns["Facebook"].Visible = false;
            dtgv.Columns["Address"].Visible = false;
            dtgv.Columns["Google"].Visible = false;
            adjustOrder();
            dtgv.DataSource = listBrand;
        }


        private void labelSapXep_Click(object sender, EventArgs e)
        {

        }


        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {

                ucChinhSuaThongTinUuDai1.setAccount(acc);
                ucChinhSuaThongTinUuDai1.loadInfo(listBrand[e.RowIndex]);
                ucChinhSuaThongTinUuDai1.Show();
            }
        }
        private List<BrandInfo> getFilteredDataSource()
        {
            List<BrandInfo> tempList = listBrand;
            switch (cbSapXep.Text)
            {
                case "Chủ đề": tempList = tempList.OrderBy(brand => brand.Type).ToList(); break;
                case "Tên thương hiệu": tempList = tempList.OrderBy(brand => brand.BrandName).ToList(); break;
                case "Trạng thái": tempList = tempList.OrderBy(brand => brand.Status).ToList(); break;
                case "Không": break;
              
            }
            switch (cbLoc.Text)
            {
                case "Chưa tạo bài đăng": tempList = tempList.Where(oi => (oi.Status).Equals("Chưa tạo bài đăng")).ToList(); break;
                case "Đã tạo bài đăng": tempList = tempList.Where(oi => (oi.Status).Equals("Đã tạo bài đăng")).ToList(); break;
                case "Đã đóng": tempList = tempList.Where(oi => (oi.Status).Equals("Đóng")).ToList(); break;
                case "Không": break;
            }
            string value = tbTimKiem.Text.ToLower();
            tempList = tempList.Where(oi => (oi.BrandName.ToLower()).Contains(value) || oi.Type.ToLower().Contains(value) || oi.Status.Contains(value) || oi.PhoneNumber.Contains(value)).ToList();
            return tempList;
        }
        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = getFilteredDataSource();
        }
        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = getFilteredDataSource();
        }

        private void ToExcel(DataGridView dgv, bool exportAll)
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
            Workbook workbook = excel.Workbooks.Add(System.Type.Missing);

            // Create a new Excel worksheet
            Worksheet worksheet = workbook.Sheets[1] as Worksheet;
            worksheet.Name = "Danh sách nhân viên";
            adjustOrder();
            // export header
            int skip = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == false)
                {
                    skip++;
                    continue;
                }
                if (dgv.Columns[i].GetType() != typeof(DataGridViewTextBoxColumn))
                {
                    skip++;
                    continue;
                }
                if (dgv.Columns[i].Visible)
                {
                    worksheet.Cells[1, i + 1 - skip] = dgv.Columns[i].HeaderText;
                }
            }
            worksheet.Cells[1, 5] = "Địa chỉ";
            worksheet.Cells[1, 6] = "Website";
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
                        if (dgv.Columns[column].HeaderText == "SDT")
                        {
                            worksheet.Cells[row - skippedRow, column - 1] = "'" + cellValue.ToString();
                            continue;
                        }
                        if(column-1 == 7)
                        {
                            break;
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

        private void pictureBoxTaiXuong_Click(object sender, EventArgs e)
        {
            ToExcel(dtgv, true);

        }

        private void btXoaDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa các dòng dữ liệu đã được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<BrandInfo> tempList = dtgv.DataSource as List<BrandInfo>;
                foreach(BrandInfo temp in tempList)
                {
                    if(temp.IsChecked == true)
                    {
                        if (ContractDAO.Instance.isContractExistByBrandID(temp.Brand_ID)) { MessageBox.Show("Xóa hợp đồng trước khi xóa thương hiệu"); return; }
                        if (PostDAO.Instance.isPostExistByBrandID(temp.Brand_ID)) { MessageBox.Show("Xóa bài đăng trước khi xóa thương hiệu"); return; }
                        if (BrandDAO.Instance.deleteBrand(temp.Brand_ID))
                        {
                            MessageBox.Show("Xóa thương hiệu " + temp.BrandName + " thành công");
                            ActDAO.Instance.createAct(acc.UserID, "Xóa thương hiệu " + temp.BrandName, DateTime.Now);
                        }
                    }
                }
                loadOffer();
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgv.DataSource = getFilteredDataSource();
            }
        }

        private void buttonXuatDuLieu_Click(object sender, EventArgs e)
        {
            ToExcel(dtgv, false);
        }

       

        private void dtgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
            }
        }

        private void dtgv__CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void dtgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {
                ucChinhSuaThongTinUuDai1.setAccount(acc);
                ucChinhSuaThongTinUuDai1.loadInfo(listBrand[e.RowIndex]);
                ucChinhSuaThongTinUuDai1.Show();
            }
            
        }
    }
}
