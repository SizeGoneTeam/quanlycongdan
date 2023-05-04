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
            this.ucThanhVien1.Location = new System.Drawing.Point(10, 11);
            this.ucThanhVien1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ucThanhVien1.MinimumSize = new System.Drawing.Size(11, 12);
            this.ucThanhVien1.Name = "ucThanhVien1";
            this.ucThanhVien1.Size = new System.Drawing.Size(577, 372);
            this.ucThanhVien1.TabIndex = 0;
            // 
            // FThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(599, 393);
            this.Controls.Add(this.ucThanhVien1);
            this.MinimumSize = new System.Drawing.Size(18, 45);
            this.Name = "FThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FThanhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private UCThanhVien ucThanhVien1;
    }
}