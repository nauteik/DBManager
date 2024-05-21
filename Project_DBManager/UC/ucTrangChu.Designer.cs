namespace Project_DBManager.UC
{
    partial class ucTrangChu
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
            this.lb_WelcomeBack = new System.Windows.Forms.Label();
            this.lb_LichSuHoatDong = new System.Windows.Forms.Label();
            this.dtgv_Staff = new System.Windows.Forms.DataGridView();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.lb_Loc = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).BeginInit();
            this.pn_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_WelcomeBack
            // 
            this.lb_WelcomeBack.AutoSize = true;
            this.lb_WelcomeBack.Font = new System.Drawing.Font("Inter Italic", 19.25F, System.Drawing.FontStyle.Bold);
            this.lb_WelcomeBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_WelcomeBack.Location = new System.Drawing.Point(15, 16);
            this.lb_WelcomeBack.Name = "lb_WelcomeBack";
            this.lb_WelcomeBack.Size = new System.Drawing.Size(351, 31);
            this.lb_WelcomeBack.TabIndex = 4;
            this.lb_WelcomeBack.Text = "Welcome back, [Tên User]";
            // 
            // lb_LichSuHoatDong
            // 
            this.lb_LichSuHoatDong.AutoSize = true;
            this.lb_LichSuHoatDong.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LichSuHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_LichSuHoatDong.Location = new System.Drawing.Point(15, 79);
            this.lb_LichSuHoatDong.Name = "lb_LichSuHoatDong";
            this.lb_LichSuHoatDong.Size = new System.Drawing.Size(253, 33);
            this.lb_LichSuHoatDong.TabIndex = 4;
            this.lb_LichSuHoatDong.Text = "Lịch sử hoạt động";
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
            this.staffName,
            this.Position,
            this.Dept,
            this.ActDate,
            this.Content,
            this.ActID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Staff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Staff.EnableHeadersVisualStyles = false;
            this.dtgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_Staff.Location = new System.Drawing.Point(21, 146);
            this.dtgv_Staff.Name = "dtgv_Staff";
            this.dtgv_Staff.RowHeadersVisible = false;
            this.dtgv_Staff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Staff.Size = new System.Drawing.Size(750, 375);
            this.dtgv_Staff.TabIndex = 10;
            // 
            // cbLoc
            // 
            this.cbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoc.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Không",
            "Ăn uống",
            "Du lịch",
            "Mua sắm",
            "Giải trí",
            "Làm đẹp",
            "Quà tặng"});
            this.cbLoc.Location = new System.Drawing.Point(69, 117);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(98, 23);
            this.cbLoc.TabIndex = 13;
            this.cbLoc.SelectedIndexChanged += new System.EventHandler(this.cbLoc_SelectedIndexChanged);
            // 
            // lb_Loc
            // 
            this.lb_Loc.AutoSize = true;
            this.lb_Loc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_Loc.Location = new System.Drawing.Point(26, 119);
            this.lb_Loc.Name = "lb_Loc";
            this.lb_Loc.Size = new System.Drawing.Size(37, 19);
            this.lb_Loc.TabIndex = 14;
            this.lb_Loc.Text = "Lọc";
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(189, 119);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(78, 19);
            this.lb_TimKiem.TabIndex = 11;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BackColor = System.Drawing.Color.White;
            this.pn_TimKiem.Controls.Add(this.tb_TimKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(272, 117);
            this.pn_TimKiem.Name = "pn_TimKiem";
            this.pn_TimKiem.Size = new System.Drawing.Size(133, 23);
            this.pn_TimKiem.TabIndex = 15;
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
            // staffName
            // 
            this.staffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staffName.DataPropertyName = "name";
            this.staffName.FillWeight = 20F;
            this.staffName.HeaderText = "Tên nhân viên";
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "position";
            this.Position.FillWeight = 15F;
            this.Position.HeaderText = "Chức vụ";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dept.DataPropertyName = "dept";
            this.Dept.FillWeight = 15F;
            this.Dept.HeaderText = "Phòng ban";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            // 
            // ActDate
            // 
            this.ActDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActDate.DataPropertyName = "date";
            this.ActDate.FillWeight = 20F;
            this.ActDate.HeaderText = "Thời gian";
            this.ActDate.Name = "ActDate";
            this.ActDate.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.DataPropertyName = "content";
            this.Content.FillWeight = 30F;
            this.Content.HeaderText = "Thao tác";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // ActID
            // 
            this.ActID.DataPropertyName = "actID";
            this.ActID.HeaderText = "ActID";
            this.ActID.Name = "ActID";
            this.ActID.Visible = false;
            // 
            // ucTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pn_TimKiem);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.lb_Loc);
            this.Controls.Add(this.lb_TimKiem);
            this.Controls.Add(this.dtgv_Staff);
            this.Controls.Add(this.lb_LichSuHoatDong);
            this.Controls.Add(this.lb_WelcomeBack);
            this.Name = "ucTrangChu";
            this.Size = new System.Drawing.Size(798, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).EndInit();
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_WelcomeBack;
        private System.Windows.Forms.Label lb_LichSuHoatDong;
        private System.Windows.Forms.DataGridView dtgv_Staff;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Label lb_Loc;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActID;
    }
}
