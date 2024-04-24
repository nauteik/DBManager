namespace Project_DBManager
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
            this.lb_PhanCongCongViec = new System.Windows.Forms.Label();
            this.pn_GiaoViec = new System.Windows.Forms.Panel();
            this.lb_ChonViTri = new System.Windows.Forms.Label();
            this.pn_ChonViTri = new System.Windows.Forms.Panel();
            this.cb_ViTri = new System.Windows.Forms.ComboBox();
            this.lb_TenCongViec = new System.Windows.Forms.Label();
            this.pn_TenCongViec = new System.Windows.Forms.Panel();
            this.tb_TenCongViec = new System.Windows.Forms.TextBox();
            this.dtpk_Deadline = new System.Windows.Forms.DateTimePicker();
            this.lb_Deadline = new System.Windows.Forms.Label();
            this.lb_GhiChu = new System.Windows.Forms.Label();
            this.pn_GhiChu = new System.Windows.Forms.Panel();
            this.tb_GhiChu = new System.Windows.Forms.TextBox();
            this.btn_TaoCongViec = new System.Windows.Forms.Button();
            this.pn_GiaoViec.SuspendLayout();
            this.pn_ChonViTri.SuspendLayout();
            this.pn_TenCongViec.SuspendLayout();
            this.pn_GhiChu.SuspendLayout();
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
            this.pn_GiaoViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.pn_GiaoViec.Controls.Add(this.lb_GhiChu);
            this.pn_GiaoViec.Controls.Add(this.pn_GhiChu);
            this.pn_GiaoViec.Controls.Add(this.dtpk_Deadline);
            this.pn_GiaoViec.Controls.Add(this.lb_Deadline);
            this.pn_GiaoViec.Controls.Add(this.lb_TenCongViec);
            this.pn_GiaoViec.Controls.Add(this.pn_TenCongViec);
            this.pn_GiaoViec.Controls.Add(this.lb_ChonViTri);
            this.pn_GiaoViec.Controls.Add(this.pn_ChonViTri);
            this.pn_GiaoViec.Location = new System.Drawing.Point(23, 65);
            this.pn_GiaoViec.Name = "pn_GiaoViec";
            this.pn_GiaoViec.Size = new System.Drawing.Size(359, 389);
            this.pn_GiaoViec.TabIndex = 3;
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
            // lb_GhiChu
            // 
            this.lb_GhiChu.AutoSize = true;
            this.lb_GhiChu.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GhiChu.Location = new System.Drawing.Point(19, 225);
            this.lb_GhiChu.Name = "lb_GhiChu";
            this.lb_GhiChu.Size = new System.Drawing.Size(66, 19);
            this.lb_GhiChu.TabIndex = 43;
            this.lb_GhiChu.Text = "Ghi chú";
            // 
            // pn_GhiChu
            // 
            this.pn_GhiChu.BackColor = System.Drawing.Color.White;
            this.pn_GhiChu.Controls.Add(this.tb_GhiChu);
            this.pn_GhiChu.Location = new System.Drawing.Point(19, 247);
            this.pn_GhiChu.Name = "pn_GhiChu";
            this.pn_GhiChu.Size = new System.Drawing.Size(226, 124);
            this.pn_GhiChu.TabIndex = 42;
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.BackColor = System.Drawing.Color.White;
            this.tb_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GhiChu.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GhiChu.ForeColor = System.Drawing.Color.Black;
            this.tb_GhiChu.Location = new System.Drawing.Point(6, 7);
            this.tb_GhiChu.Multiline = true;
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.Size = new System.Drawing.Size(210, 110);
            this.tb_GhiChu.TabIndex = 2;
            // 
            // btn_TaoCongViec
            // 
            this.btn_TaoCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_TaoCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoCongViec.FlatAppearance.BorderSize = 0;
            this.btn_TaoCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoCongViec.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoCongViec.Location = new System.Drawing.Point(42, 489);
            this.btn_TaoCongViec.Name = "btn_TaoCongViec";
            this.btn_TaoCongViec.Size = new System.Drawing.Size(112, 30);
            this.btn_TaoCongViec.TabIndex = 44;
            this.btn_TaoCongViec.Text = "Tạo công việc";
            this.btn_TaoCongViec.UseVisualStyleBackColor = false;
            this.btn_TaoCongViec.Click += new System.EventHandler(this.btn_TaoCongViec_Click);
            // 
            // ucPhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_TaoCongViec);
            this.Controls.Add(this.pn_GiaoViec);
            this.Controls.Add(this.lb_PhanCongCongViec);
            this.Name = "ucPhanCongCongViec";
            this.Size = new System.Drawing.Size(798, 577);
            this.pn_GiaoViec.ResumeLayout(false);
            this.pn_GiaoViec.PerformLayout();
            this.pn_ChonViTri.ResumeLayout(false);
            this.pn_TenCongViec.ResumeLayout(false);
            this.pn_TenCongViec.PerformLayout();
            this.pn_GhiChu.ResumeLayout(false);
            this.pn_GhiChu.PerformLayout();
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
        private System.Windows.Forms.Label lb_GhiChu;
        private System.Windows.Forms.Panel pn_GhiChu;
        private System.Windows.Forms.TextBox tb_GhiChu;
        private System.Windows.Forms.Button btn_TaoCongViec;
    }
}
