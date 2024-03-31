﻿using Project_DBManager.DTO;
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
    public partial class MainForm : Form
    {
        private Account account;
        public MainForm(Account loginAccount)
        {
            InitializeComponent();
            pnHeader.BringToFront();
            this.account = loginAccount;
            switch (account.Level)
            {
                case 1: lbPostion.Text = "Tổ trưởng"; break;
                case 2: lbPostion.Text = "Quản lý"; break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            thongTinHopDong1.Hide();
            taoBaiDang1.Hide();
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
            collapseMenu();
            if (pnQuanLyThongTin.Size == pnQuanLyThongTin.MinimumSize)
            {
                pnQuanLyThongTin.Size = pnQuanLyThongTin.MaximumSize;
                btnQuanLyThongTin.Image = Properties.Resources.arrow_down;
            }
            else
            {
                pnQuanLyThongTin.Size = pnQuanLyThongTin.MinimumSize;
                btnQuanLyThongTin.Image = Properties.Resources.arrow;
            }
           
        }

        private void btnTaoBaiDang_Click(object sender, EventArgs e)
        {
            collapseMenu();
            if (pnTaoBaiDang.Size == pnTaoBaiDang.MinimumSize)
            {
                pnTaoBaiDang.Size = pnTaoBaiDang.MaximumSize;
                btnTaoBaiDang.Image = Properties.Resources.arrow_down;
            }
            else
            {
                pnTaoBaiDang.Size = pnTaoBaiDang.MinimumSize;
                btnTaoBaiDang.Image = Properties.Resources.arrow;
            }
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            collapseMenu();
            if (pnQuanLyHopDong.Size == pnQuanLyHopDong.MinimumSize)
            {
                pnQuanLyHopDong.Size = pnQuanLyHopDong.MaximumSize;
                btnQuanLyHopDong.Image = Properties.Resources.arrow_down;
            }
            else
            {
                pnQuanLyHopDong.Size = pnQuanLyHopDong.MinimumSize;
                btnQuanLyHopDong.Image = Properties.Resources.arrow;
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            collapseMenu();
            if (pnQuanLyNhanVien.Size == pnQuanLyNhanVien.MinimumSize)
            {
                pnQuanLyNhanVien.Size = pnQuanLyNhanVien.MaximumSize;
                btnQuanLyNhanVien.Image = Properties.Resources.arrow_down;
            }
            else
            {
                pnQuanLyNhanVien.Size = pnQuanLyNhanVien.MinimumSize;
                btnQuanLyNhanVien.Image = Properties.Resources.arrow;
            }
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            collapseMenu();
            if (pnQuanLyTaiKhoan.Size == pnQuanLyTaiKhoan.MinimumSize)
            {
                pnQuanLyTaiKhoan.Size = pnQuanLyTaiKhoan.MaximumSize;
                btnQuanLyTaiKhoan.Image = Properties.Resources.arrow_down;
            }
            else
            {
                pnQuanLyTaiKhoan.Size = pnQuanLyTaiKhoan.MinimumSize;
                btnQuanLyTaiKhoan.Image = Properties.Resources.arrow;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnThongTinHopDong_Click(object sender, EventArgs e)
        {
            thongTinHopDong1.Show();
            thongTinHopDong1.BringToFront();
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
            taoBaiDang1.Show();
            taoBaiDang1.BringToFront();
        }
    }
}
