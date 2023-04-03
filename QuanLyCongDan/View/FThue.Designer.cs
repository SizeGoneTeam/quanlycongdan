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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCCCD = new System.Windows.Forms.Button();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.btnCongTy = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCCCD);
            this.panel1.Controls.Add(this.lblCongTy);
            this.panel1.Controls.Add(this.txtCongTy);
            this.panel1.Controls.Add(this.lblCCCD);
            this.panel1.Controls.Add(this.btnCongTy);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIDT);
            this.panel1.Location = new System.Drawing.Point(42, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 288);
            this.panel1.TabIndex = 20;
            // 
            // btnCCCD
            // 
            this.btnCCCD.Location = new System.Drawing.Point(19, 239);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(104, 34);
            this.btnCCCD.TabIndex = 21;
            this.btnCCCD.Text = "Xem CCCD";
            this.btnCCCD.UseVisualStyleBackColor = true;
            this.btnCCCD.Click += new System.EventHandler(this.btnCCCD_Click);
            // 
            // lblCongTy
            // 
            this.lblCongTy.AllowDrop = true;
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Location = new System.Drawing.Point(16, 73);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(58, 16);
            this.lblCongTy.TabIndex = 20;
            this.lblCongTy.Text = "Công Ty";
            // 
            // txtCongTy
            // 
            this.txtCongTy.AllowDrop = true;
            this.txtCongTy.Location = new System.Drawing.Point(115, 73);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(230, 22);
            this.txtCongTy.TabIndex = 21;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AllowDrop = true;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(16, 39);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 13;
            this.lblCCCD.Text = "CCCD";
            // 
            // btnCongTy
            // 
            this.btnCongTy.Location = new System.Drawing.Point(241, 239);
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.Size = new System.Drawing.Size(141, 34);
            this.btnCongTy.TabIndex = 19;
            this.btnCongTy.Text = "Xem Công Ty";
            this.btnCongTy.UseVisualStyleBackColor = true;
            this.btnCongTy.Click += new System.EventHandler(this.btnCongTy_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AllowDrop = true;
            this.txtCCCD.Location = new System.Drawing.Point(115, 39);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(230, 22);
            this.txtCCCD.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID_Thue";
            // 
            // txtIDT
            // 
            this.txtIDT.Location = new System.Drawing.Point(115, 111);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.ReadOnly = true;
            this.txtIDT.Size = new System.Drawing.Size(230, 22);
            this.txtIDT.TabIndex = 10;
            // 
            // gvThue
            // 
            this.gvThue.AllowUserToOrderColumns = true;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.Location = new System.Drawing.Point(453, 47);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 24;
            this.gvThue.Size = new System.Drawing.Size(584, 288);
            this.gvThue.TabIndex = 17;
            // 
            // FThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvThue);
            this.Name = "FThue";
            this.Text = "FThue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Button btnCongTy;
        private System.Windows.Forms.DataGridView gvThue;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.Button btnCCCD;
    }
}