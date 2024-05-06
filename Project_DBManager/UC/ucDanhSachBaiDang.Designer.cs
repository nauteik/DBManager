namespace Project_DBManager.UC
{
    partial class ucDanhSachBaiDang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachBaiDang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_DanhSachBaiDang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaiXuong = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cb_SapXep = new System.Windows.Forms.ComboBox();
            this.lb_TaiXuong = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_SapXep = new System.Windows.Forms.Label();
            this.btn_XoaDuLieu = new System.Windows.Forms.Button();
            this.btn_XuatDuLieu = new System.Windows.Forms.Button();
            this.dtgv_DanhSachBaiDang = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Post_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upload_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ucChinhSuaBaiDang1 = new Project_DBManager.ucChinhSuaBaiDang();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachBaiDang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_DanhSachBaiDang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 1;
            // 
            // tb_DanhSachBaiDang
            // 
            this.tb_DanhSachBaiDang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_DanhSachBaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DanhSachBaiDang.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DanhSachBaiDang.Location = new System.Drawing.Point(25, 10);
            this.tb_DanhSachBaiDang.Name = "tb_DanhSachBaiDang";
            this.tb_DanhSachBaiDang.Size = new System.Drawing.Size(219, 26);
            this.tb_DanhSachBaiDang.TabIndex = 0;
            this.tb_DanhSachBaiDang.Text = "Danh Sách Bài Đăng";
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
            this.panel2.TabIndex = 2;
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
            this.tb_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TimKiem_KeyPress_1);
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
            "Ngày tạo tăng dần",
            "Ngày tạo giảm dần",
            "Người tạo tăng dần",
            "Người tạo giảm dần"});
            this.cb_SapXep.Location = new System.Drawing.Point(101, 13);
            this.cb_SapXep.Name = "cb_SapXep";
            this.cb_SapXep.Size = new System.Drawing.Size(150, 23);
            this.cb_SapXep.TabIndex = 4;
            this.cb_SapXep.SelectedIndexChanged += new System.EventHandler(this.cb_SapXep_SelectedIndexChanged);
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
            this.btn_XoaDuLieu.TabIndex = 7;
            this.btn_XoaDuLieu.Text = "Xóa dữ liệu";
            this.btn_XoaDuLieu.UseVisualStyleBackColor = false;
            this.btn_XoaDuLieu.Click += new System.EventHandler(this.btn_XoaDuLieu_Click);
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
            this.btn_XuatDuLieu.TabIndex = 6;
            this.btn_XuatDuLieu.Text = "Xuất dữ liệu";
            this.btn_XuatDuLieu.UseVisualStyleBackColor = false;
            this.btn_XuatDuLieu.Click += new System.EventHandler(this.btn_XuatDuLieu_Click);
            // 
            // dtgv_DanhSachBaiDang
            // 
            this.dtgv_DanhSachBaiDang.AllowUserToAddRows = false;
            this.dtgv_DanhSachBaiDang.AllowUserToDeleteRows = false;
            this.dtgv_DanhSachBaiDang.AllowUserToResizeColumns = false;
            this.dtgv_DanhSachBaiDang.AllowUserToResizeRows = false;
            this.dtgv_DanhSachBaiDang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_DanhSachBaiDang.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_DanhSachBaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_DanhSachBaiDang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DanhSachBaiDang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_DanhSachBaiDang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DanhSachBaiDang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.Post_ID,
            this.Brand_Name,
            this.Upload_Date,
            this._Type,
            this._Name,
            this.Content,
            this.Edit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_DanhSachBaiDang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_DanhSachBaiDang.EnableHeadersVisualStyles = false;
            this.dtgv_DanhSachBaiDang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_DanhSachBaiDang.Location = new System.Drawing.Point(25, 125);
            this.dtgv_DanhSachBaiDang.Name = "dtgv_DanhSachBaiDang";
            this.dtgv_DanhSachBaiDang.RowHeadersVisible = false;
            this.dtgv_DanhSachBaiDang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_DanhSachBaiDang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_DanhSachBaiDang.Size = new System.Drawing.Size(750, 375);
            this.dtgv_DanhSachBaiDang.TabIndex = 8;
            this.dtgv_DanhSachBaiDang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DanhSachBaiDang_CellContentClick);
            this.dtgv_DanhSachBaiDang.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DanhSachBaiDang_CellMouseEnter);
            this.dtgv_DanhSachBaiDang.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DanhSachBaiDang_CellMouseLeave);
            this.dtgv_DanhSachBaiDang.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_DanhSachBaiDang_CellMouseMove);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 50;
            // 
            // Post_ID
            // 
            this.Post_ID.DataPropertyName = "postID";
            this.Post_ID.HeaderText = "ID";
            this.Post_ID.Name = "Post_ID";
            this.Post_ID.ReadOnly = true;
            this.Post_ID.Width = 50;
            // 
            // Brand_Name
            // 
            this.Brand_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Brand_Name.DataPropertyName = "brandName";
            this.Brand_Name.HeaderText = "Thương hiệu";
            this.Brand_Name.Name = "Brand_Name";
            this.Brand_Name.ReadOnly = true;
            this.Brand_Name.Width = 123;
            // 
            // Upload_Date
            // 
            this.Upload_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Upload_Date.DataPropertyName = "uploadDate";
            this.Upload_Date.HeaderText = "Ngày tạo";
            this.Upload_Date.Name = "Upload_Date";
            this.Upload_Date.ReadOnly = true;
            this.Upload_Date.Width = 87;
            // 
            // _Type
            // 
            this._Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._Type.DataPropertyName = "type";
            this._Type.HeaderText = "Chủ đề";
            this._Type.Name = "_Type";
            this._Type.ReadOnly = true;
            this._Type.Width = 78;
            // 
            // _Name
            // 
            this._Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._Name.DataPropertyName = "name";
            this._Name.HeaderText = "Người tạo";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            this._Name.Width = 93;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.DataPropertyName = "content";
            this.Content.HeaderText = "Nội dung";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // ucChinhSuaBaiDang1
            // 
            this.ucChinhSuaBaiDang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ucChinhSuaBaiDang1.Location = new System.Drawing.Point(0, 0);
            this.ucChinhSuaBaiDang1.Name = "ucChinhSuaBaiDang1";
            this.ucChinhSuaBaiDang1.PostInfoToShow = null;
            this.ucChinhSuaBaiDang1.Size = new System.Drawing.Size(798, 577);
            this.ucChinhSuaBaiDang1.TabIndex = 9;
            this.ucChinhSuaBaiDang1.Load += new System.EventHandler(this.ucChinhSuaBaiDang1_Load);
            // 
            // ucDanhSachBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucChinhSuaBaiDang1);
            this.Controls.Add(this.dtgv_DanhSachBaiDang);
            this.Controls.Add(this.btn_XoaDuLieu);
            this.Controls.Add(this.btn_XuatDuLieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhSachBaiDang";
            this.Size = new System.Drawing.Size(798, 577);
            this.Load += new System.EventHandler(this.ucDanhSachBaiDang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachBaiDang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_DanhSachBaiDang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaiXuong;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.ComboBox cb_SapXep;
        private System.Windows.Forms.Label lb_TaiXuong;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label lb_SapXep;
        private System.Windows.Forms.Button btn_XoaDuLieu;
        private System.Windows.Forms.Button btn_XuatDuLieu;
        private System.Windows.Forms.DataGridView dtgv_DanhSachBaiDang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Upload_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private ucChinhSuaBaiDang ucChinhSuaBaiDang1;
    }
}
