﻿namespace Project_DBManager.UC
{
    partial class ucTaoHopDong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_TaoHopDong = new System.Windows.Forms.TextBox();
            this.btn_TaoHopDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_NgayKetThuc = new System.Windows.Forms.Label();
            this.lb_LoaiHinh = new System.Windows.Forms.Label();
            this.lb_SoDienThoaiDaiDien = new System.Windows.Forms.Label();
            this.lb_TenThuongHieu = new System.Windows.Forms.Label();
            this.tb_TenThuongHieu = new System.Windows.Forms.TextBox();
            this.tb_SoDienThoaiDaiDien = new System.Windows.Forms.TextBox();
            this.lb_NoiDungHopDong = new System.Windows.Forms.Label();
            this.tb_NoiDungHopDong = new System.Windows.Forms.TextBox();
            this.cb_LoaiHinh = new System.Windows.Forms.ComboBox();
            this.lb_NgayKy = new System.Windows.Forms.Label();
            this.dtpk_NgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtpk_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btn_DatLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_TaoHopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 2;
            // 
            // tb_TaoHopDong
            // 
            this.tb_TaoHopDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_TaoHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_TaoHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TaoHopDong.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaoHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_TaoHopDong.Location = new System.Drawing.Point(25, 12);
            this.tb_TaoHopDong.Name = "tb_TaoHopDong";
            this.tb_TaoHopDong.ReadOnly = true;
            this.tb_TaoHopDong.Size = new System.Drawing.Size(196, 33);
            this.tb_TaoHopDong.TabIndex = 0;
            this.tb_TaoHopDong.Text = "Tạo Hợp Đồng";
            // 
            // btn_TaoHopDong
            // 
            this.btn_TaoHopDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TaoHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoHopDong.FlatAppearance.BorderSize = 0;
            this.btn_TaoHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHopDong.Location = new System.Drawing.Point(25, 525);
            this.btn_TaoHopDong.Name = "btn_TaoHopDong";
            this.btn_TaoHopDong.Size = new System.Drawing.Size(150, 30);
            this.btn_TaoHopDong.TabIndex = 4;
            this.btn_TaoHopDong.Text = "Tạo hợp đồng";
            this.btn_TaoHopDong.UseVisualStyleBackColor = false;
            this.btn_TaoHopDong.Click += new System.EventHandler(this.btn_TaoHopDong_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.dtpk_NgayKetThuc);
            this.panel2.Controls.Add(this.dtpk_NgayKy);
            this.panel2.Controls.Add(this.lb_NgayKy);
            this.panel2.Controls.Add(this.cb_LoaiHinh);
            this.panel2.Controls.Add(this.tb_TenThuongHieu);
            this.panel2.Controls.Add(this.lb_NoiDungHopDong);
            this.panel2.Controls.Add(this.lb_NgayKetThuc);
            this.panel2.Controls.Add(this.lb_LoaiHinh);
            this.panel2.Controls.Add(this.lb_SoDienThoaiDaiDien);
            this.panel2.Controls.Add(this.lb_TenThuongHieu);
            this.panel2.Controls.Add(this.tb_SoDienThoaiDaiDien);
            this.panel2.Controls.Add(this.tb_NoiDungHopDong);
            this.panel2.Location = new System.Drawing.Point(25, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(750, 450);
            this.panel2.TabIndex = 5;
            // 
            // lb_NgayKetThuc
            // 
            this.lb_NgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_NgayKetThuc.AutoSize = true;
            this.lb_NgayKetThuc.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayKetThuc.Location = new System.Drawing.Point(20, 364);
            this.lb_NgayKetThuc.Name = "lb_NgayKetThuc";
            this.lb_NgayKetThuc.Size = new System.Drawing.Size(141, 23);
            this.lb_NgayKetThuc.TabIndex = 9;
            this.lb_NgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // lb_LoaiHinh
            // 
            this.lb_LoaiHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_LoaiHinh.AutoSize = true;
            this.lb_LoaiHinh.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiHinh.Location = new System.Drawing.Point(20, 112);
            this.lb_LoaiHinh.Name = "lb_LoaiHinh";
            this.lb_LoaiHinh.Size = new System.Drawing.Size(96, 23);
            this.lb_LoaiHinh.TabIndex = 8;
            this.lb_LoaiHinh.Text = "Loại hình:";
            this.lb_LoaiHinh.Click += new System.EventHandler(this.lb_DiaChi_Click);
            // 
            // lb_SoDienThoaiDaiDien
            // 
            this.lb_SoDienThoaiDaiDien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_SoDienThoaiDaiDien.AutoSize = true;
            this.lb_SoDienThoaiDaiDien.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoDienThoaiDaiDien.Location = new System.Drawing.Point(20, 197);
            this.lb_SoDienThoaiDaiDien.Name = "lb_SoDienThoaiDaiDien";
            this.lb_SoDienThoaiDaiDien.Size = new System.Drawing.Size(210, 23);
            this.lb_SoDienThoaiDaiDien.TabIndex = 7;
            this.lb_SoDienThoaiDaiDien.Text = "Số điện thoại đại diện:";
            // 
            // lb_TenThuongHieu
            // 
            this.lb_TenThuongHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_TenThuongHieu.AutoSize = true;
            this.lb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuongHieu.Location = new System.Drawing.Point(20, 25);
            this.lb_TenThuongHieu.Name = "lb_TenThuongHieu";
            this.lb_TenThuongHieu.Size = new System.Drawing.Size(159, 23);
            this.lb_TenThuongHieu.TabIndex = 6;
            this.lb_TenThuongHieu.Text = "Tên thương hiệu:";
            // 
            // tb_TenThuongHieu
            // 
            this.tb_TenThuongHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_TenThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenThuongHieu.Location = new System.Drawing.Point(24, 54);
            this.tb_TenThuongHieu.Name = "tb_TenThuongHieu";
            this.tb_TenThuongHieu.Size = new System.Drawing.Size(335, 23);
            this.tb_TenThuongHieu.TabIndex = 31;
            // 
            // tb_SoDienThoaiDaiDien
            // 
            this.tb_SoDienThoaiDaiDien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_SoDienThoaiDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoDienThoaiDaiDien.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoDienThoaiDaiDien.Location = new System.Drawing.Point(24, 223);
            this.tb_SoDienThoaiDaiDien.Name = "tb_SoDienThoaiDaiDien";
            this.tb_SoDienThoaiDaiDien.Size = new System.Drawing.Size(335, 23);
            this.tb_SoDienThoaiDaiDien.TabIndex = 5;
            // 
            // lb_NoiDungHopDong
            // 
            this.lb_NoiDungHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NoiDungHopDong.AutoSize = true;
            this.lb_NoiDungHopDong.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoiDungHopDong.Location = new System.Drawing.Point(386, 19);
            this.lb_NoiDungHopDong.Name = "lb_NoiDungHopDong";
            this.lb_NoiDungHopDong.Size = new System.Drawing.Size(186, 23);
            this.lb_NoiDungHopDong.TabIndex = 10;
            this.lb_NoiDungHopDong.Text = "Nội dung hợp đồng:";
            // 
            // tb_NoiDungHopDong
            // 
            this.tb_NoiDungHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_NoiDungHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoiDungHopDong.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoiDungHopDong.Location = new System.Drawing.Point(390, 54);
            this.tb_NoiDungHopDong.Multiline = true;
            this.tb_NoiDungHopDong.Name = "tb_NoiDungHopDong";
            this.tb_NoiDungHopDong.Size = new System.Drawing.Size(335, 363);
            this.tb_NoiDungHopDong.TabIndex = 3;
            // 
            // cb_LoaiHinh
            // 
            this.cb_LoaiHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiHinh.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiHinh.FormattingEnabled = true;
            this.cb_LoaiHinh.Items.AddRange(new object[] {
            "Mua sắm",
            "Ăn uống",
            "Du lịch",
            "Khác"});
            this.cb_LoaiHinh.Location = new System.Drawing.Point(24, 138);
            this.cb_LoaiHinh.Name = "cb_LoaiHinh";
            this.cb_LoaiHinh.Size = new System.Drawing.Size(335, 24);
            this.cb_LoaiHinh.TabIndex = 32;
            this.cb_LoaiHinh.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiHinh_SelectedIndexChanged);
            // 
            // lb_NgayKy
            // 
            this.lb_NgayKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_NgayKy.AutoSize = true;
            this.lb_NgayKy.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayKy.Location = new System.Drawing.Point(20, 278);
            this.lb_NgayKy.Name = "lb_NgayKy";
            this.lb_NgayKy.Size = new System.Drawing.Size(89, 23);
            this.lb_NgayKy.TabIndex = 34;
            this.lb_NgayKy.Text = "Ngày ký:";
            // 
            // dtpk_NgayKy
            // 
            this.dtpk_NgayKy.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayKy.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayKy.Location = new System.Drawing.Point(24, 304);
            this.dtpk_NgayKy.Name = "dtpk_NgayKy";
            this.dtpk_NgayKy.Size = new System.Drawing.Size(335, 27);
            this.dtpk_NgayKy.TabIndex = 35;
            // 
            // dtpk_NgayKetThuc
            // 
            this.dtpk_NgayKetThuc.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayKetThuc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayKetThuc.Location = new System.Drawing.Point(24, 390);
            this.dtpk_NgayKetThuc.Name = "dtpk_NgayKetThuc";
            this.dtpk_NgayKetThuc.Size = new System.Drawing.Size(335, 27);
            this.dtpk_NgayKetThuc.TabIndex = 36;
            // 
            // btn_DatLai
            // 
            this.btn_DatLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_DatLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_DatLai.FlatAppearance.BorderSize = 0;
            this.btn_DatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatLai.Location = new System.Drawing.Point(200, 525);
            this.btn_DatLai.Name = "btn_DatLai";
            this.btn_DatLai.Size = new System.Drawing.Size(150, 30);
            this.btn_DatLai.TabIndex = 6;
            this.btn_DatLai.Text = "Đặt lại";
            this.btn_DatLai.UseVisualStyleBackColor = false;
            this.btn_DatLai.Click += new System.EventHandler(this.btn_DatLai_Click);
            // 
            // ucTaoHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_DatLai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_TaoHopDong);
            this.Controls.Add(this.panel1);
            this.Name = "ucTaoHopDong";
            this.Size = new System.Drawing.Size(798, 577);
            this.Load += new System.EventHandler(this.ucTaoHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_TaoHopDong;
        private System.Windows.Forms.Button btn_TaoHopDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_NgayKetThuc;
        private System.Windows.Forms.Label lb_LoaiHinh;
        private System.Windows.Forms.Label lb_SoDienThoaiDaiDien;
        private System.Windows.Forms.Label lb_TenThuongHieu;
        private System.Windows.Forms.TextBox tb_TenThuongHieu;
        private System.Windows.Forms.Label lb_NoiDungHopDong;
        private System.Windows.Forms.TextBox tb_SoDienThoaiDaiDien;
        private System.Windows.Forms.TextBox tb_NoiDungHopDong;
        private System.Windows.Forms.ComboBox cb_LoaiHinh;
        private System.Windows.Forms.Label lb_NgayKy;
        private System.Windows.Forms.DateTimePicker dtpk_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpk_NgayKy;
        private System.Windows.Forms.Button btn_DatLai;
    }
}
