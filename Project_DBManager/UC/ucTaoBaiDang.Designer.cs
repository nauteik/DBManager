namespace Project_DBManager.UC
{
    partial class ucTaoBaiDang
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
            this.tb_TaoBaiDang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Google = new System.Windows.Forms.Label();
            this.tb_Google = new System.Windows.Forms.TextBox();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.tb_TrangThai = new System.Windows.Forms.TextBox();
            this.cb_TenThuongHieu = new System.Windows.Forms.ComboBox();
            this.lb_NoiDung = new System.Windows.Forms.Label();
            this.lb_Facebook = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SoDienThoai = new System.Windows.Forms.Label();
            this.lb_TenThuongHieu = new System.Windows.Forms.Label();
            this.tb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_Facebook = new System.Windows.Forms.TextBox();
            this.btn_TaoBaiDang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tb_TaoBaiDang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_TaoBaiDang
            // 
            this.tb_TaoBaiDang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_TaoBaiDang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_TaoBaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TaoBaiDang.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaoBaiDang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_TaoBaiDang.Location = new System.Drawing.Point(25, 12);
            this.tb_TaoBaiDang.Name = "tb_TaoBaiDang";
            this.tb_TaoBaiDang.ReadOnly = true;
            this.tb_TaoBaiDang.Size = new System.Drawing.Size(184, 33);
            this.tb_TaoBaiDang.TabIndex = 0;
            this.tb_TaoBaiDang.Text = "Tạo Bài Đăng";
            this.tb_TaoBaiDang.TextChanged += new System.EventHandler(this.tb_ThongTinHopDong_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.lb_Google);
            this.panel2.Controls.Add(this.tb_Google);
            this.panel2.Controls.Add(this.lb_TrangThai);
            this.panel2.Controls.Add(this.tb_TrangThai);
            this.panel2.Controls.Add(this.cb_TenThuongHieu);
            this.panel2.Controls.Add(this.lb_NoiDung);
            this.panel2.Controls.Add(this.lb_Facebook);
            this.panel2.Controls.Add(this.lb_DiaChi);
            this.panel2.Controls.Add(this.lb_SoDienThoai);
            this.panel2.Controls.Add(this.lb_TenThuongHieu);
            this.panel2.Controls.Add(this.tb_SoDienThoai);
            this.panel2.Controls.Add(this.tb_NoiDung);
            this.panel2.Controls.Add(this.tb_DiaChi);
            this.panel2.Controls.Add(this.tb_Facebook);
            this.panel2.Location = new System.Drawing.Point(25, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(750, 469);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lb_Google
            // 
            this.lb_Google.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_Google.AutoSize = true;
            this.lb_Google.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Google.Location = new System.Drawing.Point(25, 338);
            this.lb_Google.Name = "lb_Google";
            this.lb_Google.Size = new System.Drawing.Size(74, 23);
            this.lb_Google.TabIndex = 32;
            this.lb_Google.Text = "Google";
            // 
            // tb_Google
            // 
            this.tb_Google.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_Google.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Google.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Google.Location = new System.Drawing.Point(25, 364);
            this.tb_Google.Name = "tb_Google";
            this.tb_Google.ReadOnly = true;
            this.tb_Google.Size = new System.Drawing.Size(335, 23);
            this.tb_Google.TabIndex = 31;
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.Location = new System.Drawing.Point(25, 409);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(101, 23);
            this.lb_TrangThai.TabIndex = 30;
            this.lb_TrangThai.Text = "Trạng thái";
            this.lb_TrangThai.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tb_TrangThai
            // 
            this.tb_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_TrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TrangThai.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrangThai.Location = new System.Drawing.Point(25, 435);
            this.tb_TrangThai.Name = "tb_TrangThai";
            this.tb_TrangThai.ReadOnly = true;
            this.tb_TrangThai.Size = new System.Drawing.Size(335, 23);
            this.tb_TrangThai.TabIndex = 29;
            this.tb_TrangThai.TextChanged += new System.EventHandler(this.tb_TrangThai_TextChanged);
            // 
            // cb_TenThuongHieu
            // 
            this.cb_TenThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenThuongHieu.FormattingEnabled = true;
            this.cb_TenThuongHieu.Location = new System.Drawing.Point(25, 54);
            this.cb_TenThuongHieu.Name = "cb_TenThuongHieu";
            this.cb_TenThuongHieu.Size = new System.Drawing.Size(335, 24);
            this.cb_TenThuongHieu.TabIndex = 1;
            this.cb_TenThuongHieu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_NoiDung
            // 
            this.lb_NoiDung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NoiDung.AutoSize = true;
            this.lb_NoiDung.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoiDung.Location = new System.Drawing.Point(396, 34);
            this.lb_NoiDung.Name = "lb_NoiDung";
            this.lb_NoiDung.Size = new System.Drawing.Size(91, 23);
            this.lb_NoiDung.TabIndex = 10;
            this.lb_NoiDung.Text = "Nội dung";
            this.lb_NoiDung.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_Facebook
            // 
            this.lb_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_Facebook.AutoSize = true;
            this.lb_Facebook.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Facebook.Location = new System.Drawing.Point(25, 267);
            this.lb_Facebook.Name = "lb_Facebook";
            this.lb_Facebook.Size = new System.Drawing.Size(83, 23);
            this.lb_Facebook.TabIndex = 9;
            this.lb_Facebook.Text = "Website";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(25, 193);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(72, 23);
            this.lb_DiaChi.TabIndex = 8;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // lb_SoDienThoai
            // 
            this.lb_SoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_SoDienThoai.AutoSize = true;
            this.lb_SoDienThoai.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoDienThoai.Location = new System.Drawing.Point(25, 115);
            this.lb_SoDienThoai.Name = "lb_SoDienThoai";
            this.lb_SoDienThoai.Size = new System.Drawing.Size(128, 23);
            this.lb_SoDienThoai.TabIndex = 7;
            this.lb_SoDienThoai.Text = "Số điện thoại";
            // 
            // lb_TenThuongHieu
            // 
            this.lb_TenThuongHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_TenThuongHieu.AutoSize = true;
            this.lb_TenThuongHieu.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuongHieu.Location = new System.Drawing.Point(25, 28);
            this.lb_TenThuongHieu.Name = "lb_TenThuongHieu";
            this.lb_TenThuongHieu.Size = new System.Drawing.Size(154, 23);
            this.lb_TenThuongHieu.TabIndex = 6;
            this.lb_TenThuongHieu.Text = "Tên thương hiệu";
            this.lb_TenThuongHieu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_SoDienThoai
            // 
            this.tb_SoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SoDienThoai.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoDienThoai.Location = new System.Drawing.Point(25, 141);
            this.tb_SoDienThoai.Name = "tb_SoDienThoai";
            this.tb_SoDienThoai.ReadOnly = true;
            this.tb_SoDienThoai.Size = new System.Drawing.Size(335, 23);
            this.tb_SoDienThoai.TabIndex = 5;
            this.tb_SoDienThoai.TextChanged += new System.EventHandler(this.tb_SoDienThoai_TextChanged);
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_NoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoiDung.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoiDung.Location = new System.Drawing.Point(390, 63);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(335, 175);
            this.tb_NoiDung.TabIndex = 3;
            this.tb_NoiDung.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DiaChi.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(25, 219);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.ReadOnly = true;
            this.tb_DiaChi.Size = new System.Drawing.Size(335, 23);
            this.tb_DiaChi.TabIndex = 2;
            // 
            // tb_Facebook
            // 
            this.tb_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_Facebook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Facebook.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Facebook.Location = new System.Drawing.Point(25, 293);
            this.tb_Facebook.Name = "tb_Facebook";
            this.tb_Facebook.ReadOnly = true;
            this.tb_Facebook.Size = new System.Drawing.Size(335, 23);
            this.tb_Facebook.TabIndex = 1;
            // 
            // btn_TaoBaiDang
            // 
            this.btn_TaoBaiDang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TaoBaiDang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoBaiDang.FlatAppearance.BorderSize = 0;
            this.btn_TaoBaiDang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoBaiDang.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoBaiDang.Location = new System.Drawing.Point(25, 534);
            this.btn_TaoBaiDang.Name = "btn_TaoBaiDang";
            this.btn_TaoBaiDang.Size = new System.Drawing.Size(150, 30);
            this.btn_TaoBaiDang.TabIndex = 3;
            this.btn_TaoBaiDang.Text = "Tạo bài đăng";
            this.btn_TaoBaiDang.UseVisualStyleBackColor = false;
            this.btn_TaoBaiDang.Click += new System.EventHandler(this.btn_TaoBaiDang_Click);
            // 
            // ucTaoBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_TaoBaiDang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucTaoBaiDang";
            this.Size = new System.Drawing.Size(798, 577);
            this.Load += new System.EventHandler(this.ucTaoBaiDang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_TaoBaiDang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaoBaiDang;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_Facebook;
        private System.Windows.Forms.Label lb_NoiDung;
        private System.Windows.Forms.Label lb_Facebook;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SoDienThoai;
        private System.Windows.Forms.Label lb_TenThuongHieu;
        private System.Windows.Forms.TextBox tb_SoDienThoai;
        private System.Windows.Forms.ComboBox cb_TenThuongHieu;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.TextBox tb_TrangThai;
        private System.Windows.Forms.Label lb_Google;
        private System.Windows.Forms.TextBox tb_Google;
    }
}
