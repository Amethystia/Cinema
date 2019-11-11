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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.gb_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Main
            // 
            this.gb_Main.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gb_Main.Controls.Add(this.panel6);
            this.gb_Main.Controls.Add(this.panel5);
            this.gb_Main.Controls.Add(this.panel4);
            this.gb_Main.Controls.Add(this.panel3);
            this.gb_Main.Controls.Add(this.panel2);
            this.gb_Main.Controls.Add(this.panel1);
            this.gb_Main.Controls.Add(this.btn_back);
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
            this.gb_Main.Name = "gb_Main";
            this.gb_Main.Size = new System.Drawing.Size(478, 513);
            this.gb_Main.TabIndex = 15;
            this.gb_Main.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_submit.Location = new System.Drawing.Point(61, 401);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(357, 43);
            this.btn_submit.TabIndex = 29;
            this.btn_submit.Text = "Register";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_IsActive
            // 
            this.cb_IsActive.AutoSize = true;
            this.cb_IsActive.Location = new System.Drawing.Point(204, 337);
            this.cb_IsActive.Name = "cb_IsActive";
            this.cb_IsActive.Size = new System.Drawing.Size(22, 21);
            this.cb_IsActive.TabIndex = 28;
            this.cb_IsActive.UseVisualStyleBackColor = true;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(204, 216);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_BirthDate.TabIndex = 26;
            this.dtp_BirthDate.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // rtb_Address
            // 
            this.rtb_Address.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.rtb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Address.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rtb_Address.Location = new System.Drawing.Point(204, 266);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(214, 53);
            this.rtb_Address.TabIndex = 27;
            this.rtb_Address.Text = "";
            // 
            // txt_Sex
            // 
            this.txt_Sex.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sex.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Sex.Location = new System.Drawing.Point(204, 175);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(214, 22);
            this.txt_Sex.TabIndex = 25;
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Status.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Status.Location = new System.Drawing.Point(204, 133);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(214, 22);
            this.txt_Status.TabIndex = 24;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Password.Location = new System.Drawing.Point(204, 89);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(214, 22);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Nama
            // 
            this.txt_Nama.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_Nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nama.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nama.Location = new System.Drawing.Point(204, 42);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(214, 22);
            this.txt_Nama.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label7.Location = new System.Drawing.Point(56, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "IsActive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label6.Location = new System.Drawing.Point(56, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label4.Location = new System.Drawing.Point(56, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.Location = new System.Drawing.Point(56, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label2.Location = new System.Drawing.Point(56, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Birth Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(204, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 1);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(204, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 1);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(204, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 1);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(204, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 1);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(204, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 1);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(204, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 1);
            this.panel6.TabIndex = 30;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Location = new System.Drawing.Point(61, 458);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(357, 43);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Already have an account? Sign In";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 513);
            this.Controls.Add(this.gb_Main);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
    }
}