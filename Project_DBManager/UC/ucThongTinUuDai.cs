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

namespace Project_DBManager
{
    public partial class ucThongTinUuDai : UserControl
    {
        private List<OfferInfo> OfferInfoList = new List<OfferInfo>();

        public ucThongTinUuDai()
        {
            InitializeComponent();
            loadOffer();
        }

        



        private void loadOffer()
        {
            string query = "SELECT * FROM dbo.GET_INFORMATIVE_OFFER_LIST()";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                OfferInfoList.Add(new OfferInfo(row));
            }

            dtgv.DataSource = OfferInfoList;
        }


        private void labelSapXep_Click(object sender, EventArgs e)
        {

        }


        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            List<OfferInfo> sortedList;
            if (cb.SelectedItem.ToString() == "Chủ đề tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(ci => ci.Content).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Chủ đề tăng dần")
            {
                sortedList = OfferInfoList.OrderByDescending(ci => ci.Content).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(ci => ci.Brand_Name).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(ci => ci.Brand_Name).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian thu thập tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(ci => ci.Upload_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian thu thập giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(ci => ci.Upload_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian cập nhật tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(ci => ci.LastChange_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian cập nhật giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(ci => ci.LastChange_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(ci => ci.Status).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(ci => ci.Status).ToList();
                dtgv.DataSource = sortedList;
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh sách ưu đãi";

                // export header
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                        if (cellValue != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = cellValue.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = ""; // hoặc giá trị mặc định khác tuỳ ý
                        }
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Export successful.!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void pictureBoxTaiXuong_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dtgv != null)
                {
                    ToExcel(dtgv, saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("dtgv is null!!");
                }
            }

        }

        private void btXoaDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa các dòng dữ liệu đã được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> postIDList = new List<string>();
                List<OfferInfo> tempList = new List<OfferInfo>();
                dtgv.DataSource = tempList;
                string query = "DELETE FROM Post WHERE Post_ID = ";
                foreach (OfferInfo ci in OfferInfoList)
                {
                    if (ci.isChecked)
                    {
                        postIDList.Add(ci.Post_ID);
                    }
                }
                OfferInfoList.RemoveAll(ci => ci.isChecked);
                foreach (string id in postIDList)
                {
                    DataProvider.Instance.ExecuteQuery(query + id);
                }
                dtgv.DataSource = OfferInfoList;

                MessageBox.Show("Dữ liệu đã được xóa.");
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<OfferInfo> searchList;
                string value = tbTimKiem.Text;
                if (int.TryParse(value, out _))
                {
                    searchList = OfferInfoList.Where(ci => (ci.Brand_Name).Equals(value)).ToList();
                    dtgv.DataSource = searchList;
                }
                else
                {
                    searchList = OfferInfoList.Where(ci => (ci.Brand_Name.ToLower()).Contains(value.ToLower())).ToList();
                    dtgv.DataSource = searchList;
                }
                tbTimKiem.Text = "";
            }
        }

        private void buttonXuatDuLieu_Click(object sender, EventArgs e)
        {

        }
    }
}
