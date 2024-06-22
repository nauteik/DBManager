namespace Project_DBManager.UC
{
    partial class formThuThap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_Staff = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkGoogle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Progress = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.btnChonTatCa = new System.Windows.Forms.Button();
            this.btn_BoChonTatCa = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).BeginInit();
            this.SuspendLayout();
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
            this.BrandName,
            this.Rate,
            this.Review,
            this.Category,
            this.Address,
            this.Website,
            this.Phone,
            this.LinkGoogle});
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
            this.dtgv_Staff.Location = new System.Drawing.Point(28, 101);
            this.dtgv_Staff.Name = "dtgv_Staff";
            this.dtgv_Staff.RowHeadersVisible = false;
            this.dtgv_Staff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Staff.Size = new System.Drawing.Size(891, 343);
            this.dtgv_Staff.TabIndex = 10;
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "isChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 30;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrandName.DataPropertyName = "brandName";
            this.BrandName.FillWeight = 120F;
            this.BrandName.HeaderText = "Tên thương hiệu";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.DataPropertyName = "rate";
            this.Rate.FillWeight = 70F;
            this.Rate.HeaderText = "Số sao";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Review
            // 
            this.Review.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Review.DataPropertyName = "review";
            this.Review.FillWeight = 70F;
            this.Review.HeaderText = "Đánh giá";
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Chủ đề";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Website
            // 
            this.Website.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Website.DataPropertyName = "website";
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "phone";
            this.Phone.HeaderText = "SDT";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // LinkGoogle
            // 
            this.LinkGoogle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LinkGoogle.DataPropertyName = "googleURL";
            this.LinkGoogle.HeaderText = "Google";
            this.LinkGoogle.Name = "LinkGoogle";
            this.LinkGoogle.ReadOnly = true;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_Title.Location = new System.Drawing.Point(22, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(727, 33);
            this.lb_Title.TabIndex = 11;
            this.lb_Title.Text = "Đang thu thập thông tin, vui lòng không tắt ứng dụng!";
            // 
            // lb_Progress
            // 
            this.lb_Progress.Font = new System.Drawing.Font("Inter", 11F);
            this.lb_Progress.Location = new System.Drawing.Point(469, 67);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(453, 19);
            this.lb_Progress.TabIndex = 12;
            this.lb_Progress.Text = "Quá trình thu thập:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(35, 456);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(112, 30);
            this.btn_Luu.TabIndex = 13;
            this.btn_Luu.Text = "Lưu vào hệ thống";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cb_PhanLoai
            // 
            this.cb_PhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PhanLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_PhanLoai.Font = new System.Drawing.Font("Inter", 10F);
            this.cb_PhanLoai.FormattingEnabled = true;
            this.cb_PhanLoai.Items.AddRange(new object[] {
            "Ăn uống",
            "Mua sắm",
            "Làm đẹp",
            "Du lịch",
            "Giải trí",
            "Quà tặng"});
            this.cb_PhanLoai.Location = new System.Drawing.Point(346, 65);
            this.cb_PhanLoai.Name = "cb_PhanLoai";
            this.cb_PhanLoai.Size = new System.Drawing.Size(113, 24);
            this.cb_PhanLoai.TabIndex = 21;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(263, 67);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(78, 19);
            this.lbDepartment.TabIndex = 22;
            this.lbDepartment.Text = "Phân loại";
            // 
            // btnChonTatCa
            // 
            this.btnChonTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btnChonTatCa.FlatAppearance.BorderSize = 0;
            this.btnChonTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTatCa.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTatCa.Location = new System.Drawing.Point(35, 62);
            this.btnChonTatCa.Name = "btnChonTatCa";
            this.btnChonTatCa.Size = new System.Drawing.Size(90, 30);
            this.btnChonTatCa.TabIndex = 13;
            this.btnChonTatCa.Text = "Chọn tất cả";
            this.btnChonTatCa.UseVisualStyleBackColor = false;
            this.btnChonTatCa.Click += new System.EventHandler(this.btnChonTatCa_Click);
            // 
            // btn_BoChonTatCa
            // 
            this.btn_BoChonTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BoChonTatCa.FlatAppearance.BorderSize = 0;
            this.btn_BoChonTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BoChonTatCa.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BoChonTatCa.Location = new System.Drawing.Point(135, 62);
            this.btn_BoChonTatCa.Name = "btn_BoChonTatCa";
            this.btn_BoChonTatCa.Size = new System.Drawing.Size(111, 30);
            this.btn_BoChonTatCa.TabIndex = 13;
            this.btn_BoChonTatCa.Text = "Hủy chọn tất cả";
            this.btn_BoChonTatCa.UseVisualStyleBackColor = false;
            this.btn_BoChonTatCa.Click += new System.EventHandler(this.btn_BoChonTatCa_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(173, 456);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(148, 30);
            this.btn_Load.TabIndex = 13;
            this.btn_Load.Text = "Load dữ liệu có sẵn";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // formThuThap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(944, 506);
            this.Controls.Add(this.cb_PhanLoai);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.btn_BoChonTatCa);
            this.Controls.Add(this.btnChonTatCa);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Progress);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.dtgv_Staff);
            this.Name = "formThuThap";
            this.Text = "Thu thập thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Staff;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Progress;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cb_PhanLoai;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Button btnChonTatCa;
        private System.Windows.Forms.Button btn_BoChonTatCa;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkGoogle;
    }
}