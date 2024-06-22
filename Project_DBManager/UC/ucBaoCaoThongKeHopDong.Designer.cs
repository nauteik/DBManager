namespace Project_DBManager.UC
{
    partial class ucBaoCaoThongKeHopDong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_BaoCaoThongKeHopDong = new System.Windows.Forms.TextBox();
            this.btn_TaoBaoCao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Chon = new System.Windows.Forms.ComboBox();
            this.cb_ThongKeTheo = new System.Windows.Forms.ComboBox();
            this.lb_ThongKeTheo = new System.Windows.Forms.Label();
            this.lb_Chon = new System.Windows.Forms.Label();
            this.lb_ChonNgayKetThuc = new System.Windows.Forms.Label();
            this.lb_ChonNgayBatDau = new System.Windows.Forms.Label();
            this.dtpk_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpk_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.c_HopDong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_BaoCaoThongKeHopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 3;
            // 
            // tb_BaoCaoThongKeHopDong
            // 
            this.tb_BaoCaoThongKeHopDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_BaoCaoThongKeHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_BaoCaoThongKeHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BaoCaoThongKeHopDong.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BaoCaoThongKeHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tb_BaoCaoThongKeHopDong.Location = new System.Drawing.Point(25, 9);
            this.tb_BaoCaoThongKeHopDong.Name = "tb_BaoCaoThongKeHopDong";
            this.tb_BaoCaoThongKeHopDong.ReadOnly = true;
            this.tb_BaoCaoThongKeHopDong.Size = new System.Drawing.Size(374, 33);
            this.tb_BaoCaoThongKeHopDong.TabIndex = 0;
            this.tb_BaoCaoThongKeHopDong.Text = "Báo cáo thống kê hợp đồng";
            // 
            // btn_TaoBaoCao
            // 
            this.btn_TaoBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_TaoBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_TaoBaoCao.FlatAppearance.BorderSize = 0;
            this.btn_TaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoBaoCao.Location = new System.Drawing.Point(112, 525);
            this.btn_TaoBaoCao.Name = "btn_TaoBaoCao";
            this.btn_TaoBaoCao.Size = new System.Drawing.Size(150, 30);
            this.btn_TaoBaoCao.TabIndex = 5;
            this.btn_TaoBaoCao.Text = "Tạo báo cáo";
            this.btn_TaoBaoCao.UseVisualStyleBackColor = false;
            this.btn_TaoBaoCao.Click += new System.EventHandler(this.btn_TaoBaoCao_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.cb_Chon);
            this.panel2.Controls.Add(this.cb_ThongKeTheo);
            this.panel2.Controls.Add(this.lb_ThongKeTheo);
            this.panel2.Controls.Add(this.lb_Chon);
            this.panel2.Controls.Add(this.lb_ChonNgayKetThuc);
            this.panel2.Controls.Add(this.lb_ChonNgayBatDau);
            this.panel2.Controls.Add(this.dtpk_NgayKetThuc);
            this.panel2.Controls.Add(this.dtpk_NgayBatDau);
            this.panel2.Location = new System.Drawing.Point(25, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 425);
            this.panel2.TabIndex = 6;
            // 
            // cb_Chon
            // 
            this.cb_Chon.BackColor = System.Drawing.Color.White;
            this.cb_Chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Chon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Chon.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Chon.FormattingEnabled = true;
            this.cb_Chon.Location = new System.Drawing.Point(50, 350);
            this.cb_Chon.Name = "cb_Chon";
            this.cb_Chon.Size = new System.Drawing.Size(225, 27);
            this.cb_Chon.TabIndex = 9;
            // 
            // cb_ThongKeTheo
            // 
            this.cb_ThongKeTheo.BackColor = System.Drawing.Color.White;
            this.cb_ThongKeTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ThongKeTheo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ThongKeTheo.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ThongKeTheo.FormattingEnabled = true;
            this.cb_ThongKeTheo.Items.AddRange(new object[] {
            "Người tạo",
            "Trạng thái"});
            this.cb_ThongKeTheo.Location = new System.Drawing.Point(50, 250);
            this.cb_ThongKeTheo.Name = "cb_ThongKeTheo";
            this.cb_ThongKeTheo.Size = new System.Drawing.Size(225, 27);
            this.cb_ThongKeTheo.TabIndex = 8;
            this.cb_ThongKeTheo.SelectedIndexChanged += new System.EventHandler(this.cb_ThongKeTheo_SelectedIndexChanged);
            // 
            // lb_ThongKeTheo
            // 
            this.lb_ThongKeTheo.AutoSize = true;
            this.lb_ThongKeTheo.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongKeTheo.Location = new System.Drawing.Point(50, 225);
            this.lb_ThongKeTheo.Name = "lb_ThongKeTheo";
            this.lb_ThongKeTheo.Size = new System.Drawing.Size(119, 19);
            this.lb_ThongKeTheo.TabIndex = 7;
            this.lb_ThongKeTheo.Text = "Thống kê theo";
            // 
            // lb_Chon
            // 
            this.lb_Chon.AutoSize = true;
            this.lb_Chon.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Chon.Location = new System.Drawing.Point(50, 325);
            this.lb_Chon.Name = "lb_Chon";
            this.lb_Chon.Size = new System.Drawing.Size(49, 19);
            this.lb_Chon.TabIndex = 5;
            this.lb_Chon.Text = "Chọn";
            // 
            // lb_ChonNgayKetThuc
            // 
            this.lb_ChonNgayKetThuc.AutoSize = true;
            this.lb_ChonNgayKetThuc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonNgayKetThuc.Location = new System.Drawing.Point(50, 125);
            this.lb_ChonNgayKetThuc.Name = "lb_ChonNgayKetThuc";
            this.lb_ChonNgayKetThuc.Size = new System.Drawing.Size(158, 19);
            this.lb_ChonNgayKetThuc.TabIndex = 4;
            this.lb_ChonNgayKetThuc.Text = "Chọn ngày kết thúc";
            // 
            // lb_ChonNgayBatDau
            // 
            this.lb_ChonNgayBatDau.AutoSize = true;
            this.lb_ChonNgayBatDau.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonNgayBatDau.Location = new System.Drawing.Point(50, 25);
            this.lb_ChonNgayBatDau.Name = "lb_ChonNgayBatDau";
            this.lb_ChonNgayBatDau.Size = new System.Drawing.Size(154, 19);
            this.lb_ChonNgayBatDau.TabIndex = 3;
            this.lb_ChonNgayBatDau.Text = "Chọn ngày bắt đầu";
            // 
            // dtpk_NgayKetThuc
            // 
            this.dtpk_NgayKetThuc.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayKetThuc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayKetThuc.Location = new System.Drawing.Point(50, 150);
            this.dtpk_NgayKetThuc.Name = "dtpk_NgayKetThuc";
            this.dtpk_NgayKetThuc.Size = new System.Drawing.Size(225, 27);
            this.dtpk_NgayKetThuc.TabIndex = 1;
            // 
            // dtpk_NgayBatDau
            // 
            this.dtpk_NgayBatDau.CustomFormat = "dd-MM-yyyy";
            this.dtpk_NgayBatDau.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NgayBatDau.Location = new System.Drawing.Point(50, 50);
            this.dtpk_NgayBatDau.Name = "dtpk_NgayBatDau";
            this.dtpk_NgayBatDau.Size = new System.Drawing.Size(225, 27);
            this.dtpk_NgayBatDau.TabIndex = 0;
            // 
            // c_HopDong
            // 
            this.c_HopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_HopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            chartArea1.Name = "ChartArea1";
            this.c_HopDong.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c_HopDong.Legends.Add(legend1);
            this.c_HopDong.Location = new System.Drawing.Point(375, 75);
            this.c_HopDong.Name = "c_HopDong";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng hợp đồng";
            this.c_HopDong.Series.Add(series1);
            this.c_HopDong.Size = new System.Drawing.Size(398, 425);
            this.c_HopDong.TabIndex = 10;
            this.c_HopDong.Text = "chart1";
            // 
            // ucBaoCaoThongKeHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.c_HopDong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_TaoBaoCao);
            this.Controls.Add(this.panel1);
            this.Name = "ucBaoCaoThongKeHopDong";
            this.Size = new System.Drawing.Size(798, 577);
            this.Load += new System.EventHandler(this.ucBaoCaoThongKeHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_HopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_BaoCaoThongKeHopDong;
        private System.Windows.Forms.Button btn_TaoBaoCao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Chon;
        private System.Windows.Forms.ComboBox cb_ThongKeTheo;
        private System.Windows.Forms.Label lb_ThongKeTheo;
        private System.Windows.Forms.Label lb_Chon;
        private System.Windows.Forms.Label lb_ChonNgayKetThuc;
        private System.Windows.Forms.Label lb_ChonNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpk_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpk_NgayBatDau;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_HopDong;
    }
}
