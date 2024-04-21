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
            ucChinhSuaThongTinUuDai1.Hide();
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
            dtgv.Columns["Post_ID"].Visible = false;
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
                sortedList = OfferInfoList.OrderBy(oi => oi.Content).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Chủ đề tăng dần")
            {
                sortedList = OfferInfoList.OrderByDescending(oi => oi.Content).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(oi => oi.Brand_Name).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(oi => oi.Brand_Name).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian thu thập tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(oi => oi.Upload_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian thu thập giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(oi => oi.Upload_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian cập nhật tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(oi => oi.LastChange_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Thời gian cập nhật giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(oi => oi.LastChange_Date).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái tăng dần")
            {
                sortedList = OfferInfoList.OrderBy(oi => oi.Status).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái giảm dần")
            {
                sortedList = OfferInfoList.OrderByDescending(oi => oi.Status).ToList();
                dtgv.DataSource = sortedList;
            }
        }

        private void ToExcel(DataGridView dtgv, string fileName, bool isSelectAll)
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
                        List<OfferInfo> list = new List<OfferInfo>();
                        foreach (OfferInfo oi in OfferInfoList)
                        {
                            if (oi.isChecked)
                            {
                                list.Add(oi);
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
                            MExcel.Cells[i + 2, j - 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    dtgv.DataSource = OfferInfoList;
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

        private void pictureBoxTaiXuong_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dtgv != null)
                {
                    ToExcel(dtgv, saveFileDialog1.FileName, true);
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
                foreach (OfferInfo oi in OfferInfoList)
                {
                    if (oi.isChecked)
                    {
                        postIDList.Add(oi.Post_ID);
                    }
                }
                OfferInfoList.RemoveAll(oi => oi.isChecked);
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
                    searchList = OfferInfoList.Where(oi => (oi.Brand_Name).Equals(value)).ToList();
                    dtgv.DataSource = searchList;
                }
                else
                {
                    searchList = OfferInfoList.Where(oi => (oi.Brand_Name.ToLower()).Contains(value.ToLower())).ToList();
                    dtgv.DataSource = searchList;
                }
                tbTimKiem.Text = "";
            }
        }

        private void buttonXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dtgv != null)
                {
                    ToExcel(dtgv, saveFileDialog1.FileName, false);
                }
                else
                {
                    MessageBox.Show("dtgv is null!!");
                }
            }
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            List<OfferInfo> fillterList;
            if (cb.SelectedItem.ToString() == "Trạng thái \"Chưa tạo bài đăng\"")
            {
                fillterList = OfferInfoList.Where(oi => (oi.Status).Equals("Chưa tạo bài đăng")).ToList();
                dtgv.DataSource = fillterList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái \"Đã tạo bài đăng\"")
            {
                fillterList = OfferInfoList.Where(oi => (oi.Status).Equals("Đã tạo bài đăng")).ToList();
                dtgv.DataSource = fillterList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái \"Đã đóng\"")
            {
                fillterList = OfferInfoList.Where(oi => (oi.Status).Equals("Đã đóng")).ToList();
                dtgv.DataSource = fillterList;
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái \"Chưa tạo\"")
            {
                fillterList = OfferInfoList;
                dtgv.DataSource = fillterList;
            }
        }
    }
}
