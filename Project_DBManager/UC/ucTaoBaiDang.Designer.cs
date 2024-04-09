namespace Project_DBManager
{
    partial class ucTaoBaiDang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_TaoBaiDang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TaoBaiDang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_TaoBaiDang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 1;
            // 
            // tb_TaoBaiDang
            // 
            this.tb_TaoBaiDang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.tb_TaoBaiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TaoBaiDang.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaoBaiDang.Location = new System.Drawing.Point(25, 12);
            this.tb_TaoBaiDang.Name = "tb_TaoBaiDang";
            this.tb_TaoBaiDang.Size = new System.Drawing.Size(139, 26);
            this.tb_TaoBaiDang.TabIndex = 0;
            this.tb_TaoBaiDang.Text = "Tạo Bài Đăng";
            this.tb_TaoBaiDang.TextChanged += new System.EventHandler(this.tb_ThongTinHopDong_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.Location = new System.Drawing.Point(24, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 477);
            this.panel2.TabIndex = 2;
            // 
            // btn_TaoBaiDang
            // 
            this.btn_TaoBaiDang.Location = new System.Drawing.Point(346, 533);
            this.btn_TaoBaiDang.Name = "btn_TaoBaiDang";
            this.btn_TaoBaiDang.Size = new System.Drawing.Size(142, 27);
            this.btn_TaoBaiDang.TabIndex = 3;
            this.btn_TaoBaiDang.Text = "Tạo bài đăng";
            this.btn_TaoBaiDang.UseVisualStyleBackColor = true;
            // 
            // TaoBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.btn_TaoBaiDang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaoBaiDang";
            this.Size = new System.Drawing.Size(798, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_TaoBaiDang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TaoBaiDang;
    }
}
