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
            this.SuspendLayout();
            // 
            // ucThanhVien1
            // 
            this.ucThanhVien1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucThanhVien1.BackColor = System.Drawing.Color.White;
            this.ucThanhVien1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ucThanhVien1.Location = new System.Drawing.Point(14, 14);
            this.ucThanhVien1.Margin = new System.Windows.Forms.Padding(15);
            this.ucThanhVien1.MinimumSize = new System.Drawing.Size(15, 15);
            this.ucThanhVien1.Name = "ucThanhVien1";
            this.ucThanhVien1.Size = new System.Drawing.Size(761, 452);
            this.ucThanhVien1.TabIndex = 0;
            this.ucThanhVien1.Load += new System.EventHandler(this.ucThanhVien1_Load);
            // 
            // FThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(791, 477);
            this.Controls.Add(this.ucThanhVien1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "FThanhVien";
            this.Text = "FThanhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private UCThanhVien ucThanhVien1;
    }
}