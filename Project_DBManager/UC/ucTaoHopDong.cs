using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using Project_DBManager.Service;
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
            dtpk_NgayKetThuc_ValueChanged(sender, e);
            tb_NoiDungHopDong_TextChanged(sender, e);
            if (errorProvider1.GetError(dtpk_NgayKetThuc).IsNullOrEmpty() == false) return;
            if (errorProvider1.GetError(lb_NoiDungHopDong).IsNullOrEmpty() == false) return;
            int brandID = BrandDAO.Instance.getBrandIdByBrandName(cb_TenThuongHieu.Text);
            bool succeed = ContractDAO.Instance.createNewContract(dtpk_NgayKy.Value.ToString("yyyy-MM-dd"), dtpk_NgayKetThuc.Value.ToString("yyyy-MM-dd"), tb_NoiDungHopDong.Text, account.UserID.ToString(), brandID);
            if (succeed)
            {
                MessageBox.Show("Tạo hợp đồng mới thành công!");
                ActDAO.Instance.createAct(account.UserID, "Tạo hợp đồng thương hiệu " + BrandDAO.Instance.getBrandNameByID(brandID), DateTime.Now);
            }
            else
            {
                MessageBox.Show("Tạo không thành công");
            }
        }

        private void btn_DatLai_Click(object sender, EventArgs e)
        {
            tb_NoiDungHopDong.Text = "";
            dtpk_NgayKy.Value = DateTime.Now;
            dtpk_NgayKetThuc.Value = DateTime.Now.AddDays(1);
        }

        private void dtpk_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (Service.Validator.Instance.validFutureDate(dtpk_NgayKetThuc.Value) != "")
            {
                errorProvider1.SetError(dtpk_NgayKetThuc, Service.Validator.Instance.validFutureDate(dtpk_NgayKetThuc.Value));
            }
            else
            {
                errorProvider1.SetError(dtpk_NgayKetThuc, null);
            }
        }

        private void tb_NoiDungHopDong_TextChanged(object sender, EventArgs e)
        {
            if(Validator.Instance.validEmpty(tb_NoiDungHopDong.Text) != "")
            {
                errorProvider1.SetError(lb_NoiDungHopDong, Validator.Instance.validEmpty(tb_NoiDungHopDong.Text));
            }
            else
            {
                errorProvider1.SetError(lb_NoiDungHopDong, null);
            }
        }
    }
}
