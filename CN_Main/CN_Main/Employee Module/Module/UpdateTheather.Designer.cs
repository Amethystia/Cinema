namespace CN_Main
{
    partial class FrmUpdateTheather
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Seats = new System.Windows.Forms.TextBox();
            this.txt_TheatherName = new System.Windows.Forms.TextBox();
            this.txt_Cinema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(0, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 39);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Seats);
            this.groupBox1.Controls.Add(this.txt_TheatherName);
            this.groupBox1.Controls.Add(this.txt_Cinema);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 391);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txt_Seats
            // 
            this.txt_Seats.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txt_Seats.Location = new System.Drawing.Point(219, 122);
            this.txt_Seats.Name = "txt_Seats";
            this.txt_Seats.Size = new System.Drawing.Size(250, 32);
            this.txt_Seats.TabIndex = 25;
            // 
            // txt_TheatherName
            // 
            this.txt_TheatherName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txt_TheatherName.Location = new System.Drawing.Point(219, 71);
            this.txt_TheatherName.Name = "txt_TheatherName";
            this.txt_TheatherName.Size = new System.Drawing.Size(250, 32);
            this.txt_TheatherName.TabIndex = 24;
            // 
            // txt_Cinema
            // 
            this.txt_Cinema.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txt_Cinema.Location = new System.Drawing.Point(219, 17);
            this.txt_Cinema.Name = "txt_Cinema";
            this.txt_Cinema.Size = new System.Drawing.Size(250, 32);
            this.txt_Cinema.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seats                     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Theather Name    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cinema                 :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 450);
            this.panel1.TabIndex = 23;
            // 
            // FrmUpdateTheather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUpdateTheather";
            this.Text = "Form Edit Theather";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Seats;
        private System.Windows.Forms.TextBox txt_TheatherName;
        private System.Windows.Forms.TextBox txt_Cinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}