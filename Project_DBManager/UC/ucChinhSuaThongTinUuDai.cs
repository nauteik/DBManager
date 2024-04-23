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
    public partial class ucChinhSuaThongTinUuDai : UserControl
    {
        private DataTable dt;
        public ucChinhSuaThongTinUuDai()
        {
            InitializeComponent();
            
        }

        public void loadInfo(OfferInfo oi)
        {
            tb_TenThuongHieu.Text = oi.Brand_Name;
            tb_ThoiGianCapNhat.Text = DAO.PostDAO.Instance.getUploadDate(oi.Post_ID).ToString() + " - " +
                DAO.PostDAO.Instance.getUploadDate(oi.Post_ID).ToString();
            this.dt = DAO.BrandDAO.Instance.getBrandDetails(oi.Post_ID);
            tb_SoDienThoai1.Text = dt.Rows[0]["Phone_Number"].ToString();
            tb_Facebook.Text = dt.Rows[0]["Facebook"].ToString();
            tb_MoTaNgan.Text = dt.Rows[0]["Introduction"].ToString();
            tb_DiaChi.Text = dt.Rows[0]["Address"].ToString();
            cb_TrangThai.Text = dt.Rows[0]["Status"].ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.Rows[0]["Brand_ID"].ToString());
            DAO.BrandDAO.Instance.updateBrandDetails(dt.Rows[0]["Brand_ID"].ToString(), tb_SoDienThoai1.Text.ToString(),
                tb_Facebook.Text.ToString(), tb_MoTaNgan.Text.ToString(), tb_DiaChi.Text.ToString(), cb_TrangThai.Text.ToString());
        }
    }
}
