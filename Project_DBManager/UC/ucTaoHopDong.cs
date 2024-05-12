using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucTaoHopDong : UserControl
    {
        private Account account;
        public Account Account { get => account; set => account = value; }

        public ucTaoHopDong()
        {
            InitializeComponent();
            loadTenThuongHieu();
        }
        public void loadTenThuongHieu()
        {
            cb_TenThuongHieu.Items.Clear();
            List<string> brandNameList = BrandDAO.Instance.getBrandNameList();
            List<string> sortedBrandNameList = brandNameList.OrderBy(x => x).ToList();
            foreach (string brandName in sortedBrandNameList)
            {
                cb_TenThuongHieu.Items.Add(brandName);
            }
        }

        private void lb_DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void cb_LoaiHinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucTaoHopDong_Load(object sender, EventArgs e)
        {
            dtpk_NgayKy.Value = DateTime.Now;
        }

        private void btn_TaoHopDong_Click(object sender, EventArgs e)
        {
            // Kiểm tra input để tạo hợp đồng
            if (tb_NoiDungHopDong.Text == "" || cb_TenThuongHieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của hợp đồng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int brandID = BrandDAO.Instance.getBrandIdByBrandName(cb_TenThuongHieu.Text);
                bool succeed = ContractDAO.Instance.createNewContract(dtpk_NgayKy.Value.ToString("yyyy-MM-dd"), dtpk_NgayKetThuc.Value.ToString("yyyy-MM-dd"), tb_NoiDungHopDong.Text, account.UserID.ToString(), brandID);
                if (succeed)
                {
                    MessageBox.Show("Tạo hợp đồng mới thành công!");
                }
                else
                {
                    MessageBox.Show("Tạo không thành công");
                }
                
            }
        }

        private void btn_DatLai_Click(object sender, EventArgs e)
        {
            tb_NoiDungHopDong.Text = "";
            tb_SoDienThoaiDaiDien.Text = "";
            dtpk_NgayKy.Value = DateTime.Now;
            dtpk_NgayKetThuc.Value = DateTime.Now;
        }
    }
}
