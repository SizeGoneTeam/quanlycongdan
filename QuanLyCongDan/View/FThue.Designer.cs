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
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.btnCongTy = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCCCD
            // 
            this.btnCCCD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCCCD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCCCD.Location = new System.Drawing.Point(118, 511);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(189, 41);
            this.btnCCCD.TabIndex = 21;
            this.btnCCCD.Text = "Xem CCCD";
            this.btnCCCD.UseVisualStyleBackColor = false;
            this.btnCCCD.Click += new System.EventHandler(this.btnCCCD_Click);
            // 
            // txtCongTy
            // 
            this.txtCongTy.AllowDrop = true;
            this.txtCongTy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCongTy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCongTy.Location = new System.Drawing.Point(80, 187);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(514, 30);
            this.txtCongTy.TabIndex = 21;
            this.txtCongTy.Text = "  Tên Công Ty";
            this.txtCongTy.Enter += new System.EventHandler(this.txtCongTy_Enter);
            // 
            // btnCongTy
            // 
            this.btnCongTy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongTy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongTy.Location = new System.Drawing.Point(370, 511);
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.Size = new System.Drawing.Size(182, 41);
            this.btnCongTy.TabIndex = 19;
            this.btnCongTy.Text = "Xem Công Ty";
            this.btnCongTy.UseVisualStyleBackColor = false;
            this.btnCongTy.Click += new System.EventHandler(this.btnCongTy_Click);
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
            // txtIDT
            // 
            this.txtIDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDT.Location = new System.Drawing.Point(80, 239);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.ReadOnly = true;
            this.txtIDT.Size = new System.Drawing.Size(514, 30);
            this.txtIDT.TabIndex = 10;
            this.txtIDT.Text = "  ID Thuế";
            this.txtIDT.Enter += new System.EventHandler(this.txtIDT_Enter);
            // 
            // gvThue
            // 
            this.gvThue.AllowUserToOrderColumns = true;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.Location = new System.Drawing.Point(80, 291);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 24;
            this.gvThue.Size = new System.Drawing.Size(514, 197);
            this.gvThue.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(80, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 604);
            this.panel4.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnCCCD);
            this.panel6.Controls.Add(this.gvThue);
            this.panel6.Controls.Add(this.btnCongTy);
            this.panel6.Controls.Add(this.txtCongTy);
            this.panel6.Controls.Add(this.txtCCCD);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtIDT);
            this.panel6.Location = new System.Drawing.Point(15, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(668, 568);
            this.panel6.TabIndex = 16;
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
            // FThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 678);
            this.Controls.Add(this.panel4);
            this.Name = "FThue";
            this.Text = "FThue";
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Button btnCongTy;
        private System.Windows.Forms.DataGridView gvThue;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.Button btnCCCD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}