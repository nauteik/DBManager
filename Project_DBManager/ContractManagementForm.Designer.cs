namespace Project_DBManager
{
    partial class ContractManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbQLHD = new System.Windows.Forms.TextBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbSignedDate = new System.Windows.Forms.TextBox();
            this.tbBrandName = new System.Windows.Forms.TextBox();
            this.tbContractID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 590);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 30);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.panel4.Controls.Add(this.tbQLHD);
            this.panel4.Location = new System.Drawing.Point(150, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 40);
            this.panel4.TabIndex = 2;
            // 
            // tbQLHD
            // 
            this.tbQLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.tbQLHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQLHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(78)))));
            this.tbQLHD.Location = new System.Drawing.Point(300, 6);
            this.tbQLHD.Name = "tbQLHD";
            this.tbQLHD.Size = new System.Drawing.Size(295, 27);
            this.tbQLHD.TabIndex = 0;
            this.tbQLHD.Text = "THÔNG TIN HỢP ĐỒNG";
            this.tbQLHD.TextChanged += new System.EventHandler(this.tbQLHD_TextChanged);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeColumns = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersHeight = 50;
            this.dtgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.GridColor = System.Drawing.Color.Black;
            this.dtgv.Location = new System.Drawing.Point(175, 155);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 50;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv.ShowCellToolTips = false;
            this.dtgv.Size = new System.Drawing.Size(845, 460);
            this.dtgv.TabIndex = 3;
            this.dtgv.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.tbDuration);
            this.panel5.Controls.Add(this.tbSignedDate);
            this.panel5.Controls.Add(this.tbBrandName);
            this.panel5.Controls.Add(this.tbContractID);
            this.panel5.Location = new System.Drawing.Point(175, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(845, 40);
            this.panel5.TabIndex = 4;
            // 
            // tbDuration
            // 
            this.tbDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.Location = new System.Drawing.Point(690, 10);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(100, 21);
            this.tbDuration.TabIndex = 3;
            this.tbDuration.Text = "Duration";
            this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSignedDate
            // 
            this.tbSignedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSignedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignedDate.Location = new System.Drawing.Point(480, 10);
            this.tbSignedDate.Name = "tbSignedDate";
            this.tbSignedDate.Size = new System.Drawing.Size(105, 21);
            this.tbSignedDate.TabIndex = 2;
            this.tbSignedDate.Text = "Signed Date";
            this.tbSignedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBrandName
            // 
            this.tbBrandName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrandName.Location = new System.Drawing.Point(265, 10);
            this.tbBrandName.Name = "tbBrandName";
            this.tbBrandName.Size = new System.Drawing.Size(110, 21);
            this.tbBrandName.TabIndex = 1;
            this.tbBrandName.Text = "Brand Name";
            this.tbBrandName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContractID
            // 
            this.tbContractID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContractID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContractID.Location = new System.Drawing.Point(50, 10);
            this.tbContractID.Name = "tbContractID";
            this.tbContractID.Size = new System.Drawing.Size(100, 21);
            this.tbContractID.TabIndex = 0;
            this.tbContractID.Text = "Contract ID";
            this.tbContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbContractID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContractManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1045, 641);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContractManagementForm";
            this.Text = "ContractManagementForm";
            this.Load += new System.EventHandler(this.ContractManagementForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbContractID;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbSignedDate;
        private System.Windows.Forms.TextBox tbBrandName;
        private System.Windows.Forms.TextBox tbQLHD;
    }
}