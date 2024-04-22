namespace Project_DBManager
{
    partial class ucDanhSachHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachHopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ThongTinHopDong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaiXuong = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cb_SapXep = new System.Windows.Forms.ComboBox();
            this.lb_TaiXuong = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_SapXep = new System.Windows.Forms.Label();
            this.btn_XuatDuLieu = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_XoaDuLieu = new System.Windows.Forms.Button();
            this.ucChinhSuaHopDong1 = new Project_DBManager.ucChinhSuaHopDong();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tb_ThongTinHopDong);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 0;
            // 
            // tb_ThongTinHopDong
            // 
            this.tb_ThongTinHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_ThongTinHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ThongTinHopDong.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThongTinHopDong.Location = new System.Drawing.Point(25, 10);
            this.tb_ThongTinHopDong.Name = "tb_ThongTinHopDong";
            this.tb_ThongTinHopDong.Size = new System.Drawing.Size(219, 26);
            this.tb_ThongTinHopDong.TabIndex = 0;
            this.tb_ThongTinHopDong.Text = "Danh Sách Hợp Đồng";
            this.tb_ThongTinHopDong.TextChanged += new System.EventHandler(this.tb_ThongTinHopDong_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.btn_TaiXuong);
            this.panel2.Controls.Add(this.tb_TimKiem);
            this.panel2.Controls.Add(this.cb_SapXep);
            this.panel2.Controls.Add(this.lb_TaiXuong);
            this.panel2.Controls.Add(this.lb_TimKiem);
            this.panel2.Controls.Add(this.lb_SapXep);
            this.panel2.Location = new System.Drawing.Point(25, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 1;
            // 
            // btn_TaiXuong
            // 
            this.btn_TaiXuong.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiXuong.Image")));
            this.btn_TaiXuong.Location = new System.Drawing.Point(685, 7);
            this.btn_TaiXuong.Name = "btn_TaiXuong";
            this.btn_TaiXuong.Size = new System.Drawing.Size(35, 35);
            this.btn_TaiXuong.TabIndex = 7;
            this.btn_TaiXuong.UseVisualStyleBackColor = true;
            this.btn_TaiXuong.Click += new System.EventHandler(this.btn_TaiXuong_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TimKiem.Font = new System.Drawing.Font("Inter Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(360, 15);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(200, 20);
            this.tb_TimKiem.TabIndex = 6;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            this.tb_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TimKiem_KeyPress);
            // 
            // cb_SapXep
            // 
            this.cb_SapXep.AutoCompleteCustomSource.AddRange(new string[] {
            "Tăng dần",
            "Giảm dần"});
            this.cb_SapXep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_SapXep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_SapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_SapXep.Font = new System.Drawing.Font("Inter Italic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SapXep.FormattingEnabled = true;
            this.cb_SapXep.Items.AddRange(new object[] {
            "ID tăng dần",
            "ID giảm dần",
            "Tên thương hiệu tăng dần",
            "Tên thương hiệu giảm dần",
            "Ngày ký tăng dần",
            "Ngày ký giảm dần",
            "Ngày hết hạn tăng dần",
            "Ngày hết hạn giảm dần"});
            this.cb_SapXep.Location = new System.Drawing.Point(101, 13);
            this.cb_SapXep.Name = "cb_SapXep";
            this.cb_SapXep.Size = new System.Drawing.Size(150, 23);
            this.cb_SapXep.TabIndex = 4;
            this.cb_SapXep.SelectedIndexChanged += new System.EventHandler(this.cb_SapXep_SelectedIndexChanged);
            this.cb_SapXep.SelectedValueChanged += new System.EventHandler(this.cb_SapXep_SelectedValueChanged);
            // 
            // lb_TaiXuong
            // 
            this.lb_TaiXuong.AutoSize = true;
            this.lb_TaiXuong.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaiXuong.Location = new System.Drawing.Point(595, 15);
            this.lb_TaiXuong.Name = "lb_TaiXuong";
            this.lb_TaiXuong.Size = new System.Drawing.Size(78, 19);
            this.lb_TaiXuong.TabIndex = 3;
            this.lb_TaiXuong.Text = "Tải xuống";
            this.lb_TaiXuong.Click += new System.EventHandler(this.lb_TaiXuong_Click);
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.Location = new System.Drawing.Point(281, 15);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(74, 19);
            this.lb_TimKiem.TabIndex = 2;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // lb_SapXep
            // 
            this.lb_SapXep.AutoSize = true;
            this.lb_SapXep.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SapXep.Location = new System.Drawing.Point(30, 15);
            this.lb_SapXep.Name = "lb_SapXep";
            this.lb_SapXep.Size = new System.Drawing.Size(66, 19);
            this.lb_SapXep.TabIndex = 0;
            this.lb_SapXep.Text = "Sắp xếp";
            // 
            // btn_XuatDuLieu
            // 
            this.btn_XuatDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XuatDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_XuatDuLieu.FlatAppearance.BorderSize = 0;
            this.btn_XuatDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatDuLieu.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatDuLieu.Location = new System.Drawing.Point(25, 525);
            this.btn_XuatDuLieu.Name = "btn_XuatDuLieu";
            this.btn_XuatDuLieu.Size = new System.Drawing.Size(150, 30);
            this.btn_XuatDuLieu.TabIndex = 3;
            this.btn_XuatDuLieu.Text = "Xuất dữ liệu";
            this.btn_XuatDuLieu.UseVisualStyleBackColor = false;
            this.btn_XuatDuLieu.Click += new System.EventHandler(this.btn_XuatDuLieu_Click);
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
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.ContractID,
            this.BrandName,
            this.SignedDate,
            this.Duration,
            this.Content,
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv.Location = new System.Drawing.Point(25, 125);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv.Size = new System.Drawing.Size(750, 375);
            this.dtgv.TabIndex = 4;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dtgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellMouseEnter);
            this.dtgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellMouseLeave);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.FillWeight = 80.54395F;
            this.IsChecked.HeaderText = "";
            this.IsChecked.MinimumWidth = 6;
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsChecked.Width = 50;
            // 
            // ContractID
            // 
            this.ContractID.DataPropertyName = "contractID";
            this.ContractID.FillWeight = 76.14214F;
            this.ContractID.HeaderText = "ID";
            this.ContractID.MinimumWidth = 6;
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            this.ContractID.Width = 50;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "brandName";
            this.BrandName.FillWeight = 110.8285F;
            this.BrandName.HeaderText = "Thương hiệu";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 150;
            // 
            // SignedDate
            // 
            this.SignedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SignedDate.DataPropertyName = "signedDate";
            this.SignedDate.FillWeight = 110.8285F;
            this.SignedDate.HeaderText = "Ngày ký";
            this.SignedDate.MinimumWidth = 6;
            this.SignedDate.Name = "SignedDate";
            this.SignedDate.ReadOnly = true;
            this.SignedDate.Width = 89;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Duration.DataPropertyName = "duration";
            this.Duration.FillWeight = 110.8285F;
            this.Duration.HeaderText = "Ngày hết hạn";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 92;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.DataPropertyName = "content";
            this.Content.FillWeight = 110.8285F;
            this.Content.HeaderText = "Nội dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 50;
            // 
            // btn_XoaDuLieu
            // 
            this.btn_XoaDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XoaDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_XoaDuLieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_XoaDuLieu.FlatAppearance.BorderSize = 0;
            this.btn_XoaDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaDuLieu.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDuLieu.Location = new System.Drawing.Point(200, 525);
            this.btn_XoaDuLieu.Name = "btn_XoaDuLieu";
            this.btn_XoaDuLieu.Size = new System.Drawing.Size(150, 30);
            this.btn_XoaDuLieu.TabIndex = 5;
            this.btn_XoaDuLieu.Text = "Xóa dữ liệu";
            this.btn_XoaDuLieu.UseVisualStyleBackColor = false;
            this.btn_XoaDuLieu.Click += new System.EventHandler(this.btn_XoaDuLieu_Click);
            // 
            // ucChinhSuaHopDong1
            // 
            this.ucChinhSuaHopDong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ucChinhSuaHopDong1.ContractInfo = null;
            this.ucChinhSuaHopDong1.Location = new System.Drawing.Point(0, 0);
            this.ucChinhSuaHopDong1.Name = "ucChinhSuaHopDong1";
            this.ucChinhSuaHopDong1.Size = new System.Drawing.Size(798, 577);
            this.ucChinhSuaHopDong1.TabIndex = 6;
            this.ucChinhSuaHopDong1.Load += new System.EventHandler(this.ucChinhSuaHopDong1_Load_1);
            // 
            // ucDanhSachHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.ucChinhSuaHopDong1);
            this.Controls.Add(this.btn_XoaDuLieu);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btn_XuatDuLieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhSachHopDong";
            this.Size = new System.Drawing.Size(798, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ThongTinHopDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaiXuong;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.ComboBox cb_SapXep;
        private System.Windows.Forms.Label lb_TaiXuong;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label lb_SapXep;
        private System.Windows.Forms.Button btn_XuatDuLieu;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btn_XoaDuLieu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private ucChinhSuaHopDong ucChinhSuaHopDong1;
    }
}
