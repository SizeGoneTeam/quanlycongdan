namespace QuanLyCongDan
{
    partial class FTamTruTamVang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDTT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Leave = new System.Windows.Forms.DateTimePicker();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gvTTTV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Come = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTTTV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Come);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDTT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Leave);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIDCD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 288);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID_TamTru";
            // 
            // txtIDTT
            // 
            this.txtIDTT.AllowDrop = true;
            this.txtIDTT.Location = new System.Drawing.Point(114, 39);
            this.txtIDTT.Name = "txtIDTT";
            this.txtIDTT.Size = new System.Drawing.Size(230, 22);
            this.txtIDTT.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID_CongDan";
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(114, 171);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(230, 22);
            this.Leave.TabIndex = 3;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(114, 208);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(230, 22);
            this.txtAdd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "DiaChi";
            // 
            // txtIDCD
            // 
            this.txtIDCD.Location = new System.Drawing.Point(114, 80);
            this.txtIDCD.Name = "txtIDCD";
            this.txtIDCD.Size = new System.Drawing.Size(230, 22);
            this.txtIDCD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NgayDi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sua";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvTTTV
            // 
            this.gvTTTV.AllowUserToOrderColumns = true;
            this.gvTTTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTTTV.Location = new System.Drawing.Point(433, 45);
            this.gvTTTV.Name = "gvTTTV";
            this.gvTTTV.RowHeadersWidth = 51;
            this.gvTTTV.RowTemplate.Height = 24;
            this.gvTTTV.Size = new System.Drawing.Size(345, 288);
            this.gvTTTV.TabIndex = 17;
            this.gvTTTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTTTV_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Come
            // 
            this.Come.Location = new System.Drawing.Point(114, 126);
            this.Come.Name = "Come";
            this.Come.Size = new System.Drawing.Size(230, 22);
            this.Come.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "NgayDen";
            // 
            // FTamTruTamVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gvTTTV);
            this.Controls.Add(this.button1);
            this.Name = "FTamTruTamVang";
            this.Text = "FTamTruTamVang";
            this.Load += new System.EventHandler(this.FTamTruTamVang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTTTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Leave;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvTTTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Come;
        private System.Windows.Forms.Label label2;
    }
}