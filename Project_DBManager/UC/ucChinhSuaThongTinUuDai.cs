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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DBManager
{
    public partial class ucChinhSuaThongTinUuDai : UserControl
    {
        private DataTable dt;
        private string postID;
        public ucChinhSuaThongTinUuDai()
        {
            InitializeComponent();
            
        }

        private bool found(string ele)
        {
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                string cellValue = row.Cells[0].Value.ToString();
                if (cellValue.Equals(ele))
                {
                    return true;
                }
            }
            return false;
        }

        private void Load_LichSuChinhSua(string brandID, List<string> lst)
        {
            foreach (string ele in lst)
            {
                if(found(ele)) { continue; }
                else { dtgv.Rows.Add(ele); }
            }
        }

        public void loadInfo(OfferInfo oi)
        {
            this.postID = oi.Post_ID;
            tb_TenThuongHieu.Text = oi.Brand_Name;
            tb_ThoiGianCapNhat.Text = DAO.PostDAO.Instance.getUploadDate(oi.Post_ID).ToString() + " - " +
                DAO.PostDAO.Instance.getLastChangedDate(oi.Post_ID).ToString();
            this.dt = DAO.BrandDAO.Instance.getBrandDetails(oi.Post_ID);
            tb_SoDienThoai1.Text = dt.Rows[0]["Phone_Number"].ToString();
            tb_Facebook.Text = dt.Rows[0]["Facebook"].ToString();
            tb_MoTaNgan.Text = dt.Rows[0]["Introduction"].ToString();
            tb_DiaChi.Text = dt.Rows[0]["Address"].ToString();
            cb_TrangThai.Text = dt.Rows[0]["Status"].ToString();

            string brandID = DAO.BrandDAO.Instance.getBrandIdByPostId(this.postID);
            Load_LichSuChinhSua(brandID, DAO.HistoryDAO.Instance.loadHistory(brandID));
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string contentsChanged = "Thay đổi ";
            bool check = false;
            if (tb_SoDienThoai1.Text != dt.Rows[0]["Phone_Number"].ToString()) { contentsChanged += "số điện thoại, "; check = true; }
            if (tb_Facebook.Text != dt.Rows[0]["Facebook"].ToString()) { contentsChanged += "link facebook, "; check = true; }
            if (tb_MoTaNgan.Text != dt.Rows[0]["Introduction"].ToString()) { contentsChanged += "mô tả ngắn, "; check = true; }
            if (tb_DiaChi.Text != dt.Rows[0]["Address"].ToString()) { contentsChanged += "địa chỉ, "; check = true; }
            if (cb_TrangThai.Text != dt.Rows[0]["Status"].ToString()) { contentsChanged += "trạng thái."; check = true; }

            if (check && contentsChanged[contentsChanged.Length - 1].Equals(" ")) { contentsChanged = contentsChanged.Substring(0, contentsChanged.Length - 2) + "."; }
            
            string username = DAO.AccountDAO.Instance.getUserNameOfAccountLogin();
            string userID = DAO.AccountDAO.Instance.getAccountByUsername(username).Id.ToString();
            string brandID = DAO.BrandDAO.Instance.getBrandIdByPostId(this.postID);
            
            HistoryEditBrandInfo his = new HistoryEditBrandInfo(userID, brandID, username, contentsChanged);

            DialogResult result = MessageBox.Show("Bạn có muốn lưu các thay đổi? ", "Lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DAO.BrandDAO.Instance.updateBrandDetails(dt.Rows[0]["Brand_ID"].ToString(), tb_SoDienThoai1.Text.ToString(),
                    tb_Facebook.Text.ToString(), tb_MoTaNgan.Text.ToString(), tb_DiaChi.Text.ToString(), cb_TrangThai.Text.ToString());
                if(check)
                {
                    DAO.HistoryDAO.Instance.insertIntoHistory(his);
                }
                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Load_LichSuChinhSua(brandID, DAO.HistoryDAO.Instance.loadHistory(brandID));
            
        }


    }
}
