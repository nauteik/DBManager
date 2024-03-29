namespace Project_DBManager
{
    partial class ThongTinHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ThongTinHopDong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaiXuong = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cb_SapXep = new System.Windows.Forms.ComboBox();
            this.lb_TaiXuong = new System.Windows.Forms.Label();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.lb_SapXep = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
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
            this.tb_ThongTinHopDong.Text = "Thông Tin Hợp Đồng";
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
            this.btn_TaiXuong.Location = new System.Drawing.Point(685, 7);
            this.btn_TaiXuong.Name = "btn_TaiXuong";
            this.btn_TaiXuong.Size = new System.Drawing.Size(35, 35);
            this.btn_TaiXuong.TabIndex = 7;
            this.btn_TaiXuong.UseVisualStyleBackColor = true;
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
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.NullValue = "0";
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle63;
            this.dtgv.Enabled = false;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dtgv.Location = new System.Drawing.Point(25, 125);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Inter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle65;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv.ShowCellErrors = false;
            this.dtgv.ShowCellToolTips = false;
            this.dtgv.ShowEditingIcon = false;
            this.dtgv.ShowRowErrors = false;
            this.dtgv.Size = new System.Drawing.Size(750, 425);
            this.dtgv.TabIndex = 2;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ThongTinHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinHopDong";
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
        private System.Windows.Forms.DataGridView dtgv;
    }
}
