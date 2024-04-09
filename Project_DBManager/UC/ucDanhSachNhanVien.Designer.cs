namespace Project_DBManager
{
    partial class ucDanhSachNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_DanhSachNhanVien = new System.Windows.Forms.Label();
            this.pn_ToolMenu = new System.Windows.Forms.Panel();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.lb_Loc = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cb_SapXep = new System.Windows.Forms.ComboBox();
            this.lb_TaiXuong = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_SapXep = new System.Windows.Forms.Label();
            this.dtgv_Staff = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_XuatDuLieu = new System.Windows.Forms.Button();
            this.pb_TaiXuong = new System.Windows.Forms.PictureBox();
            this.pn_ToolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiXuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DanhSachNhanVien
            // 
            this.lb_DanhSachNhanVien.AutoSize = true;
            this.lb_DanhSachNhanVien.Font = new System.Drawing.Font("Inter Black", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachNhanVien.Location = new System.Drawing.Point(20, 23);
            this.lb_DanhSachNhanVien.Name = "lb_DanhSachNhanVien";
            this.lb_DanhSachNhanVien.Size = new System.Drawing.Size(270, 30);
            this.lb_DanhSachNhanVien.TabIndex = 2;
            this.lb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // pn_ToolMenu
            // 
            this.pn_ToolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ToolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_ToolMenu.Controls.Add(this.pb_TaiXuong);
            this.pn_ToolMenu.Controls.Add(this.cbLoc);
            this.pn_ToolMenu.Controls.Add(this.lb_Loc);
            this.pn_ToolMenu.Controls.Add(this.tb_TimKiem);
            this.pn_ToolMenu.Controls.Add(this.cb_SapXep);
            this.pn_ToolMenu.Controls.Add(this.lb_TaiXuong);
            this.pn_ToolMenu.Controls.Add(this.lb_TimKiem);
            this.pn_ToolMenu.Controls.Add(this.lb_SapXep);
            this.pn_ToolMenu.Location = new System.Drawing.Point(25, 60);
            this.pn_ToolMenu.Name = "pn_ToolMenu";
            this.pn_ToolMenu.Size = new System.Drawing.Size(750, 50);
            this.pn_ToolMenu.TabIndex = 3;
            // 
            // cbLoc
            // 
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Location = new System.Drawing.Point(262, 16);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(98, 21);
            this.cbLoc.TabIndex = 8;
            this.cbLoc.Text = "  Chưa tạo";
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
            // tb_TimKiem
            // 
            this.tb_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TimKiem.Font = new System.Drawing.Font("Inter Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(464, 15);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(114, 20);
            this.tb_TimKiem.TabIndex = 6;
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
            this.lb_TaiXuong.Location = new System.Drawing.Point(595, 15);
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
            this.dtgv_Staff.AllowUserToResizeColumns = false;
            this.dtgv_Staff.AllowUserToResizeRows = false;
            this.dtgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "Không";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(13, 5, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.ContractID,
            this.Position,
            this.Dept,
            this.Phone,
            this.Email,
            this.Edit});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Staff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_Staff.EnableHeadersVisualStyles = false;
            this.dtgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_Staff.Location = new System.Drawing.Point(25, 125);
            this.dtgv_Staff.Name = "dtgv_Staff";
            this.dtgv_Staff.RowHeadersVisible = false;
            this.dtgv_Staff.RowHeadersWidth = 51;
            this.dtgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_Staff.Size = new System.Drawing.Size(750, 373);
            this.dtgv_Staff.TabIndex = 5;
            this.dtgv_Staff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_Staff_CellFormatting);
            this.dtgv_Staff.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Staff_CellMouseEnter);
            this.dtgv_Staff.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Staff_CellMouseLeave);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.MinimumWidth = 6;
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsChecked.Width = 21;
            // 
            // ContractID
            // 
            this.ContractID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContractID.DataPropertyName = "name";
            this.ContractID.FillWeight = 43.2799F;
            this.ContractID.HeaderText = "Tên nhân viên";
            this.ContractID.MinimumWidth = 15;
            this.ContractID.Name = "ContractID";
            this.ContractID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "position";
            this.Position.FillWeight = 33.66245F;
            this.Position.HeaderText = "Chức vụ";
            this.Position.MinimumWidth = 10;
            this.Position.Name = "Position";
            // 
            // Dept
            // 
            this.Dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept.DataPropertyName = "dept";
            this.Dept.FillWeight = 27.31996F;
            this.Dept.HeaderText = "Vị trí";
            this.Dept.MinimumWidth = 6;
            this.Dept.Name = "Dept";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "phone";
            this.Phone.FillWeight = 42.22113F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 44.27044F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 40;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 40;
            // 
            // btn_XuatDuLieu
            // 
            this.btn_XuatDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XuatDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_XuatDuLieu.FlatAppearance.BorderSize = 0;
            this.btn_XuatDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatDuLieu.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatDuLieu.Location = new System.Drawing.Point(25, 523);
            this.btn_XuatDuLieu.Name = "btn_XuatDuLieu";
            this.btn_XuatDuLieu.Size = new System.Drawing.Size(150, 30);
            this.btn_XuatDuLieu.TabIndex = 6;
            this.btn_XuatDuLieu.Text = "Xuất dữ liệu";
            this.btn_XuatDuLieu.UseVisualStyleBackColor = false;
            this.btn_XuatDuLieu.Click += new System.EventHandler(this.btn_XuatDuLieu_Click);
            // 
            // pb_TaiXuong
            // 
            this.pb_TaiXuong.BackColor = System.Drawing.Color.White;
            this.pb_TaiXuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_TaiXuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TaiXuong.Image = global::Project_DBManager.Properties.Resources.Import_light;
            this.pb_TaiXuong.Location = new System.Drawing.Point(684, 12);
            this.pb_TaiXuong.Name = "pb_TaiXuong";
            this.pb_TaiXuong.Size = new System.Drawing.Size(25, 25);
            this.pb_TaiXuong.TabIndex = 10;
            this.pb_TaiXuong.TabStop = false;
            this.pb_TaiXuong.Click += new System.EventHandler(this.pb_TaiXuong_Click);
            this.pb_TaiXuong.MouseEnter += new System.EventHandler(this.pb_TaiXuong_MouseEnter);
            this.pb_TaiXuong.MouseLeave += new System.EventHandler(this.pb_TaiXuong_MouseLeave);
            // 
            // ucDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_XuatDuLieu);
            this.Controls.Add(this.dtgv_Staff);
            this.Controls.Add(this.pn_ToolMenu);
            this.Controls.Add(this.lb_DanhSachNhanVien);
            this.Name = "ucDanhSachNhanVien";
            this.Size = new System.Drawing.Size(798, 577);
            this.pn_ToolMenu.ResumeLayout(false);
            this.pn_ToolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiXuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DanhSachNhanVien;
        private System.Windows.Forms.Panel pn_ToolMenu;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.ComboBox cb_SapXep;
        private System.Windows.Forms.Label lb_TaiXuong;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label lb_SapXep;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Label lb_Loc;
        private System.Windows.Forms.DataGridView dtgv_Staff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btn_XuatDuLieu;
        private System.Windows.Forms.PictureBox pb_TaiXuong;
    }
}
