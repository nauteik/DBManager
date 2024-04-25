﻿using System.Drawing;

namespace Project_DBManager
{
    partial class ucChinhSuaThongTinUuDai
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_ChinhSuaThongTinUuDai = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.tb_MoTaNgan = new System.Windows.Forms.TextBox();
            this.lbMoTaNgan = new System.Windows.Forms.Label();
            this.tb_SoDienThoai1 = new System.Windows.Forms.TextBox();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.lb_Facebook = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SoDienThoai2 = new System.Windows.Forms.Label();
            this.lb_SoDienThoai1 = new System.Windows.Forms.Label();
            this.tb_SoDienThoai2 = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_Facebook = new System.Windows.Forms.TextBox();
            this.tb_TenThuongHieu = new System.Windows.Forms.TextBox();
            this.tb_ThoiGianCapNhat = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.History_Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ChinhSuaThongTinUuDai
            // 
            this.tb_ChinhSuaThongTinUuDai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ChinhSuaThongTinUuDai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ChinhSuaThongTinUuDai.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChinhSuaThongTinUuDai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_ChinhSuaThongTinUuDai.Location = new System.Drawing.Point(3, 3);
            this.tb_ChinhSuaThongTinUuDai.Name = "tb_ChinhSuaThongTinUuDai";
            this.tb_ChinhSuaThongTinUuDai.ReadOnly = true;
            this.tb_ChinhSuaThongTinUuDai.Size = new System.Drawing.Size(337, 30);
            this.tb_ChinhSuaThongTinUuDai.TabIndex = 1;
            this.tb_ChinhSuaThongTinUuDai.Text = "Chỉnh Sửa Thông Tin Ưu Đãi";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.cb_TrangThai);
            this.panel2.Controls.Add(this.tb_MoTaNgan);
            this.panel2.Controls.Add(this.lbMoTaNgan);
            this.panel2.Controls.Add(this.tb_SoDienThoai1);
            this.panel2.Controls.Add(this.lb_TrangThai);
            this.panel2.Controls.Add(this.lb_Facebook);
            this.panel2.Controls.Add(this.lb_DiaChi);
            this.panel2.Controls.Add(this.lb_SoDienThoai2);
            this.panel2.Controls.Add(this.lb_SoDienThoai1);
            this.panel2.Controls.Add(this.tb_SoDienThoai2);
            this.panel2.Controls.Add(this.tb_DiaChi);
            this.panel2.Controls.Add(this.tb_Facebook);
            this.panel2.Location = new System.Drawing.Point(23, 103);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(496, 409);
            this.panel2.TabIndex = 7;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TrangThai.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Chưa tạo bài đăng",
            "Đã tạo bài đăng",
            "Đã đóng"});
            this.cb_TrangThai.Location = new System.Drawing.Point(153, 345);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(297, 27);
            this.cb_TrangThai.TabIndex = 34;
            // 
            // tb_MoTaNgan
            // 
            this.tb_MoTaNgan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MoTaNgan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MoTaNgan.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MoTaNgan.Location = new System.Drawing.Point(153, 251);
            this.tb_MoTaNgan.Multiline = true;
            this.tb_MoTaNgan.Name = "tb_MoTaNgan";
            this.tb_MoTaNgan.Size = new System.Drawing.Size(297, 69);
            this.tb_MoTaNgan.TabIndex = 33;
            // 
            // lbMoTaNgan
            // 
            this.lbMoTaNgan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMoTaNgan.AutoSize = true;
            this.lbMoTaNgan.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTaNgan.Location = new System.Drawing.Point(2, 250);
            this.lbMoTaNgan.Name = "lbMoTaNgan";
            this.lbMoTaNgan.Size = new System.Drawing.Size(105, 20);
            this.lbMoTaNgan.TabIndex = 32;
            this.lbMoTaNgan.Text = "Mô tả ngắn:";
            // 
            // tb_SoDienThoai1
            // 
            this.tb_SoDienThoai1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoDienThoai1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoDienThoai1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoDienThoai1.Location = new System.Drawing.Point(153, 13);
            this.tb_SoDienThoai1.Multiline = true;
            this.tb_SoDienThoai1.Name = "tb_SoDienThoai1";
            this.tb_SoDienThoai1.Size = new System.Drawing.Size(297, 30);
            this.tb_SoDienThoai1.TabIndex = 31;
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.Location = new System.Drawing.Point(2, 345);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(106, 23);
            this.lb_TrangThai.TabIndex = 30;
            this.lb_TrangThai.Text = "Trạng thái:";
            // 
            // lb_Facebook
            // 
            this.lb_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Facebook.AutoSize = true;
            this.lb_Facebook.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Facebook.Location = new System.Drawing.Point(2, 195);
            this.lb_Facebook.Name = "lb_Facebook";
            this.lb_Facebook.Size = new System.Drawing.Size(93, 20);
            this.lb_Facebook.TabIndex = 9;
            this.lb_Facebook.Text = "Facebook:";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(2, 134);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(68, 20);
            this.lb_DiaChi.TabIndex = 8;
            this.lb_DiaChi.Text = "Địa chỉ:";
            // 
            // lb_SoDienThoai2
            // 
            this.lb_SoDienThoai2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_SoDienThoai2.AutoSize = true;
            this.lb_SoDienThoai2.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoDienThoai2.Location = new System.Drawing.Point(2, 77);
            this.lb_SoDienThoai2.Name = "lb_SoDienThoai2";
            this.lb_SoDienThoai2.Size = new System.Drawing.Size(136, 20);
            this.lb_SoDienThoai2.TabIndex = 7;
            this.lb_SoDienThoai2.Text = "Số điện thoại 2:";
            // 
            // lb_SoDienThoai1
            // 
            this.lb_SoDienThoai1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_SoDienThoai1.AutoSize = true;
            this.lb_SoDienThoai1.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoDienThoai1.Location = new System.Drawing.Point(2, 22);
            this.lb_SoDienThoai1.Name = "lb_SoDienThoai1";
            this.lb_SoDienThoai1.Size = new System.Drawing.Size(134, 20);
            this.lb_SoDienThoai1.TabIndex = 6;
            this.lb_SoDienThoai1.Text = "Số điện thoại 1:";
            // 
            // tb_SoDienThoai2
            // 
            this.tb_SoDienThoai2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoDienThoai2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoDienThoai2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoDienThoai2.Location = new System.Drawing.Point(153, 68);
            this.tb_SoDienThoai2.Multiline = true;
            this.tb_SoDienThoai2.Name = "tb_SoDienThoai2";
            this.tb_SoDienThoai2.Size = new System.Drawing.Size(297, 30);
            this.tb_SoDienThoai2.TabIndex = 5;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DiaChi.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(153, 125);
            this.tb_DiaChi.Multiline = true;
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(297, 30);
            this.tb_DiaChi.TabIndex = 2;
            // 
            // tb_Facebook
            // 
            this.tb_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Facebook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Facebook.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Facebook.Location = new System.Drawing.Point(153, 186);
            this.tb_Facebook.Multiline = true;
            this.tb_Facebook.Name = "tb_Facebook";
            this.tb_Facebook.Size = new System.Drawing.Size(297, 30);
            this.tb_Facebook.TabIndex = 1;
            // 
            // tb_TenThuongHieu
            // 
            this.tb_TenThuongHieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_TenThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenThuongHieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_TenThuongHieu.Location = new System.Drawing.Point(33, 39);
            this.tb_TenThuongHieu.Name = "tb_TenThuongHieu";
            this.tb_TenThuongHieu.ReadOnly = true;
            this.tb_TenThuongHieu.Size = new System.Drawing.Size(337, 33);
            this.tb_TenThuongHieu.TabIndex = 8;
            this.tb_TenThuongHieu.Text = "[Tên thương hiệu]";
            // 
            // tb_ThoiGianCapNhat
            // 
            this.tb_ThoiGianCapNhat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ThoiGianCapNhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ThoiGianCapNhat.Font = new System.Drawing.Font("Inter Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThoiGianCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_ThoiGianCapNhat.Location = new System.Drawing.Point(33, 78);
            this.tb_ThoiGianCapNhat.Name = "tb_ThoiGianCapNhat";
            this.tb_ThoiGianCapNhat.ReadOnly = true;
            this.tb_ThoiGianCapNhat.Size = new System.Drawing.Size(337, 16);
            this.tb_ThoiGianCapNhat.TabIndex = 9;
            this.tb_ThoiGianCapNhat.Text = "[Thời gian thu thập - thời gian sửa đổi gần nhất]";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Location = new System.Drawing.Point(157, 528);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(112, 30);
            this.btn_Luu.TabIndex = 19;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeColumns = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.History_Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Medium Italic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv.Location = new System.Drawing.Point(538, 103);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv.Size = new System.Drawing.Size(258, 409);
            this.dtgv.TabIndex = 5;
            // 
            // History_Edit
            // 
            this.History_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.History_Edit.HeaderText = "Lịch sử chỉnh sửa";
            this.History_Edit.MinimumWidth = 6;
            this.History_Edit.Name = "History_Edit";
            this.History_Edit.ReadOnly = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(33, 528);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(112, 30);
            this.btn_Huy.TabIndex = 21;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // ucChinhSuaThongTinUuDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tb_ThoiGianCapNhat);
            this.Controls.Add(this.tb_TenThuongHieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_ChinhSuaThongTinUuDai);
            this.Name = "ucChinhSuaThongTinUuDai";
            this.Size = new System.Drawing.Size(796, 575);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ChinhSuaThongTinUuDai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.Label lb_Facebook;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SoDienThoai2;
        private System.Windows.Forms.Label lb_SoDienThoai1;
        private System.Windows.Forms.TextBox tb_SoDienThoai2;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_Facebook;
        private System.Windows.Forms.Label lbMoTaNgan;
        private System.Windows.Forms.TextBox tb_MoTaNgan;
        private System.Windows.Forms.TextBox tb_TenThuongHieu;
        private System.Windows.Forms.TextBox tb_ThoiGianCapNhat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox tb_SoDienThoai1;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn History_Edit;
        private System.Windows.Forms.Button btn_Huy;
    }
}
