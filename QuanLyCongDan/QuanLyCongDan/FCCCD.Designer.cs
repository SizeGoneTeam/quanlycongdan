namespace QuanLyCongDan
{
    partial class FCCCD
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
            this.button1 = new System.Windows.Forms.Button();
            this.gvCCCD = new System.Windows.Forms.DataGridView();
            this.dTPNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSOCC = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCCCD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvCCCD
            // 
            this.gvCCCD.AllowUserToOrderColumns = true;
            this.gvCCCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCCCD.Location = new System.Drawing.Point(433, 34);
            this.gvCCCD.Name = "gvCCCD";
            this.gvCCCD.RowHeadersWidth = 51;
            this.gvCCCD.RowTemplate.Height = 24;
            this.gvCCCD.Size = new System.Drawing.Size(345, 288);
            this.gvCCCD.TabIndex = 2;
            this.gvCCCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCCCD_CellContentClick);
            // 
            // dTPNgayCap
            // 
            this.dTPNgayCap.Location = new System.Drawing.Point(114, 171);
            this.dTPNgayCap.Name = "dTPNgayCap";
            this.dTPNgayCap.Size = new System.Drawing.Size(230, 22);
            this.dTPNgayCap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "SoCCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NgayCap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NoiCap";
            // 
            // txtSOCC
            // 
            this.txtSOCC.Location = new System.Drawing.Point(114, 80);
            this.txtSOCC.Name = "txtSOCC";
            this.txtSOCC.Size = new System.Drawing.Size(230, 22);
            this.txtSOCC.TabIndex = 10;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(114, 127);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(230, 22);
            this.txtAdd.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sua";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dTPNgayCap);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSOCC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 288);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID_CongDan";
            // 
            // txtCD
            // 
            this.txtCD.AllowDrop = true;
            this.txtCD.Location = new System.Drawing.Point(114, 39);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(230, 22);
            this.txtCD.TabIndex = 14;
            // 
            // FCCCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gvCCCD);
            this.Controls.Add(this.button1);
            this.Name = "FCCCD";
            this.Text = "FCCCD";
            this.Load += new System.EventHandler(this.FCCCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCCCD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvCCCD;
        private System.Windows.Forms.DateTimePicker dTPNgayCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSOCC;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCD;
    }
}