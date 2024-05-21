using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class ucChinhSuaThongTinUuDai : UserControl
    {
        private DataTable dt;
        private int brand_ID;
        private Account acc;
        private BrandInfo brandInfo;

        public Account Acc { get => acc; set => acc = value; }

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

        private void Load_LichSuChinhSua(int brandID, List<string> lst)
        {
            dtgv.Rows.Clear();
            foreach (string ele in lst)
            {
                if (found(ele)) { continue; }
                else { dtgv.Rows.Add(ele); }
            }
        }
        private void resetTrangThai()
        {
            cb_TrangThai.Items.Clear();
            cb_TrangThai.Items.Add("Chưa tạo bài đăng");
            cb_TrangThai.Items.Add("Đã tạo bài đăng");
            cb_TrangThai.Items.Add("Đã đóng");
        }
        public void loadInfo(BrandInfo brandInfo)
        {
            resetTrangThai();
            this.brandInfo = brandInfo;
            this.brand_ID = brandInfo.Brand_ID;
            tb_TenThuongHieu.Text = brandInfo.BrandName;
            tb_SoDienThoai1.Text = brandInfo.PhoneNumber;
            tb_Facebook.Text = brandInfo.Facebook;
            tb_MoTaNgan.Text = brandInfo.Introduction;
            tb_DiaChi.Text = brandInfo.Address;
            tb_Google.Text = brandInfo.Google;
            cb_TrangThai.Text = brandInfo.Status;
            if(brandInfo.Status == "Chưa tạo bài đăng")
            {
                cb_TrangThai.Items.Remove("Đã tạo bài đăng");
            }
            if(brandInfo.Status == "Đã tạo bài đăng" || brandInfo.Status == "Đã đóng")
            {
                cb_TrangThai.Items.Remove("Chưa tạo bài đăng");
            }
            Load_LichSuChinhSua(brandInfo.Brand_ID, DAO.HistoryDAO.Instance.loadHistory(brandInfo.Brand_ID));
        }
        public void setAccount(Account acconut)
        {
            this.acc = acconut;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tb_SoDienThoai1).IsNullOrEmpty() == false) { return; }
            string contentsChanged = "Thay đổi";
            bool check = false;
            if (tb_SoDienThoai1.Text != brandInfo.PhoneNumber) { contentsChanged += " số điện thoại,"; check = true; }
            if (tb_Facebook.Text != brandInfo.Facebook) { contentsChanged += " link facebook,"; check = true; }
            if (tb_MoTaNgan.Text != brandInfo.Introduction) { contentsChanged += " mô tả ngắn,"; check = true; }
            if (tb_DiaChi.Text != brandInfo.Address) { contentsChanged += " địa chỉ,"; check = true; }
            if (tb_Google.Text != brandInfo.Google) { contentsChanged += " địa chỉ,"; check = true; }
            if (cb_TrangThai.Text != brandInfo.Status) { contentsChanged += " trạng thái,"; check = true; }

            if (check) { contentsChanged = contentsChanged.Substring(0, contentsChanged.Length - 1); }

            string username = acc.Username;
            string userID = Convert.ToString(acc.UserID);

            HistoryEditBrandInfo his = new HistoryEditBrandInfo(userID, brand_ID, username, contentsChanged);

            DialogResult result = MessageBox.Show("Bạn có muốn lưu các thay đổi? ", "Lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DAO.BrandDAO.Instance.updateBrandDetails(brandInfo.Brand_ID, tb_SoDienThoai1.Text.ToString(),
                    tb_Facebook.Text.ToString(), tb_MoTaNgan.Text.ToString(), tb_DiaChi.Text.ToString(), cb_TrangThai.Text.ToString());
                brandInfo.PhoneNumber = tb_SoDienThoai1.Text;
                brandInfo.Facebook = tb_Facebook.Text;
                brandInfo.Introduction = tb_MoTaNgan.Text;
                brandInfo.Address = tb_DiaChi.Text;
                if (check)
                {
                    DAO.HistoryDAO.Instance.insertIntoHistory(his);
                    ActDAO.Instance.createAct(Convert.ToInt32(userID), "Chỉnh sửa thông tin thương hiệu " + brandInfo.BrandName, DateTime.Now);
                }
                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.brandInfo.Status = cb_TrangThai.Text;
            loadInfo(this.brandInfo);
            //Load_LichSuChinhSua(brandID, DAO.HistoryDAO.Instance.loadHistory(brandID));

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_SoDienThoai1_TextChanged(object sender, EventArgs e)
        {
            if (validPhone(tb_SoDienThoai1.Text) == false)
            {
                errorProvider1.SetError(tb_SoDienThoai1, "Số điện thoại không hợp lệ");
            }
            else
            {
                errorProvider1.SetError(tb_SoDienThoai1, null);
            }
        }
        private bool validPhone(string phone)
        {
            string pattern = @"^\d+$";
            if (phone.All(c => char.IsDigit(c) || c == ' '))
                return true;
            return false;
        }
    }
}
