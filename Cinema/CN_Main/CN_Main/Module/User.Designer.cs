namespace CN_Main
{
    partial class frm_user
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
            this.gb_Main = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_IsActive = new System.Windows.Forms.CheckBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Main
            // 
            this.gb_Main.Controls.Add(this.btn_submit);
            this.gb_Main.Controls.Add(this.cb_IsActive);
            this.gb_Main.Controls.Add(this.dtp_BirthDate);
            this.gb_Main.Controls.Add(this.rtb_Address);
            this.gb_Main.Controls.Add(this.txt_Sex);
            this.gb_Main.Controls.Add(this.txt_Status);
            this.gb_Main.Controls.Add(this.txt_Password);
            this.gb_Main.Controls.Add(this.txt_Nama);
            this.gb_Main.Controls.Add(this.label7);
            this.gb_Main.Controls.Add(this.label6);
            this.gb_Main.Controls.Add(this.label5);
            this.gb_Main.Controls.Add(this.label4);
            this.gb_Main.Controls.Add(this.label3);
            this.gb_Main.Controls.Add(this.label2);
            this.gb_Main.Controls.Add(this.label1);
            this.gb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Main.Location = new System.Drawing.Point(0, 0);
            this.gb_Main.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Main.Name = "gb_Main";
            this.gb_Main.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Main.Size = new System.Drawing.Size(533, 292);
            this.gb_Main.TabIndex = 15;
            this.gb_Main.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(324, 117);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(74, 37);
            this.btn_submit.TabIndex = 29;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_IsActive
            // 
            this.cb_IsActive.AutoSize = true;
            this.cb_IsActive.Location = new System.Drawing.Point(193, 238);
            this.cb_IsActive.Margin = new System.Windows.Forms.Padding(2);
            this.cb_IsActive.Name = "cb_IsActive";
            this.cb_IsActive.Size = new System.Drawing.Size(15, 14);
            this.cb_IsActive.TabIndex = 28;
            this.cb_IsActive.UseVisualStyleBackColor = true;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(193, 166);
            this.dtp_BirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(135, 20);
            this.dtp_BirthDate.TabIndex = 26;
            this.dtp_BirthDate.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // rtb_Address
            // 
            this.rtb_Address.Location = new System.Drawing.Point(193, 194);
            this.rtb_Address.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(124, 36);
            this.rtb_Address.TabIndex = 27;
            this.rtb_Address.Text = "";
            // 
            // txt_Sex
            // 
            this.txt_Sex.Location = new System.Drawing.Point(193, 134);
            this.txt_Sex.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(68, 20);
            this.txt_Sex.TabIndex = 25;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(193, 105);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(68, 20);
            this.txt_Status.TabIndex = 24;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(193, 71);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(68, 20);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(193, 36);
            this.txt_Nama.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(68, 20);
            this.txt_Nama.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "is active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "name";
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.gb_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_user";
            this.Text = "Form1";
            this.gb_Main.ResumeLayout(false);
            this.gb_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Main;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox cb_IsActive;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}