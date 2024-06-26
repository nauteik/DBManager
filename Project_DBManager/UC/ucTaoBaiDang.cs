﻿using Microsoft.IdentityModel.Tokens;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_DBManager.UC
{
    public partial class ucTaoBaiDang : UserControl
    {
        private Account account;

        public Account Account { get => account; set => account = value; }

        public ucTaoBaiDang()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_ThongTinHopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TaoBaiDang_Click(object sender, EventArgs e)
        {
            if (tb_TrangThai.Text == "Đã đóng")
            {
                DialogResult result1 = MessageBox.Show("Thương hiệu này đã đóng. Không thể tạo bài đăng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox4_TextChanged(sender, e);
            if (errorProvider1.GetError(lb_NoiDung).IsNullOrEmpty() == false) return;
            else if (tb_TrangThai.Text == "Đã tạo bài đăng")
            {
                DialogResult result1 = MessageBox.Show("Thương hiệu này đã tạo bài đăng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc tạo bài đăng này chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tb_TrangThai.Text == "Chưa tạo bài đăng")
                {
                    BrandDAO.Instance.updateBrandStatus(cb_TenThuongHieu.SelectedItem.ToString());
                    tb_TrangThai.Text = "Đã tạo bài đăng";
                }
                PostDAO.Instance.insertValueIntoPost(account.UserID, cb_TenThuongHieu.SelectedItem.ToString(), tb_NoiDung.Text);
                ActDAO.Instance.createAct(account.UserID, "Tạo bài đăng thương hiệu " + cb_TenThuongHieu.SelectedItem.ToString(), DateTime.Now);
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
            errorProvider1.SetError(lb_NoiDung, null);
            if (Service.Validator.Instance.validEmpty(tb_NoiDung.Text) != "")
            {
                errorProvider1.SetError(lb_NoiDung, Service.Validator.Instance.validEmpty(tb_NoiDung.Text));
            }
            else
            {
                errorProvider1.SetError(lb_NoiDung, null);
            }
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
            tb_Google.Text = dr["Google"].ToString();
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
