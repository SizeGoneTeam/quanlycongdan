namespace QuanLyCongDan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPNgayUp = new System.Windows.Forms.DateTimePicker();
            this.txtMso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dTPNgayUp);
            this.panel1.Controls.Add(this.txtMso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIDT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(42, 47);
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
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID_CongDan";
            // 
            // txtID
            // 
            this.txtID.AllowDrop = true;
            this.txtID.Location = new System.Drawing.Point(115, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 22);
            this.txtID.TabIndex = 14;
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
            // dTPNgayUp
            // 
            this.dTPNgayUp.Location = new System.Drawing.Point(115, 167);
            this.dTPNgayUp.Name = "dTPNgayUp";
            this.dTPNgayUp.Size = new System.Drawing.Size(230, 22);
            this.dTPNgayUp.TabIndex = 3;
            // 
            // txtMso
            // 
            this.txtMso.Location = new System.Drawing.Point(115, 127);
            this.txtMso.Name = "txtMso";
            this.txtMso.Size = new System.Drawing.Size(230, 22);
            this.txtMso.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "MaSoThue";
            // 
            // txtIDT
            // 
            this.txtIDT.Location = new System.Drawing.Point(115, 80);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(230, 22);
            this.txtIDT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NgayCapNhat";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sua";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvThue
            // 
            this.gvThue.AllowUserToOrderColumns = true;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.Location = new System.Drawing.Point(453, 47);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 24;
            this.gvThue.Size = new System.Drawing.Size(345, 288);
            this.gvThue.TabIndex = 17;
            this.gvThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThue_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gvThue);
            this.Controls.Add(this.button1);
            this.Name = "FThue";
            this.Text = "FThue";
            this.Load += new System.EventHandler(this.FThue_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPNgayUp;
        private System.Windows.Forms.TextBox txtMso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvThue;
        private System.Windows.Forms.Button button1;
    }
}