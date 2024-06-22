namespace Project_DBManager.UC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTaoHopDong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_TaoHopDong = new System.Windows.Forms.TextBox();
            this.btn_TaoHopDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_TenThuongHieu = new System.Windows.Forms.ComboBox();
            this.dtpk_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpk_NgayKy = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayKy = new System.Windows.Forms.Label();
            this.lb_NoiDungHopDong = new System.Windows.Forms.Label();
            this.lb_NgayKetThuc = new System.Windows.Forms.Label();
            this.lb_TenThuongHieu = new System.Windows.Forms.Label();
            this.tb_NoiDungHopDong = new System.Windows.Forms.TextBox();
            this.btn_DatLai = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.btn_TaoHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_TaoHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoHopDong.FlatAppearance.BorderSize = 0;
            this.btn_TaoHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHopDong.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.cb_TenThuongHieu);
            this.panel2.Controls.Add(this.dtpk_NgayKetThuc);
            this.panel2.Controls.Add(this.dtpk_NgayKy);
            this.panel2.Controls.Add(this.lb_NgayKy);
            this.panel2.Controls.Add(this.lb_NoiDungHopDong);
            this.panel2.Controls.Add(this.lb_NgayKetThuc);
            this.panel2.Controls.Add(this.lb_TenThuongHieu);
            this.panel2.Controls.Add(this.tb_NoiDungHopDong);
            this.panel2.Location = new System.Drawing.Point(25, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(750, 450);
            this.panel2.TabIndex = 5;
            // 
            // cb_TenThuongHieu
            // 
            this.cb_TenThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenThuongHieu.FormattingEnabled = true;
            this.cb_TenThuongHieu.Location = new System.Drawing.Point(24, 56);
            this.cb_TenThuongHieu.Name = "cb_TenThuongHieu";
            this.cb_TenThuongHieu.Size = new System.Drawing.Size(335, 24);
            this.cb_TenThuongHieu.TabIndex = 37;
            // 
            // dtpk_NgayKetThuc
            // 
            this.dtpk_NgayKetThuc.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayKetThuc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayKetThuc.Location = new System.Drawing.Point(24, 224);
            this.dtpk_NgayKetThuc.Name = "dtpk_NgayKetThuc";
            this.dtpk_NgayKetThuc.Size = new System.Drawing.Size(335, 27);
            this.dtpk_NgayKetThuc.TabIndex = 36;
            this.dtpk_NgayKetThuc.ValueChanged += new System.EventHandler(this.dtpk_NgayKetThuc_ValueChanged);
            // 
            // dtpk_NgayKy
            // 
            this.dtpk_NgayKy.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayKy.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayKy.Location = new System.Drawing.Point(24, 138);
            this.dtpk_NgayKy.Name = "dtpk_NgayKy";
            this.dtpk_NgayKy.Size = new System.Drawing.Size(335, 27);
            this.dtpk_NgayKy.TabIndex = 35;
            this.dtpk_NgayKy.ValueChanged += new System.EventHandler(this.dtpk_NgayKy_ValueChanged);
            // 
            // lb_NgayKy
            // 
            this.lb_NgayKy.AutoSize = true;
            this.lb_NgayKy.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayKy.Location = new System.Drawing.Point(20, 112);
            this.lb_NgayKy.Name = "lb_NgayKy";
            this.lb_NgayKy.Size = new System.Drawing.Size(89, 23);
            this.lb_NgayKy.TabIndex = 34;
            this.lb_NgayKy.Text = "Ngày ký:";
            // 
            // lb_NoiDungHopDong
            // 
            this.lb_NoiDungHopDong.AutoSize = true;
            this.lb_NoiDungHopDong.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoiDungHopDong.Location = new System.Drawing.Point(386, 19);
            this.lb_NoiDungHopDong.Name = "lb_NoiDungHopDong";
            this.lb_NoiDungHopDong.Size = new System.Drawing.Size(186, 23);
            this.lb_NoiDungHopDong.TabIndex = 10;
            this.lb_NoiDungHopDong.Text = "Nội dung hợp đồng:";
            // 
            // lb_NgayKetThuc
            // 
            this.lb_NgayKetThuc.AutoSize = true;
            this.lb_NgayKetThuc.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayKetThuc.Location = new System.Drawing.Point(20, 198);
            this.lb_NgayKetThuc.Name = "lb_NgayKetThuc";
            this.lb_NgayKetThuc.Size = new System.Drawing.Size(141, 23);
            this.lb_NgayKetThuc.TabIndex = 9;
            this.lb_NgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // lb_TenThuongHieu
            // 
            this.lb_TenThuongHieu.AutoSize = true;
            this.lb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuongHieu.Location = new System.Drawing.Point(20, 25);
            this.lb_TenThuongHieu.Name = "lb_TenThuongHieu";
            this.lb_TenThuongHieu.Size = new System.Drawing.Size(159, 23);
            this.lb_TenThuongHieu.TabIndex = 6;
            this.lb_TenThuongHieu.Text = "Tên thương hiệu:";
            // 
            // tb_NoiDungHopDong
            // 
            this.tb_NoiDungHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NoiDungHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoiDungHopDong.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoiDungHopDong.Location = new System.Drawing.Point(390, 54);
            this.tb_NoiDungHopDong.Multiline = true;
            this.tb_NoiDungHopDong.Name = "tb_NoiDungHopDong";
            this.tb_NoiDungHopDong.Size = new System.Drawing.Size(335, 363);
            this.tb_NoiDungHopDong.TabIndex = 3;
            this.tb_NoiDungHopDong.TextChanged += new System.EventHandler(this.tb_NoiDungHopDong_TextChanged);
            // 
            // btn_DatLai
            // 
            this.btn_DatLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DatLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_DatLai.FlatAppearance.BorderSize = 0;
            this.btn_DatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatLai.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatLai.Location = new System.Drawing.Point(200, 525);
            this.btn_DatLai.Name = "btn_DatLai";
            this.btn_DatLai.Size = new System.Drawing.Size(150, 30);
            this.btn_DatLai.TabIndex = 6;
            this.btn_DatLai.Text = "Đặt lại";
            this.btn_DatLai.UseVisualStyleBackColor = false;
            this.btn_DatLai.Click += new System.EventHandler(this.btn_DatLai_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_TaoHopDong;
        private System.Windows.Forms.Button btn_TaoHopDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_NgayKetThuc;
        private System.Windows.Forms.Label lb_TenThuongHieu;
        private System.Windows.Forms.Label lb_NoiDungHopDong;
        private System.Windows.Forms.TextBox tb_NoiDungHopDong;
        private System.Windows.Forms.Label lb_NgayKy;
        private System.Windows.Forms.DateTimePicker dtpk_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpk_NgayKy;
        private System.Windows.Forms.Button btn_DatLai;
        private System.Windows.Forms.ComboBox cb_TenThuongHieu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
