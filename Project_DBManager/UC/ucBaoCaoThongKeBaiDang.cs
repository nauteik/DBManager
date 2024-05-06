using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucBaoCaoThongKeBaiDang : UserControl
    {
        public ucBaoCaoThongKeBaiDang()
        {
            InitializeComponent();
        }

        private void tb_TaoBaiDang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã điền đủ thông tin hay chưa
            if (cb_ThongKeTheo.Text == "" || cb_Chon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Reset date trong chart
            c_BaiDang.ResetAutoValues();
            // Thực hiện thống kê
            c_BaiDang.Visible = true;
            c_BaiDang.Titles.Add("");
            c_BaiDang.ChartAreas[0].AxisX.Title = "Ngày";
            c_BaiDang.ChartAreas[0].AxisY.Title = "Số lượng bài đăng";
            c_BaiDang.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_BaiDang.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_BaiDang.Series["Số lượng bài đăng"].Points.Clear();
            DateTime startDate = dtpk_NgayBatDau.Value;
            DateTime endDate = dtpk_NgayKetThuc.Value;
            if (cb_ThongKeTheo.SelectedItem.ToString() == "Thương hiệu")
            {
                foreach (DateTime date in PostDAO.Instance.getUploadDateByBrandName(cb_Chon.SelectedItem.ToString(), startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd")))
                {
                    c_BaiDang.Titles[0].Text = "Thống kê bài đăng theo thương hiệu";
                    c_BaiDang.Series["Số lượng bài đăng"].Points.AddXY(date.ToString("dd-MM-yyyy"), PostDAO.Instance.postPerDayByBrandName(cb_Chon.SelectedItem.ToString(), date.ToString("yyyy-MM-dd")));
                }
            }
            else if (cb_ThongKeTheo.SelectedItem.ToString() == "Người tạo")
            {
                foreach (DateTime date in PostDAO.Instance.getUploadDateByName(cb_Chon.SelectedItem.ToString(), startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd")))
                {
                    c_BaiDang.Titles[0].Text = "Thống kê bài đăng theo người tạo";
                    c_BaiDang.Series["Số lượng bài đăng"].Points.AddXY(date.ToString("dd-MM-yyyy"), PostDAO.Instance.postPerDayByName(cb_Chon.SelectedItem.ToString(), date.ToString("yyyy-MM-dd")));
                }
            }
            else if (cb_ThongKeTheo.SelectedItem.ToString() == "Chủ đề")
            {
                foreach (DateTime date in PostDAO.Instance.getUploadDateByType(cb_Chon.SelectedItem.ToString(), startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd")))
                {
                    c_BaiDang.Titles[0].Text = "Thống kê bài đăng theo chủ đề";
                    c_BaiDang.Series["Số lượng bài đăng"].Points.AddXY(date.ToString("dd-MM-yyyy"), PostDAO.Instance.postPerDayByType(cb_Chon.SelectedItem.ToString(), date.ToString("yyyy-MM-dd")));
                }
            }
        }

        private void btn_XuatDuLieu_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ucBaoCaoThongKeBaiDang_Load(object sender, EventArgs e)
        {
            c_BaiDang.Visible = false;
            lb_Chon.Visible = false;
            cb_Chon.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbb_ThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Chon.Visible = true;
            cb_Chon.Visible = true;
            cb_Chon.Text = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem.ToString() == "Thương hiệu")
            {
                cb_Chon.Items.Clear();
                lb_Chon.Text = "Chọn thương hiệu";
                List<string> brandNameList = PostDAO.Instance.getBrandNameList();
                foreach (string brandName in brandNameList)
                {
                    cb_Chon.Items.Add(brandName);
                }
            }
            else if (cb.SelectedItem.ToString() == "Người tạo")
            {
                cb_Chon.Items.Clear();
                lb_Chon.Text = "Chọn người tạo";
                List<string> nameList = AccountDAO.Instance.getNameList();
                foreach (string name in nameList)
                {
                    cb_Chon.Items.Add(name);
                }
            }
            else if (cb.SelectedItem.ToString() == "Chủ đề")
            {
                cb_Chon.Items.Clear();
                lb_Chon.Text = "Chọn chủ đề";
                List<string> typeList = BrandDAO.Instance.getTypeList();
                foreach (string type in typeList)
                {
                    cb_Chon.Items.Add(type);
                }
            }
        }

        private void c_BaiDang_Click(object sender, EventArgs e)
        {

        }
    }
}
