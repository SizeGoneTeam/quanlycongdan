namespace QuanLyCongDan.View
{
    partial class FThue
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
            this.btnCCCD = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNopThue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChuaDongThue = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCCCD
            // 
            this.btnCCCD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCCCD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCCCD.Location = new System.Drawing.Point(80, 504);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(189, 41);
            this.btnCCCD.TabIndex = 21;
            this.btnCCCD.Text = "Xem Thuế";
            this.btnCCCD.UseVisualStyleBackColor = false;
            this.btnCCCD.Click += new System.EventHandler(this.btnCCCD_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AllowDrop = true;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCCCD.Location = new System.Drawing.Point(80, 135);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(514, 30);
            this.txtCCCD.TabIndex = 14;
            this.txtCCCD.Text = "  CCCD";
            this.txtCCCD.Enter += new System.EventHandler(this.txtCCCD_Enter);
            // 
            // gvThue
            // 
            this.gvThue.AllowUserToOrderColumns = true;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.Location = new System.Drawing.Point(80, 187);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 24;
            this.gvThue.Size = new System.Drawing.Size(514, 301);
            this.gvThue.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(8, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 604);
            this.panel4.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnNopThue);
            this.panel6.Controls.Add(this.btnCCCD);
            this.panel6.Controls.Add(this.gvThue);
            this.panel6.Controls.Add(this.txtCCCD);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(15, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(668, 568);
            this.panel6.TabIndex = 16;
            // 
            // btnNopThue
            // 
            this.btnNopThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNopThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNopThue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNopThue.Location = new System.Drawing.Point(405, 504);
            this.btnNopThue.Name = "btnNopThue";
            this.btnNopThue.Size = new System.Drawing.Size(189, 41);
            this.btnNopThue.TabIndex = 22;
            this.btnNopThue.Text = "Nộp Thuế";
            this.btnNopThue.UseVisualStyleBackColor = false;
            this.btnNopThue.Click += new System.EventHandler(this.btnNopThue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(145, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Điền Số CCCD Để Tra Khảo Thông Tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(238, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông Tin Thuế";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(822, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 604);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnChuaDongThue);
            this.panel2.Controls.Add(this.dgvDanhSach);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 568);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnChuaDongThue
            // 
            this.btnChuaDongThue.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChuaDongThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuaDongThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuaDongThue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChuaDongThue.Location = new System.Drawing.Point(316, 504);
            this.btnChuaDongThue.Name = "btnChuaDongThue";
            this.btnChuaDongThue.Size = new System.Drawing.Size(278, 41);
            this.btnChuaDongThue.TabIndex = 21;
            this.btnChuaDongThue.Text = "Công dân chưa đóng thuế";
            this.btnChuaDongThue.UseVisualStyleBackColor = false;
            this.btnChuaDongThue.Click += new System.EventHandler(this.btnChuaDongThue_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToOrderColumns = true;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(80, 166);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(514, 322);
            this.dgvDanhSach.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(238, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Sách";
            // 
            // FThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1577, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "FThue";
            this.Text = "FThue";
            this.Load += new System.EventHandler(this.FThue_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.DataGridView gvThue;
        private System.Windows.Forms.Button btnCCCD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNopThue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChuaDongThue;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label3;
    }
}