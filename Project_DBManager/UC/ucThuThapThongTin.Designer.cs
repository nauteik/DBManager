namespace Project_DBManager.UC
{
    partial class ucThuThapThongTin
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
            this.lb_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.pn_Map = new System.Windows.Forms.Panel();
            this.pn_TrucDoc = new System.Windows.Forms.Panel();
            this.tb_TrucDoc = new System.Windows.Forms.TextBox();
            this.lb_TrucDoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ZoomLevel = new System.Windows.Forms.Label();
            this.pn_ZoomLevel = new System.Windows.Forms.Panel();
            this.tb_ZoomLevel = new System.Windows.Forms.TextBox();
            this.pn_TrucNgang = new System.Windows.Forms.Panel();
            this.tb_TrucNgang = new System.Windows.Forms.TextBox();
            this.pn_NoiDungThuThap = new System.Windows.Forms.Panel();
            this.tb_NoiDungThuThap = new System.Windows.Forms.TextBox();
            this.lb_NoiDungThuThap = new System.Windows.Forms.Label();
            this.btn_ThuThap = new System.Windows.Forms.Button();
            this.pn_TrucDoc.SuspendLayout();
            this.pn_ZoomLevel.SuspendLayout();
            this.pn_TrucNgang.SuspendLayout();
            this.pn_NoiDungThuThap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ThongTinNhanVien
            // 
            this.lb_ThongTinNhanVien.AutoSize = true;
            this.lb_ThongTinNhanVien.Font = new System.Drawing.Font("Inter Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_ThongTinNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.lb_ThongTinNhanVien.Location = new System.Drawing.Point(18, 37);
            this.lb_ThongTinNhanVien.Name = "lb_ThongTinNhanVien";
            this.lb_ThongTinNhanVien.Size = new System.Drawing.Size(261, 33);
            this.lb_ThongTinNhanVien.TabIndex = 13;
            this.lb_ThongTinNhanVien.Text = "Thu thập thông tin";
            // 
            // pn_Map
            // 
            this.pn_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Map.BackColor = System.Drawing.Color.Black;
            this.pn_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Map.Location = new System.Drawing.Point(266, 95);
            this.pn_Map.Name = "pn_Map";
            this.pn_Map.Size = new System.Drawing.Size(511, 468);
            this.pn_Map.TabIndex = 14;
            // 
            // pn_TrucDoc
            // 
            this.pn_TrucDoc.BackColor = System.Drawing.Color.White;
            this.pn_TrucDoc.Controls.Add(this.tb_TrucDoc);
            this.pn_TrucDoc.Location = new System.Drawing.Point(146, 117);
            this.pn_TrucDoc.Name = "pn_TrucDoc";
            this.pn_TrucDoc.Size = new System.Drawing.Size(94, 30);
            this.pn_TrucDoc.TabIndex = 15;
            // 
            // tb_TrucDoc
            // 
            this.tb_TrucDoc.BackColor = System.Drawing.Color.White;
            this.tb_TrucDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TrucDoc.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrucDoc.ForeColor = System.Drawing.Color.Black;
            this.tb_TrucDoc.Location = new System.Drawing.Point(8, 7);
            this.tb_TrucDoc.Name = "tb_TrucDoc";
            this.tb_TrucDoc.ReadOnly = true;
            this.tb_TrucDoc.Size = new System.Drawing.Size(80, 17);
            this.tb_TrucDoc.TabIndex = 0;
            // 
            // lb_TrucDoc
            // 
            this.lb_TrucDoc.AutoSize = true;
            this.lb_TrucDoc.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrucDoc.Location = new System.Drawing.Point(146, 95);
            this.lb_TrucDoc.Name = "lb_TrucDoc";
            this.lb_TrucDoc.Size = new System.Drawing.Size(76, 19);
            this.lb_TrucDoc.TabIndex = 16;
            this.lb_TrucDoc.Text = "Trục dọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Trục ngang";
            // 
            // lb_ZoomLevel
            // 
            this.lb_ZoomLevel.AutoSize = true;
            this.lb_ZoomLevel.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ZoomLevel.Location = new System.Drawing.Point(28, 165);
            this.lb_ZoomLevel.Name = "lb_ZoomLevel";
            this.lb_ZoomLevel.Size = new System.Drawing.Size(98, 19);
            this.lb_ZoomLevel.TabIndex = 18;
            this.lb_ZoomLevel.Text = "Zoom Level";
            // 
            // pn_ZoomLevel
            // 
            this.pn_ZoomLevel.BackColor = System.Drawing.Color.White;
            this.pn_ZoomLevel.Controls.Add(this.tb_ZoomLevel);
            this.pn_ZoomLevel.Location = new System.Drawing.Point(28, 187);
            this.pn_ZoomLevel.Name = "pn_ZoomLevel";
            this.pn_ZoomLevel.Size = new System.Drawing.Size(212, 30);
            this.pn_ZoomLevel.TabIndex = 17;
            // 
            // tb_ZoomLevel
            // 
            this.tb_ZoomLevel.BackColor = System.Drawing.Color.White;
            this.tb_ZoomLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ZoomLevel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZoomLevel.ForeColor = System.Drawing.Color.Black;
            this.tb_ZoomLevel.Location = new System.Drawing.Point(8, 7);
            this.tb_ZoomLevel.Name = "tb_ZoomLevel";
            this.tb_ZoomLevel.ReadOnly = true;
            this.tb_ZoomLevel.Size = new System.Drawing.Size(100, 17);
            this.tb_ZoomLevel.TabIndex = 0;
            // 
            // pn_TrucNgang
            // 
            this.pn_TrucNgang.BackColor = System.Drawing.Color.White;
            this.pn_TrucNgang.Controls.Add(this.tb_TrucNgang);
            this.pn_TrucNgang.Location = new System.Drawing.Point(28, 117);
            this.pn_TrucNgang.Name = "pn_TrucNgang";
            this.pn_TrucNgang.Size = new System.Drawing.Size(94, 30);
            this.pn_TrucNgang.TabIndex = 16;
            // 
            // tb_TrucNgang
            // 
            this.tb_TrucNgang.BackColor = System.Drawing.Color.White;
            this.tb_TrucNgang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TrucNgang.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrucNgang.ForeColor = System.Drawing.Color.Black;
            this.tb_TrucNgang.Location = new System.Drawing.Point(7, 7);
            this.tb_TrucNgang.Name = "tb_TrucNgang";
            this.tb_TrucNgang.ReadOnly = true;
            this.tb_TrucNgang.Size = new System.Drawing.Size(80, 17);
            this.tb_TrucNgang.TabIndex = 0;
            // 
            // pn_NoiDungThuThap
            // 
            this.pn_NoiDungThuThap.BackColor = System.Drawing.Color.White;
            this.pn_NoiDungThuThap.Controls.Add(this.tb_NoiDungThuThap);
            this.pn_NoiDungThuThap.Location = new System.Drawing.Point(32, 258);
            this.pn_NoiDungThuThap.Name = "pn_NoiDungThuThap";
            this.pn_NoiDungThuThap.Size = new System.Drawing.Size(212, 30);
            this.pn_NoiDungThuThap.TabIndex = 19;
            // 
            // tb_NoiDungThuThap
            // 
            this.tb_NoiDungThuThap.BackColor = System.Drawing.Color.White;
            this.tb_NoiDungThuThap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoiDungThuThap.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoiDungThuThap.ForeColor = System.Drawing.Color.Black;
            this.tb_NoiDungThuThap.Location = new System.Drawing.Point(8, 7);
            this.tb_NoiDungThuThap.Name = "tb_NoiDungThuThap";
            this.tb_NoiDungThuThap.Size = new System.Drawing.Size(195, 17);
            this.tb_NoiDungThuThap.TabIndex = 0;
            // 
            // lb_NoiDungThuThap
            // 
            this.lb_NoiDungThuThap.AutoSize = true;
            this.lb_NoiDungThuThap.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoiDungThuThap.Location = new System.Drawing.Point(32, 236);
            this.lb_NoiDungThuThap.Name = "lb_NoiDungThuThap";
            this.lb_NoiDungThuThap.Size = new System.Drawing.Size(146, 19);
            this.lb_NoiDungThuThap.TabIndex = 20;
            this.lb_NoiDungThuThap.Text = "Nội dung thu thập";
            // 
            // btn_ThuThap
            // 
            this.btn_ThuThap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ThuThap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.btn_ThuThap.FlatAppearance.BorderSize = 0;
            this.btn_ThuThap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThuThap.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThuThap.Location = new System.Drawing.Point(32, 317);
            this.btn_ThuThap.Name = "btn_ThuThap";
            this.btn_ThuThap.Size = new System.Drawing.Size(112, 30);
            this.btn_ThuThap.TabIndex = 9;
            this.btn_ThuThap.Text = "Thu thập";
            this.btn_ThuThap.UseVisualStyleBackColor = false;
            this.btn_ThuThap.Click += new System.EventHandler(this.btn_ThuThap_Click);
            // 
            // ucThuThapThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_ThuThap);
            this.Controls.Add(this.pn_NoiDungThuThap);
            this.Controls.Add(this.lb_NoiDungThuThap);
            this.Controls.Add(this.pn_TrucNgang);
            this.Controls.Add(this.pn_ZoomLevel);
            this.Controls.Add(this.pn_TrucDoc);
            this.Controls.Add(this.lb_ZoomLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TrucDoc);
            this.Controls.Add(this.pn_Map);
            this.Controls.Add(this.lb_ThongTinNhanVien);
            this.Name = "ucThuThapThongTin";
            this.Size = new System.Drawing.Size(798, 577);
            this.pn_TrucDoc.ResumeLayout(false);
            this.pn_TrucDoc.PerformLayout();
            this.pn_ZoomLevel.ResumeLayout(false);
            this.pn_ZoomLevel.PerformLayout();
            this.pn_TrucNgang.ResumeLayout(false);
            this.pn_TrucNgang.PerformLayout();
            this.pn_NoiDungThuThap.ResumeLayout(false);
            this.pn_NoiDungThuThap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ThongTinNhanVien;
        private System.Windows.Forms.Panel pn_Map;
        private System.Windows.Forms.Panel pn_TrucDoc;
        private System.Windows.Forms.TextBox tb_TrucDoc;
        private System.Windows.Forms.Label lb_TrucDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ZoomLevel;
        private System.Windows.Forms.Panel pn_ZoomLevel;
        private System.Windows.Forms.TextBox tb_ZoomLevel;
        private System.Windows.Forms.Panel pn_TrucNgang;
        private System.Windows.Forms.TextBox tb_TrucNgang;
        private System.Windows.Forms.Panel pn_NoiDungThuThap;
        private System.Windows.Forms.TextBox tb_NoiDungThuThap;
        private System.Windows.Forms.Label lb_NoiDungThuThap;
        private System.Windows.Forms.Button btn_ThuThap;
    }
}
