namespace Project_DBManager.UC
{
    partial class ucPhanCongCongViec
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
            this.lb_PhanCongCongViec = new System.Windows.Forms.Label();
            this.pn_GiaoViec = new System.Windows.Forms.Panel();
            this.lb_ChiTiet = new System.Windows.Forms.Label();
            this.pn_GhiChu = new System.Windows.Forms.Panel();
            this.tb_GhiChu = new System.Windows.Forms.TextBox();
            this.dtpk_Deadline = new System.Windows.Forms.DateTimePicker();
            this.lb_Deadline = new System.Windows.Forms.Label();
            this.lb_TenCongViec = new System.Windows.Forms.Label();
            this.pn_TenCongViec = new System.Windows.Forms.Panel();
            this.tb_TenCongViec = new System.Windows.Forms.TextBox();
            this.lb_ChonViTri = new System.Windows.Forms.Label();
            this.pn_ChonViTri = new System.Windows.Forms.Panel();
            this.cb_ViTri = new System.Windows.Forms.ComboBox();
            this.btn_TaoCongViec = new System.Windows.Forms.Button();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_CongViec = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pn_GiaoViec.SuspendLayout();
            this.pn_GhiChu.SuspendLayout();
            this.pn_TenCongViec.SuspendLayout();
            this.pn_ChonViTri.SuspendLayout();
            this.pn_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_PhanCongCongViec
            // 
            this.lb_PhanCongCongViec.AutoSize = true;
            this.lb_PhanCongCongViec.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhanCongCongViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_PhanCongCongViec.Location = new System.Drawing.Point(17, 15);
            this.lb_PhanCongCongViec.Name = "lb_PhanCongCongViec";
            this.lb_PhanCongCongViec.Size = new System.Drawing.Size(290, 33);
            this.lb_PhanCongCongViec.TabIndex = 2;
            this.lb_PhanCongCongViec.Text = "Phân công công việc";
            // 
            // pn_GiaoViec
            // 
            this.pn_GiaoViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_GiaoViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_GiaoViec.Controls.Add(this.lb_ChiTiet);
            this.pn_GiaoViec.Controls.Add(this.pn_GhiChu);
            this.pn_GiaoViec.Controls.Add(this.dtpk_Deadline);
            this.pn_GiaoViec.Controls.Add(this.lb_Deadline);
            this.pn_GiaoViec.Controls.Add(this.lb_TenCongViec);
            this.pn_GiaoViec.Controls.Add(this.pn_TenCongViec);
            this.pn_GiaoViec.Controls.Add(this.lb_ChonViTri);
            this.pn_GiaoViec.Controls.Add(this.pn_ChonViTri);
            this.pn_GiaoViec.Location = new System.Drawing.Point(23, 65);
            this.pn_GiaoViec.Name = "pn_GiaoViec";
            this.pn_GiaoViec.Size = new System.Drawing.Size(272, 444);
            this.pn_GiaoViec.TabIndex = 3;
            // 
            // lb_ChiTiet
            // 
            this.lb_ChiTiet.AutoSize = true;
            this.lb_ChiTiet.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChiTiet.Location = new System.Drawing.Point(19, 225);
            this.lb_ChiTiet.Name = "lb_ChiTiet";
            this.lb_ChiTiet.Size = new System.Drawing.Size(64, 19);
            this.lb_ChiTiet.TabIndex = 43;
            this.lb_ChiTiet.Text = "Chi tiết";
            // 
            // pn_GhiChu
            // 
            this.pn_GhiChu.BackColor = System.Drawing.Color.White;
            this.pn_GhiChu.Controls.Add(this.tb_GhiChu);
            this.pn_GhiChu.Location = new System.Drawing.Point(19, 247);
            this.pn_GhiChu.Name = "pn_GhiChu";
            this.pn_GhiChu.Size = new System.Drawing.Size(226, 147);
            this.pn_GhiChu.TabIndex = 42;
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_GhiChu.BackColor = System.Drawing.Color.White;
            this.tb_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GhiChu.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GhiChu.ForeColor = System.Drawing.Color.Black;
            this.tb_GhiChu.Location = new System.Drawing.Point(8, 8);
            this.tb_GhiChu.Multiline = true;
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.Size = new System.Drawing.Size(210, 133);
            this.tb_GhiChu.TabIndex = 2;
            // 
            // dtpk_Deadline
            // 
            this.dtpk_Deadline.CalendarFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_Deadline.CustomFormat = " dd-MM-yyyy";
            this.dtpk_Deadline.Font = new System.Drawing.Font("Inter", 11F);
            this.dtpk_Deadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_Deadline.Location = new System.Drawing.Point(19, 175);
            this.dtpk_Deadline.Name = "dtpk_Deadline";
            this.dtpk_Deadline.Size = new System.Drawing.Size(226, 25);
            this.dtpk_Deadline.TabIndex = 40;
            // 
            // lb_Deadline
            // 
            this.lb_Deadline.AutoSize = true;
            this.lb_Deadline.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Deadline.Location = new System.Drawing.Point(19, 150);
            this.lb_Deadline.Name = "lb_Deadline";
            this.lb_Deadline.Size = new System.Drawing.Size(75, 19);
            this.lb_Deadline.TabIndex = 41;
            this.lb_Deadline.Text = "Deadline";
            // 
            // lb_TenCongViec
            // 
            this.lb_TenCongViec.AutoSize = true;
            this.lb_TenCongViec.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCongViec.Location = new System.Drawing.Point(19, 81);
            this.lb_TenCongViec.Name = "lb_TenCongViec";
            this.lb_TenCongViec.Size = new System.Drawing.Size(115, 19);
            this.lb_TenCongViec.TabIndex = 13;
            this.lb_TenCongViec.Text = "Tên công việc";
            // 
            // pn_TenCongViec
            // 
            this.pn_TenCongViec.BackColor = System.Drawing.Color.White;
            this.pn_TenCongViec.Controls.Add(this.tb_TenCongViec);
            this.pn_TenCongViec.Location = new System.Drawing.Point(19, 103);
            this.pn_TenCongViec.Name = "pn_TenCongViec";
            this.pn_TenCongViec.Size = new System.Drawing.Size(226, 30);
            this.pn_TenCongViec.TabIndex = 12;
            // 
            // tb_TenCongViec
            // 
            this.tb_TenCongViec.BackColor = System.Drawing.Color.White;
            this.tb_TenCongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenCongViec.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenCongViec.ForeColor = System.Drawing.Color.Black;
            this.tb_TenCongViec.Location = new System.Drawing.Point(5, 8);
            this.tb_TenCongViec.Name = "tb_TenCongViec";
            this.tb_TenCongViec.Size = new System.Drawing.Size(210, 17);
            this.tb_TenCongViec.TabIndex = 1;
            // 
            // lb_ChonViTri
            // 
            this.lb_ChonViTri.AutoSize = true;
            this.lb_ChonViTri.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonViTri.Location = new System.Drawing.Point(19, 12);
            this.lb_ChonViTri.Name = "lb_ChonViTri";
            this.lb_ChonViTri.Size = new System.Drawing.Size(88, 19);
            this.lb_ChonViTri.TabIndex = 39;
            this.lb_ChonViTri.Text = "Chọn vị trí";
            // 
            // pn_ChonViTri
            // 
            this.pn_ChonViTri.BackColor = System.Drawing.Color.White;
            this.pn_ChonViTri.Controls.Add(this.cb_ViTri);
            this.pn_ChonViTri.Location = new System.Drawing.Point(19, 34);
            this.pn_ChonViTri.Name = "pn_ChonViTri";
            this.pn_ChonViTri.Size = new System.Drawing.Size(226, 30);
            this.pn_ChonViTri.TabIndex = 38;
            // 
            // cb_ViTri
            // 
            this.cb_ViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ViTri.Font = new System.Drawing.Font("Inter", 10F);
            this.cb_ViTri.FormattingEnabled = true;
            this.cb_ViTri.Items.AddRange(new object[] {
            "Ăn uống",
            "Mua sắm",
            "Làm đẹp",
            "Du lịch",
            "Giải trí",
            "Quà tặng"});
            this.cb_ViTri.Location = new System.Drawing.Point(3, 3);
            this.cb_ViTri.Name = "cb_ViTri";
            this.cb_ViTri.Size = new System.Drawing.Size(221, 24);
            this.cb_ViTri.TabIndex = 11;
            // 
            // btn_TaoCongViec
            // 
            this.btn_TaoCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_TaoCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoCongViec.FlatAppearance.BorderSize = 0;
            this.btn_TaoCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoCongViec.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoCongViec.Location = new System.Drawing.Point(33, 515);
            this.btn_TaoCongViec.Name = "btn_TaoCongViec";
            this.btn_TaoCongViec.Size = new System.Drawing.Size(112, 30);
            this.btn_TaoCongViec.TabIndex = 44;
            this.btn_TaoCongViec.Text = "Tạo công việc";
            this.btn_TaoCongViec.UseVisualStyleBackColor = false;
            this.btn_TaoCongViec.Click += new System.EventHandler(this.btn_TaoCongViec_Click);
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_HoanThanh.FlatAppearance.BorderSize = 0;
            this.btn_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(425, 515);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(157, 30);
            this.btn_HoanThanh.TabIndex = 44;
            this.btn_HoanThanh.Text = "Xác nhận hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // cbLoc
            // 
            this.cbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoc.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbLoc.Location = new System.Drawing.Point(599, 65);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(155, 23);
            this.cbLoc.TabIndex = 46;
            this.cbLoc.SelectedIndexChanged += new System.EventHandler(this.cbLoc_SelectedIndexChanged);
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BackColor = System.Drawing.Color.White;
            this.pn_TimKiem.Controls.Add(this.tb_TimKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(398, 64);
            this.pn_TimKiem.Name = "pn_TimKiem";
            this.pn_TimKiem.Size = new System.Drawing.Size(133, 23);
            this.pn_TimKiem.TabIndex = 48;
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
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(314, 66);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(78, 19);
            this.lb_TimKiem.TabIndex = 47;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(556, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Lọc";
            // 
            // dtgv_CongViec
            // 
            this.dtgv_CongViec.AllowUserToAddRows = false;
            this.dtgv_CongViec.AllowUserToDeleteRows = false;
            this.dtgv_CongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_CongViec.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_CongViec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_CongViec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(13, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.TaskTitle,
            this.ViTri,
            this.AssignDate,
            this.Deadline,
            this.ChiTiet,
            this.TaskID,
            this.IsCompleted});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_CongViec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_CongViec.EnableHeadersVisualStyles = false;
            this.dtgv_CongViec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_CongViec.Location = new System.Drawing.Point(301, 109);
            this.dtgv_CongViec.Name = "dtgv_CongViec";
            this.dtgv_CongViec.RowHeadersVisible = false;
            this.dtgv_CongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CongViec.Size = new System.Drawing.Size(494, 400);
            this.dtgv_CongViec.TabIndex = 49;
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 20;
            // 
            // TaskTitle
            // 
            this.TaskTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskTitle.DataPropertyName = "taskTitle";
            this.TaskTitle.HeaderText = "Tên công việc";
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.ReadOnly = true;
            this.TaskTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViTri
            // 
            this.ViTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ViTri.DataPropertyName = "department";
            this.ViTri.FillWeight = 50F;
            this.ViTri.HeaderText = "Vị trí";
            this.ViTri.Name = "ViTri";
            this.ViTri.ReadOnly = true;
            // 
            // AssignDate
            // 
            this.AssignDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignDate.DataPropertyName = "assignDate";
            this.AssignDate.FillWeight = 50F;
            this.AssignDate.HeaderText = "Ngày giao";
            this.AssignDate.Name = "AssignDate";
            this.AssignDate.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deadline.DataPropertyName = "deadline";
            this.Deadline.FillWeight = 50F;
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChiTiet.DataPropertyName = "description";
            this.ChiTiet.HeaderText = "Chi tiết";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            // 
            // TaskID
            // 
            this.TaskID.DataPropertyName = "taskID";
            this.TaskID.HeaderText = "TaskID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            this.TaskID.Visible = false;
            // 
            // IsCompleted
            // 
            this.IsCompleted.DataPropertyName = "isCompleted";
            this.IsCompleted.HeaderText = "IsCompleted";
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.ReadOnly = true;
            this.IsCompleted.Visible = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(318, 515);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 30);
            this.btn_Xoa.TabIndex = 50;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // ucPhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dtgv_CongViec);
            this.Controls.Add(this.pn_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TimKiem);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.btn_TaoCongViec);
            this.Controls.Add(this.pn_GiaoViec);
            this.Controls.Add(this.lb_PhanCongCongViec);
            this.Name = "ucPhanCongCongViec";
            this.Size = new System.Drawing.Size(798, 577);
            this.pn_GiaoViec.ResumeLayout(false);
            this.pn_GiaoViec.PerformLayout();
            this.pn_GhiChu.ResumeLayout(false);
            this.pn_GhiChu.PerformLayout();
            this.pn_TenCongViec.ResumeLayout(false);
            this.pn_TenCongViec.PerformLayout();
            this.pn_ChonViTri.ResumeLayout(false);
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PhanCongCongViec;
        private System.Windows.Forms.Panel pn_GiaoViec;
        private System.Windows.Forms.Label lb_ChonViTri;
        private System.Windows.Forms.Panel pn_ChonViTri;
        private System.Windows.Forms.ComboBox cb_ViTri;
        private System.Windows.Forms.Label lb_TenCongViec;
        private System.Windows.Forms.Panel pn_TenCongViec;
        private System.Windows.Forms.TextBox tb_TenCongViec;
        private System.Windows.Forms.DateTimePicker dtpk_Deadline;
        private System.Windows.Forms.Label lb_Deadline;
        private System.Windows.Forms.Label lb_ChiTiet;
        private System.Windows.Forms.Panel pn_GhiChu;
        private System.Windows.Forms.TextBox tb_GhiChu;
        private System.Windows.Forms.Button btn_TaoCongViec;
        private System.Windows.Forms.Button btn_HoanThanh;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_CongViec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCompleted;
        private System.Windows.Forms.Button btn_Xoa;
    }
}
