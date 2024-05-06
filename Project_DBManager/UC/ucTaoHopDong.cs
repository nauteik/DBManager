using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
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
            if (tb_TenThuongHieu.Text == "" || tb_NoiDungHopDong.Text == "" || cb_LoaiHinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của hợp đồng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Tạo hợp đồng
                BrandDAO.Instance.createNewBrand(tb_TenThuongHieu.Text, cb_LoaiHinh.SelectedItem.ToString(), tb_SoDienThoaiDaiDien.Text);
                int newBrandId = -1;
                newBrandId = BrandDAO.Instance.getBrandIdDoNotHaveContract();
                if (newBrandId == -1)
                {
                    MessageBox.Show("Lỗi!");
                }
                else
                {
                    ContractDAO.Instance.createNewContract(dtpk_NgayKy.Value.ToString("yyyy-MM-dd"), dtpk_NgayKetThuc.Value.ToString("yyyy-MM-dd"), tb_NoiDungHopDong.Text, account.UserID.ToString(), newBrandId.ToString());
                    MessageBox.Show("Tạo hợp đồng mới thành công!");
                }
            }
        }

        private void btn_DatLai_Click(object sender, EventArgs e)
        {
            tb_TenThuongHieu.Text = "";
            tb_NoiDungHopDong.Text = "";
            tb_SoDienThoaiDaiDien.Text = "";
            cb_LoaiHinh.Text = "";
            dtpk_NgayKy.Value = DateTime.Now;
            dtpk_NgayKetThuc.Value = DateTime.Now;
        }
    }
}
