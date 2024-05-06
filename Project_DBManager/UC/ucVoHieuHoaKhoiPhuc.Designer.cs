namespace Project_DBManager.UC
{
    partial class ucVoHieuHoaKhoiPhuc
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
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.lb_Loc = new System.Windows.Forms.Label();
            this.cb_SapXep = new System.Windows.Forms.ComboBox();
            this.lb_TaiXuong = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_SapXep = new System.Windows.Forms.Label();
            this.dtgv_Staff = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_ToolMenu = new System.Windows.Forms.Panel();
            this.pb_TaiXuong = new System.Windows.Forms.PictureBox();
            this.lb_DanhSachNhanVien = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ucThongTinNhanVien1 = new Project_DBManager.ucThongTinNhanVien();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.pn_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).BeginInit();
            this.pn_ToolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiXuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BackColor = System.Drawing.Color.White;
            this.pn_TimKiem.Controls.Add(this.tb_TimKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(464, 15);
            this.pn_TimKiem.Name = "pn_TimKiem";
            this.pn_TimKiem.Size = new System.Drawing.Size(133, 23);
            this.pn_TimKiem.TabIndex = 11;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TimKiem.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(8, 4);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(114, 15);
            this.tb_TimKiem.TabIndex = 6;
            this.tb_TimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_TimKiem_KeyDown);
            // 
            // cbLoc
            // 
            this.cbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoc.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Không",
            "Manager",
            "Leader",
            "Employee"});
            this.cbLoc.Location = new System.Drawing.Point(262, 15);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(98, 23);
            this.cbLoc.TabIndex = 8;
            this.cbLoc.SelectedValueChanged += new System.EventHandler(this.cbLoc_SelectedValueChanged);
            // 
            // lb_Loc
            // 
            this.lb_Loc.AutoSize = true;
            this.lb_Loc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_Loc.Location = new System.Drawing.Point(219, 17);
            this.lb_Loc.Name = "lb_Loc";
            this.lb_Loc.Size = new System.Drawing.Size(37, 19);
            this.lb_Loc.TabIndex = 9;
            this.lb_Loc.Text = "Lọc";
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
            this.cb_SapXep.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SapXep.FormattingEnabled = true;
            this.cb_SapXep.Items.AddRange(new object[] {
            "Không",
            "Tên nhân viên (A-Z)",
            "Tên nhân viên (Z-A)",
            "Chức vụ (Cao-thấp)",
            "Chức vụ (Thấp-cao)",
            "Vị trí"});
            this.cb_SapXep.Location = new System.Drawing.Point(74, 15);
            this.cb_SapXep.Name = "cb_SapXep";
            this.cb_SapXep.Size = new System.Drawing.Size(139, 23);
            this.cb_SapXep.TabIndex = 4;
            this.cb_SapXep.SelectedValueChanged += new System.EventHandler(this.cb_SapXep_SelectedValueChanged);
            // 
            // lb_TaiXuong
            // 
            this.lb_TaiXuong.AutoSize = true;
            this.lb_TaiXuong.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaiXuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TaiXuong.Location = new System.Drawing.Point(621, 16);
            this.lb_TaiXuong.Name = "lb_TaiXuong";
            this.lb_TaiXuong.Size = new System.Drawing.Size(83, 19);
            this.lb_TaiXuong.TabIndex = 3;
            this.lb_TaiXuong.Text = "Tải xuống";
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(380, 17);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(78, 19);
            this.lb_TimKiem.TabIndex = 2;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // lb_SapXep
            // 
            this.lb_SapXep.AutoSize = true;
            this.lb_SapXep.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SapXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_SapXep.Location = new System.Drawing.Point(3, 17);
            this.lb_SapXep.Name = "lb_SapXep";
            this.lb_SapXep.Size = new System.Drawing.Size(71, 19);
            this.lb_SapXep.TabIndex = 0;
            this.lb_SapXep.Text = "Sắp xếp";
            // 
            // dtgv_Staff
            // 
            this.dtgv_Staff.AllowUserToAddRows = false;
            this.dtgv_Staff.AllowUserToDeleteRows = false;
            this.dtgv_Staff.AllowUserToResizeRows = false;
            this.dtgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(13, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.staffName,
            this.Position,
            this.Dept,
            this.Phone,
            this.Email,
            this.Edit,
            this.UserID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Staff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Staff.EnableHeadersVisualStyles = false;
            this.dtgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_Staff.Location = new System.Drawing.Point(27, 142);
            this.dtgv_Staff.Name = "dtgv_Staff";
            this.dtgv_Staff.RowHeadersVisible = false;
            this.dtgv_Staff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_Staff.Size = new System.Drawing.Size(750, 375);
            this.dtgv_Staff.TabIndex = 13;
            this.dtgv_Staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Staff_CellClick);
            this.dtgv_Staff.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Staff_CellMouseEnter);
            this.dtgv_Staff.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Staff_CellMouseLeave);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 30;
            // 
            // staffName
            // 
            this.staffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staffName.DataPropertyName = "name";
            this.staffName.FillWeight = 25F;
            this.staffName.HeaderText = "Tên nhân viên";
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "position";
            this.Position.FillWeight = 18.37761F;
            this.Position.HeaderText = "Chức vụ";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept.DataPropertyName = "dept";
            this.Dept.FillWeight = 18.37761F;
            this.Dept.HeaderText = "Vị trí";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "phone";
            this.Phone.FillWeight = 23.27831F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 26.73057F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 40;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "userID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // pn_ToolMenu
            // 
            this.pn_ToolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ToolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_ToolMenu.Controls.Add(this.pn_TimKiem);
            this.pn_ToolMenu.Controls.Add(this.pb_TaiXuong);
            this.pn_ToolMenu.Controls.Add(this.cbLoc);
            this.pn_ToolMenu.Controls.Add(this.lb_Loc);
            this.pn_ToolMenu.Controls.Add(this.cb_SapXep);
            this.pn_ToolMenu.Controls.Add(this.lb_TaiXuong);
            this.pn_ToolMenu.Controls.Add(this.lb_TimKiem);
            this.pn_ToolMenu.Controls.Add(this.lb_SapXep);
            this.pn_ToolMenu.Location = new System.Drawing.Point(27, 60);
            this.pn_ToolMenu.Name = "pn_ToolMenu";
            this.pn_ToolMenu.Size = new System.Drawing.Size(750, 50);
            this.pn_ToolMenu.TabIndex = 11;
            // 
            // pb_TaiXuong
            // 
            this.pb_TaiXuong.BackColor = System.Drawing.Color.White;
            this.pb_TaiXuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_TaiXuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TaiXuong.Image = global::Project_DBManager.Properties.Resources.Import_light;
            this.pb_TaiXuong.Location = new System.Drawing.Point(710, 13);
            this.pb_TaiXuong.Name = "pb_TaiXuong";
            this.pb_TaiXuong.Size = new System.Drawing.Size(25, 25);
            this.pb_TaiXuong.TabIndex = 10;
            this.pb_TaiXuong.TabStop = false;
            // 
            // lb_DanhSachNhanVien
            // 
            this.lb_DanhSachNhanVien.AutoSize = true;
            this.lb_DanhSachNhanVien.Font = new System.Drawing.Font("Inter Black", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachNhanVien.Location = new System.Drawing.Point(22, 23);
            this.lb_DanhSachNhanVien.Name = "lb_DanhSachNhanVien";
            this.lb_DanhSachNhanVien.Size = new System.Drawing.Size(411, 30);
            this.lb_DanhSachNhanVien.TabIndex = 10;
            this.lb_DanhSachNhanVien.Text = "Danh sách tài khoản vô hiệu hoá";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // ucThongTinNhanVien1
            // 
            this.ucThongTinNhanVien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ucThongTinNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.ucThongTinNhanVien1.Name = "ucThongTinNhanVien1";
            this.ucThongTinNhanVien1.Size = new System.Drawing.Size(798, 577);
            this.ucThongTinNhanVien1.TabIndex = 14;
            this.ucThongTinNhanVien1.UserID = 0;
            this.ucThongTinNhanVien1.Visible = false;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_KhoiPhuc.FlatAppearance.BorderSize = 0;
            this.btn_KhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(36, 531);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(112, 30);
            this.btn_KhoiPhuc.TabIndex = 15;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // ucVoHieuHoaKhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.ucThongTinNhanVien1);
            this.Controls.Add(this.dtgv_Staff);
            this.Controls.Add(this.pn_ToolMenu);
            this.Controls.Add(this.lb_DanhSachNhanVien);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Name = "ucVoHieuHoaKhoiPhuc";
            this.Size = new System.Drawing.Size(798, 577);
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).EndInit();
            this.pn_ToolMenu.ResumeLayout(false);
            this.pn_ToolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiXuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.PictureBox pb_TaiXuong;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Label lb_Loc;
        private System.Windows.Forms.ComboBox cb_SapXep;
        private System.Windows.Forms.Label lb_TaiXuong;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label lb_SapXep;
        private System.Windows.Forms.DataGridView dtgv_Staff;
        private System.Windows.Forms.Panel pn_ToolMenu;
        private System.Windows.Forms.Label lb_DanhSachNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private ucThongTinNhanVien ucThongTinNhanVien1;
        private System.Windows.Forms.Button btn_KhoiPhuc;
    }
}
