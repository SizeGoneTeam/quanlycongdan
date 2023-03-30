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
            this.lblCCCD = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.lblCCCD);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIDT);
            this.panel1.Location = new System.Drawing.Point(42, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 288);
            this.panel1.TabIndex = 20;
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
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(241, 239);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(104, 34);
            this.btnXem.TabIndex = 19;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID_Thue";
            // 
            // txtIDT
            // 
            this.txtIDT.Location = new System.Drawing.Point(115, 80);
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
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView gvThue;
    }
}