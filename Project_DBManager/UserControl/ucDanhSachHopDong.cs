using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DBManager
{
    public partial class ucDanhSachHopDong : UserControl
    {
        private DataTable table;
        private string query;
        private List<ContractInfo> contractInfoList = new List<ContractInfo>();

        public ucDanhSachHopDong()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand WHERE Contract.Brand_ID = Brand.Brand_ID";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                ContractInfo contractInfo = new ContractInfo(row);
                contractInfoList.Add(contractInfo);
            }
            dtgv.DataSource = contractInfoList;
        }

        private void lb_TaiXuong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_SapXep_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            List<ContractInfo> sortedList;
            if (cb.SelectedItem.ToString() == "ID tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.ContractID).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "ID giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.ContractID).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.BrandName).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.BrandName).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.SignedDate).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.SignedDate).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.Duration).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.Duration).ToList();
                dtgv.DataSource = sortedList;
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<ContractInfo> searchList;
                string value = tb_TimKiem.Text;
                if (int.TryParse(value, out _))
                {
                    searchList = contractInfoList.Where(ci => (ci.ContractID).Equals(value)).ToList();
                    dtgv.DataSource = searchList;
                }
                else
                {
                    searchList = contractInfoList.Where(ci => (ci.BrandName.ToLower()).Contains(value.ToLower())).ToList();
                    dtgv.DataSource = searchList;
                }
                tb_TimKiem.Text = "";
            }
        }

        private void DanhSachHopDong_Load(object sender, EventArgs e)
        {

        }

        private void exportToExcell(bool isSelectAll)
        {
            string text;
            if (isSelectAll)
            {
                text = "Bạn có muốn tải xuống tất cả dữ liệu?";
            }
            else
            {
                text = "Bạn có muốn tải xuống dữ liệu đã được chọn?";
            }
            DialogResult result = MessageBox.Show(text, "Tải xuống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dtgv.Rows.Count > 0)
                {
                    if (!isSelectAll)
                    {
                        List<ContractInfo> list = new List<ContractInfo>();
                        foreach (ContractInfo ci in contractInfoList)
                        {
                            if (ci.IsChecked)
                            {
                                list.Add(ci);
                            }
                        }
                        dtgv.DataSource = list;
                    }
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 2; i < dtgv.Columns.Count; i++)
                    {
                        MExcel.Cells[1, i - 1] = dtgv.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dtgv.Rows.Count; i++)
                    {
                        for (int j = 2; j < dtgv.Columns.Count; j++)
                        {
                            if (j == 4 || j == 5)
                            {
                                DateTime dt = Convert.ToDateTime(dtgv.Rows[i].Cells[j].Value);
                                MExcel.Cells[i + 2, j - 1] = dt.ToString("dd-MM-yyyy");
                            }
                            else
                            {
                                MExcel.Cells[i + 2, j - 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    dtgv.DataSource = contractInfoList;
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Columns.AutoFit();
                    MExcel.Rows.AutoFit();
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_XuatDuLieu_Click(object sender, EventArgs e)
        {
            exportToExcell(false);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_XoaDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa các dòng dữ liệu đã được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> contractIDList = new List<string>();
                List<ContractInfo> tempList = new List<ContractInfo>();
                dtgv.DataSource = tempList;
                query = "DELETE FROM Contract WHERE Contract_ID = ";
                foreach (ContractInfo ci in contractInfoList)
                {
                    if (ci.IsChecked)
                    {
                        contractIDList.Add(ci.ContractID);
                    }
                }
                contractInfoList.RemoveAll(ci => ci.IsChecked);
                foreach (string id in contractIDList)
                {
                    DataProvider.Instance.ExecuteQuery(query + id);
                }
                dtgv.DataSource = contractInfoList;

                MessageBox.Show("Dữ liệu đã được xóa.");
            }
        }

        private void btn_TaiXuong_Click(object sender, EventArgs e)
        {
            exportToExcell(true);
        }

        private void tb_ThongTinHopDong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

