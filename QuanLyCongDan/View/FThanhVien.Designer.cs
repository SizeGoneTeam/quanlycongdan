namespace QuanLyCongDan.View
{
    partial class FThanhVien
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
            this.ucThanhVien1 = new QuanLyCongDan.UCThanhVien();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ucThanhVien1
            // 
            this.ucThanhVien1.Location = new System.Drawing.Point(27, 106);
            this.ucThanhVien1.Name = "ucThanhVien1";
            this.ucThanhVien1.Size = new System.Drawing.Size(271, 377);
            this.ucThanhVien1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 100);
            this.panel1.TabIndex = 1;
            // 
            // FThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucThanhVien1);
            this.Name = "FThanhVien";
            this.Text = "FThanhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private UCThanhVien ucThanhVien1;
        private System.Windows.Forms.Panel panel1;
    }
}