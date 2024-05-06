namespace Project_DBManager.UC
{
    partial class ucCapLaiMatKhau
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
            this.dtgv_Account = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CapMatKhau = new System.Windows.Forms.Button();
            this.pn_ToolMenu = new System.Windows.Forms.Panel();
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_CapLaiMatKhau = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).BeginInit();
            this.pn_ToolMenu.SuspendLayout();
            this.pn_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_Account
            // 
            this.dtgv_Account.AllowUserToAddRows = false;
            this.dtgv_Account.AllowUserToDeleteRows = false;
            this.dtgv_Account.AllowUserToResizeRows = false;
            this.dtgv_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(13, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.Username,
            this.Password,
            this.Phone,
            this.Email,
            this.UserID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Account.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Account.EnableHeadersVisualStyles = false;
            this.dtgv_Account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtgv_Account.Location = new System.Drawing.Point(27, 142);
            this.dtgv_Account.Name = "dtgv_Account";
            this.dtgv_Account.RowHeadersVisible = false;
            this.dtgv_Account.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_Account.Size = new System.Drawing.Size(750, 375);
            this.dtgv_Account.TabIndex = 13;
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 30;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "username";
            this.Username.FillWeight = 5.5F;
            this.Username.HeaderText = "Tên tài khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "password";
            this.Password.FillWeight = 3F;
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "sdt";
            this.Phone.FillWeight = 4.365112F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "email";
            this.Email.FillWeight = 5.012475F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "userID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // btn_CapMatKhau
            // 
            this.btn_CapMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CapMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_CapMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_CapMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapMatKhau.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapMatKhau.Location = new System.Drawing.Point(27, 523);
            this.btn_CapMatKhau.Name = "btn_CapMatKhau";
            this.btn_CapMatKhau.Size = new System.Drawing.Size(150, 30);
            this.btn_CapMatKhau.TabIndex = 12;
            this.btn_CapMatKhau.Text = "Cấp mật khẩu";
            this.btn_CapMatKhau.UseVisualStyleBackColor = false;
            // 
            // pn_ToolMenu
            // 
            this.pn_ToolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ToolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_ToolMenu.Controls.Add(this.pn_TimKiem);
            this.pn_ToolMenu.Controls.Add(this.lb_TimKiem);
            this.pn_ToolMenu.Location = new System.Drawing.Point(27, 60);
            this.pn_ToolMenu.Name = "pn_ToolMenu";
            this.pn_ToolMenu.Size = new System.Drawing.Size(750, 50);
            this.pn_ToolMenu.TabIndex = 11;
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BackColor = System.Drawing.Color.White;
            this.pn_TimKiem.Controls.Add(this.tb_TimKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(104, 15);
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
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(20, 17);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(78, 19);
            this.lb_TimKiem.TabIndex = 2;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // lb_CapLaiMatKhau
            // 
            this.lb_CapLaiMatKhau.AutoSize = true;
            this.lb_CapLaiMatKhau.Font = new System.Drawing.Font("Inter Black", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CapLaiMatKhau.Location = new System.Drawing.Point(22, 23);
            this.lb_CapLaiMatKhau.Name = "lb_CapLaiMatKhau";
            this.lb_CapLaiMatKhau.Size = new System.Drawing.Size(184, 30);
            this.lb_CapLaiMatKhau.TabIndex = 10;
            this.lb_CapLaiMatKhau.Text = "Cấp mật khẩu";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_DBManager.Properties.Resources.arrow;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // ucCapLaiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.dtgv_Account);
            this.Controls.Add(this.btn_CapMatKhau);
            this.Controls.Add(this.pn_ToolMenu);
            this.Controls.Add(this.lb_CapLaiMatKhau);
            this.Name = "ucCapLaiMatKhau";
            this.Size = new System.Drawing.Size(798, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).EndInit();
            this.pn_ToolMenu.ResumeLayout(false);
            this.pn_ToolMenu.PerformLayout();
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Account;
        private System.Windows.Forms.Button btn_CapMatKhau;
        private System.Windows.Forms.Panel pn_ToolMenu;
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Label lb_CapLaiMatKhau;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}
