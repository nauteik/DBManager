using Project_DBManager.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class MainForm : Form
    {
        private Account account;
        public MainForm(Account account)
        {
            this.account = account;
            InitializeComponent();
            collapseUserControl();
            pnHeader.BringToFront();
            switch (account.Level)
            {
                case 1: lbPostion.Text = "Tổ trưởng"; break;
                case 2: lbPostion.Text = "Quản lý"; break;
            }
        }
        private void collapseUserControl()
        {
            ucDanhSachNhanVien1.Hide();
            ucthongTinUuDai1.Hide();
            ucThongTinCaNhan1.Hide();
            ucDanhSachHopDong1.Hide();
            ucTaoBaiDang1.Hide();
            ucVoHieuHoaKhoiPhuc1.Hide();
            ucDanhSachBaiDang1.Hide();
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void collapseMenu()
        {
            pnQuanLyThongTin.Size = pnQuanLyThongTin.MinimumSize;
            btnQuanLyThongTin.Image = Properties.Resources.arrow;
            pnTaoBaiDang.Size = pnTaoBaiDang.MinimumSize;
            btnTaoBaiDang.Image = Properties.Resources.arrow;
            pnQuanLyHopDong.Size = pnQuanLyHopDong.MinimumSize;
            btnQuanLyHopDong.Image = Properties.Resources.arrow;
            pnQuanLyNhanVien.Size = pnQuanLyNhanVien.MinimumSize;
            btnQuanLyNhanVien.Image = Properties.Resources.arrow;
            pnQuanLyTaiKhoan.Size = pnQuanLyTaiKhoan.MinimumSize;
            btnQuanLyTaiKhoan.Image = Properties.Resources.arrow;
        }
        private void btnQuanLyThongTin_Click(object sender, EventArgs e)
        {

            if (pnQuanLyThongTin.Size == pnQuanLyThongTin.MaximumSize)
            {
                pnQuanLyThongTin.Size = pnQuanLyThongTin.MinimumSize;
                btnQuanLyThongTin.Image = Properties.Resources.arrow;
                return;
            }
            collapseMenu();

            pnQuanLyThongTin.Size = pnQuanLyThongTin.MaximumSize;
            btnQuanLyThongTin.Image = Properties.Resources.arrow_down;
        }

        private void btnTaoBaiDang_Click(object sender, EventArgs e)
        {
            if(pnTaoBaiDang.Size == pnTaoBaiDang.MaximumSize)
            {
                pnTaoBaiDang.Size = pnTaoBaiDang.MinimumSize;
                btnTaoBaiDang.Image = Properties.Resources.arrow;
                return;
            }
            collapseMenu();
            pnTaoBaiDang.Size = pnTaoBaiDang.MaximumSize;
            btnTaoBaiDang.Image = Properties.Resources.arrow_down;
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            if (pnQuanLyHopDong.Size == pnQuanLyHopDong.MaximumSize)
            {
                pnQuanLyHopDong.Size = pnQuanLyHopDong.MinimumSize;
                btnQuanLyHopDong.Image = Properties.Resources.arrow;
                return;
            }
            collapseMenu();
            pnQuanLyHopDong.Size = pnQuanLyHopDong.MaximumSize;
            btnQuanLyHopDong.Image = Properties.Resources.arrow_down;
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (pnQuanLyNhanVien.Size == pnQuanLyNhanVien.MaximumSize)
            {
                pnQuanLyNhanVien.Size = pnQuanLyNhanVien.MinimumSize;
                btnQuanLyNhanVien.Image = Properties.Resources.arrow;
                return;
            }
            collapseMenu();
            pnQuanLyNhanVien.Size = pnQuanLyNhanVien.MaximumSize;
            btnQuanLyNhanVien.Image = Properties.Resources.arrow_down;
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (pnQuanLyTaiKhoan.Size == pnQuanLyTaiKhoan.MaximumSize)
            {
                pnQuanLyTaiKhoan.Size = pnQuanLyTaiKhoan.MinimumSize;
                btnQuanLyTaiKhoan.Image = Properties.Resources.arrow;
                return;
            }
            collapseMenu();
            pnQuanLyTaiKhoan.Size = pnQuanLyTaiKhoan.MaximumSize;
            btnQuanLyTaiKhoan.Image = Properties.Resources.arrow_down;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnThongTinHopDong_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucDanhSachHopDong1.Account = account;
            ucDanhSachHopDong1.Show();
        }

        private void thongTinHopDong2_Load(object sender, EventArgs e)
        {

        }

        private void thongTinHopDong1_Load(object sender, EventArgs e)
        {

        }

        private void thongTinHopDong1_Load_1(object sender, EventArgs e)
        {

        }

        private void taoBaiDang1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTaoBaiDangMoi_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucTaoBaiDang1.Account = account;
            ucTaoBaiDang1.Show();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            
            collapseUserControl();
            changeColorChooseButton(this.btnThongTinCaNhan);
            ucThongTinCaNhan1.loadAccount(account.Username);
            ucThongTinCaNhan1.Show();
        }
        private void changeColorChooseButton(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#868ba6");
        }
        private void btnTruyCapTaiNguyen_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            this.ucthongTinUuDai1.Show();
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucDanhSachNhanVien1.loadStaff(account);
            this.ucDanhSachNhanVien1.Show();
        }

        private void btnVoHieuHoaKhoiPhuc_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucVoHieuHoaKhoiPhuc1.loadStaff(account);
            ucVoHieuHoaKhoiPhuc1.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        private void btnChinhSuaBaiDang_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucDanhSachBaiDang1.loadBaiDang();
            ucDanhSachBaiDang1.Account = account;
            ucDanhSachBaiDang1.Show();
        }
    }
}
