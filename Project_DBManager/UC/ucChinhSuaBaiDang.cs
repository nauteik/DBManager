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
    public partial class ucChinhSuaBaiDang : UserControl
    {
        private PostInfoToShow postInfoToShow = null;
        public PostInfoToShow PostInfoToShow { get => postInfoToShow; set => postInfoToShow = value; }

        public ucChinhSuaBaiDang()
        {
            InitializeComponent();
        }

        private void tb_TaoBaiDang_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ucChinhSuaBaiDang_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ChinhSuaBaiDang_Click(object sender, EventArgs e)
        {
            if (tb_NoiDung.Text == "")
            {
                MessageBox.Show("Nội dụng bài đăng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PostDAO.Instance.updatePostContentById(postInfoToShow.PostId, tb_NoiDung.Text);
                MessageBox.Show("Nội dụng bài đăng đã được chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ucChinhSuaBaiDang_VisibleChanged(object sender, EventArgs e)
        {
            if (postInfoToShow != null)
            {
                DataRow dr = BrandDAO.Instance.getBrandInfoByBrandName(postInfoToShow.BrandName);
                tb_TenThuongHieu.Text = postInfoToShow.BrandName;
                tb_SoDienThoai.Text = dr["Phone_Number"].ToString();
                tb_DiaChi.Text = dr["Address"].ToString();
                tb_Facebook.Text = dr["Facebook"].ToString();
                tb_TrangThai.Text = dr["Status"].ToString();
                tb_NoiDung.Text = postInfoToShow.Content;
            }  
        }
    }
}
