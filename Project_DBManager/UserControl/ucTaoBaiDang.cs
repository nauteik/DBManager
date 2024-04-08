using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DBManager
{
    public partial class ucTaoBaiDang : UserControl
    {
        private List<PostInfo> postInfoList;
        private Account account;
        public Account Account { get => account; set => account = value; }

        public ucTaoBaiDang()
        {
            InitializeComponent();
            loadTenThuongHieu();
        }

        private void loadTenThuongHieu()
        {
            List<string> brandNameList = BrandDAO.Instance.getBrandNameList();
            List<string> sortedBrandNameList = brandNameList.OrderBy(x => x).ToList();
            foreach (string brandName in sortedBrandNameList)
            {
                cb_TenThuongHieu.Items.Add(brandName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_ThongTinHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TaoBaiDang_Click(object sender, EventArgs e)
        {
            if (tb_NoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ nội dung của bài đăng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tb_TrangThai.Text == "Active")
            {
                DialogResult result1 = MessageBox.Show("Thương hiệu này đã có bài đăng!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Retry) { return; }
            }
            DialogResult result = MessageBox.Show("Bạn có chắc tạo bài đăng này chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PostDAO.Instance.insertValueIntoPost(account.Id, cb_TenThuongHieu.SelectedItem.ToString(), tb_NoiDung.Text);
                MessageBox.Show("Tạo bài đăng thành công!");
                tb_NoiDung.Text = "";
            }
        }

        private void ucTaoBaiDang_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            DataRow dr = BrandDAO.Instance.getBrandInfoByBrandName(cb.SelectedItem.ToString());
            tb_SoDienThoai.Text = dr["Phone_Number"].ToString();
            tb_DiaChi.Text = dr["Address"].ToString();
            tb_Facebook.Text = dr["Facebook"].ToString();
            tb_TrangThai.Text = dr["Status"].ToString();
            tb_NoiDung.Text = "";
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tb_TrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
