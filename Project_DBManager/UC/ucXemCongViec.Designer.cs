namespace Project_DBManager.UC
{
    partial class ucXemCongViec
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
            this.lb_XemCongViec = new System.Windows.Forms.Label();
            this.dtgv_CongViec = new System.Windows.Forms.DataGridView();
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CongViec)).BeginInit();
            this.pn_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_XemCongViec
            // 
            this.lb_XemCongViec.AutoSize = true;
            this.lb_XemCongViec.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XemCongViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_XemCongViec.Location = new System.Drawing.Point(17, 15);
            this.lb_XemCongViec.Name = "lb_XemCongViec";
            this.lb_XemCongViec.Size = new System.Drawing.Size(210, 33);
            this.lb_XemCongViec.TabIndex = 3;
            this.lb_XemCongViec.Text = "Xem công việc";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(13, 5, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_CongViec.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_CongViec.EnableHeadersVisualStyles = false;
            this.dtgv_CongViec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_CongViec.Location = new System.Drawing.Point(23, 108);
            this.dtgv_CongViec.Name = "dtgv_CongViec";
            this.dtgv_CongViec.RowHeadersVisible = false;
            this.dtgv_CongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CongViec.Size = new System.Drawing.Size(748, 400);
            this.dtgv_CongViec.TabIndex = 54;
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BackColor = System.Drawing.Color.White;
            this.pn_TimKiem.Controls.Add(this.tb_TimKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(115, 62);
            this.pn_TimKiem.Name = "pn_TimKiem";
            this.pn_TimKiem.Size = new System.Drawing.Size(133, 23);
            this.pn_TimKiem.TabIndex = 53;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(273, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lọc";
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(31, 64);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(78, 19);
            this.lb_TimKiem.TabIndex = 52;
            this.lb_TimKiem.Text = "Tìm kiếm";
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
            this.cbLoc.Location = new System.Drawing.Point(316, 63);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(155, 23);
            this.cbLoc.TabIndex = 50;
            this.cbLoc.SelectedIndexChanged += new System.EventHandler(this.cbLoc_SelectedIndexChanged);
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_HoanThanh.FlatAppearance.BorderSize = 0;
            this.btn_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(35, 531);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(157, 30);
            this.btn_HoanThanh.TabIndex = 55;
            this.btn_HoanThanh.Text = "Xác nhận hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
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
            this.ViTri.DataPropertyName = "sender";
            this.ViTri.HeaderText = "Người giao";
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
            this.ChiTiet.FillWeight = 80F;
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
            // ucXemCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.dtgv_CongViec);
            this.Controls.Add(this.pn_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TimKiem);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.lb_XemCongViec);
            this.Name = "ucXemCongViec";
            this.Size = new System.Drawing.Size(798, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CongViec)).EndInit();
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_XemCongViec;
        private System.Windows.Forms.DataGridView dtgv_CongViec;
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.Button btn_HoanThanh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCompleted;
    }
}
