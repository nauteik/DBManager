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
    public partial class ucDanhSachBaiDang : UserControl
    {
        private List<PostInfoToShow> postInfoToShowList;
        public Account account;
        public Account Account { get => account; set => account = value; }

        public ucDanhSachBaiDang()
        {
            InitializeComponent();
        }

        public void loadBaiDang()
        {
            postInfoToShowList = PostDAO.Instance.getPostInfoToShow();
            dtgv_DanhSachBaiDang.DataSource = postInfoToShowList;
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
                if (dtgv_DanhSachBaiDang.Rows.Count > 0)
                {
                    if (!isSelectAll)
                    {
                        List<PostInfoToShow> list = new List<PostInfoToShow>();
                        foreach (PostInfoToShow pi in postInfoToShowList)
                        {
                            if (pi.IsChecked)
                            {
                                list.Add(pi);
                            }
                        }
                        dtgv_DanhSachBaiDang.DataSource = list;
                    }
                    Microsoft.Office.Interop.Excel.Application MExcel = new Microsoft.Office.Interop.Excel.Application();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 2; i < dtgv_DanhSachBaiDang.Columns.Count; i++)
                    {
                        MExcel.Cells[1, i - 1] = dtgv_DanhSachBaiDang.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dtgv_DanhSachBaiDang.Rows.Count; i++)
                    {
                        for (int j = 2; j < dtgv_DanhSachBaiDang.Columns.Count; j++)
                        {
                            //if (j == 4)
                            //{
                            //    DateTime dt = dtgv_DanhSachBaiDang.Rows[i].Cells[j].Value;
                            //    MExcel.Cells[i + 2, j - 1] = dt.ToString("dd-MM-yyyy");
                            //}
                            //else
                            //{
                            MExcel.Cells[i + 2, j - 1] = dtgv_DanhSachBaiDang.Rows[i].Cells[j].Value.ToString();
                            //}
                        }
                    }
                    dtgv_DanhSachBaiDang.DataSource = postInfoToShowList;
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

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TaiXuong_Click(object sender, EventArgs e)
        {
            exportToExcell(true);
        }

        private void dtgv_DanhSachBaiDang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DanhSachBaiDang.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (account.Level >= AccountDAO.Instance.getLevelByName(dtgv_DanhSachBaiDang.Rows[e.RowIndex].Cells[6].Value.ToString()))
                {
                    string tempPostId = dtgv_DanhSachBaiDang.Rows[e.RowIndex].Cells[2].Value.ToString();
                    PostInfoToShow postInfoToShow = postInfoToShowList.Find(pits => pits.PostId == tempPostId);
                    ucChinhSuaBaiDang1.PostInfoToShow = postInfoToShow;
                    ucChinhSuaBaiDang1.Show();
                }
                else
                {
                    MessageBox.Show("Bạn cần quyền truy cập để chỉnh sửa bài đăng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_XuatDuLieu_Click(object sender, EventArgs e)
        {
            exportToExcell(false);
        }

        private void btn_XoaDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa các dòng dữ liệu đã được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> postIDList = new List<string>();
                List<PostInfoToShow> tempList = new List<PostInfoToShow>();
                dtgv_DanhSachBaiDang.DataSource = tempList;
                foreach (PostInfoToShow pi in postInfoToShowList)
                {
                    if (pi.IsChecked)
                    {
                        if (account.Level >= PostDAO.Instance.getUserLevelCreatePost(pi.PostId))
                        {
                            postIDList.Add(pi.PostId);
                        }
                        else
                        {
                            MessageBox.Show("Bạn không được phép xóa dữ liệu này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgv_DanhSachBaiDang.DataSource = postInfoToShowList;
                            return;
                        }
                    }
                }
                postInfoToShowList.RemoveAll(pi => pi.IsChecked);
                foreach (string id in postIDList)
                {
                    PostDAO.Instance.deletePostById(Convert.ToInt32(id));
                }
                dtgv_DanhSachBaiDang.DataSource = postInfoToShowList;
                MessageBox.Show("Dữ liệu đã được xóa.");
            }
        }

        private void cb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            List<PostInfoToShow> sortedList;
            if (cb.SelectedItem.ToString() == "ID tăng dần")
            {
                sortedList = postInfoToShowList.OrderBy(pi => pi.PostId).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "ID giảm dần")
            {
                sortedList = postInfoToShowList.OrderByDescending(pi => pi.PostId).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                sortedList = postInfoToShowList.OrderBy(pi => pi.BrandName).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                sortedList = postInfoToShowList.OrderByDescending(pi => pi.BrandName).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày tạo tăng dần")
            {
                sortedList = postInfoToShowList.OrderBy(pi => pi.UploadDate).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày tạo giảm dần")
            {
                sortedList = postInfoToShowList.OrderByDescending(pi => pi.UploadDate).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Người tạo tăng dần")
            {
                sortedList = postInfoToShowList.OrderBy(pi => pi.Name).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Người tạo giảm dần")
            {
                sortedList = postInfoToShowList.OrderByDescending(pi => pi.Name).ToList();
                dtgv_DanhSachBaiDang.DataSource = sortedList;
            }
        }

        private void ucDanhSachBaiDang_Load(object sender, EventArgs e)
        {

        }

        private void dtgv_DanhSachBaiDang_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgv_DanhSachBaiDang_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DanhSachBaiDang.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv_DanhSachBaiDang.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
            }
        }

        private void dtgv_DanhSachBaiDang_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DanhSachBaiDang.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                dtgv_DanhSachBaiDang.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void ucChinhSuaBaiDang1_Load(object sender, EventArgs e)
        {
            ucChinhSuaBaiDang1.Hide();
        }

        private void tb_TimKiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<PostInfoToShow> searchList;
                string value = tb_TimKiem.Text;
                if (int.TryParse(value, out _))
                {
                    searchList = postInfoToShowList.Where(pits => (pits.PostId).Equals(value)).ToList();
                    dtgv_DanhSachBaiDang.DataSource = searchList;
                }
                else
                {
                    searchList = postInfoToShowList.Where(pits => (pits.BrandName.ToLower()).Contains(value.ToLower()) || (pits.Type.ToLower()).Contains(value.ToLower()) || (pits.Name.ToLower()).Contains(value.ToLower())).ToList();
                    dtgv_DanhSachBaiDang.DataSource = searchList;
                }
                tb_TimKiem.Text = "";
            }
        }
    }
}
