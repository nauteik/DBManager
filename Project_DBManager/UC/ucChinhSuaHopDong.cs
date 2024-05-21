using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucChinhSuaHopDong : UserControl
    {
        private ContractInfo contractInfo;
        public ContractInfo ContractInfo { get => contractInfo; set => contractInfo = value; }

        public ucChinhSuaHopDong()
        {
            InitializeComponent();

        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            ucDanhSachHopDong parent = this.Parent as ucDanhSachHopDong;
            parent.loadData();
            this.Visible = false;
        }

        private void btn_Huy_VisibleChanged(object sender, EventArgs e)
        {
            if (contractInfo != null)
            {
                DataRow dr = BrandDAO.Instance.getTypeAndPhoneOfBrandByContractId(contractInfo.ContractID);
                tb_TenThuongHieu.Text = contractInfo.BrandName;
                cb_LoaiHinh.Text = dr["Type"].ToString();
                tb_SoDienThoaiDaiDien.Text = dr["Brand_Represent"].ToString();
                dtpk_NgayKy.Value = DateTime.ParseExact(contractInfo.SignedDate, "dd-MM-yyyy", null);
                dtpk_NgayKetThuc.Value = DateTime.ParseExact(contractInfo.Duration, "dd-MM-yyyy", null);
                tb_NoiDungHopDong.Text = contractInfo.Content;
            }
        }

        private void btn_ChinhSuaHopDong_Click(object sender, EventArgs e)
        {
            dtpk_NgayKetThuc_ValueChanged(sender, e);
            if (errorProvider1.GetError(dtpk_NgayKetThuc).IsNullOrEmpty() == false) return;
            if (tb_NoiDungHopDong.Text == "" || tb_TenThuongHieu.Text == "" || cb_LoaiHinh.Text == "")
            {
                MessageBox.Show("Thông tin hợp đồng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ContractDAO.Instance.updateContract(dtpk_NgayKetThuc.Value.ToString("yyyy-MM-dd"), tb_NoiDungHopDong.Text, contractInfo.ContractID);
                BrandDAO.Instance.updateTypeAndBrandRepresentAndBrandName(tb_TenThuongHieu.Text, cb_LoaiHinh.Text, tb_SoDienThoaiDaiDien.Text, BrandDAO.Instance.getBrandIdByContractId(contractInfo.ContractID));
                MessageBox.Show("Thông tin hợp đồng đã được chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
