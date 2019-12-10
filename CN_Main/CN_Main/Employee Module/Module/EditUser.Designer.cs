namespace CN_Main
{
    partial class frm_user_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user_employee));
            this.gb_Main = new System.Windows.Forms.GroupBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.RichTextBox();
            this.txt_Status = new System.Windows.Forms.RichTextBox();
            this.txt_Nama = new System.Windows.Forms.RichTextBox();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cb_IsEmployee = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Main
            // 
            this.gb_Main.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gb_Main.Controls.Add(this.txt_Password);
            this.gb_Main.Controls.Add(this.txt_Sex);
            this.gb_Main.Controls.Add(this.txt_Status);
            this.gb_Main.Controls.Add(this.txt_Nama);
            this.gb_Main.Controls.Add(this.rtb_Address);
            this.gb_Main.Controls.Add(this.dtp_BirthDate);
            this.gb_Main.Controls.Add(this.btn_Save);
            this.gb_Main.Controls.Add(this.btn_display);
            this.gb_Main.Controls.Add(this.dgv);
            this.gb_Main.Controls.Add(this.cb_IsEmployee);
            this.gb_Main.Controls.Add(this.label6);
            this.gb_Main.Controls.Add(this.label5);
            this.gb_Main.Controls.Add(this.label4);
            this.gb_Main.Controls.Add(this.label3);
            this.gb_Main.Controls.Add(this.label2);
            this.gb_Main.Controls.Add(this.label1);
            this.gb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Main.Location = new System.Drawing.Point(0, 0);
            this.gb_Main.Name = "gb_Main";
            this.gb_Main.Size = new System.Drawing.Size(1194, 512);
            this.gb_Main.TabIndex = 15;
            this.gb_Main.TabStop = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(165, 108);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(268, 26);
            this.txt_Password.TabIndex = 47;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Sex
            // 
            this.txt_Sex.Location = new System.Drawing.Point(165, 203);
            this.txt_Sex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(268, 30);
            this.txt_Sex.TabIndex = 46;
            this.txt_Sex.Text = "";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(165, 152);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(268, 30);
            this.txt_Status.TabIndex = 45;
            this.txt_Status.Text = "";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(165, 60);
            this.txt_Nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(268, 30);
            this.txt_Nama.TabIndex = 43;
            this.txt_Nama.Text = "";
            // 
            // rtb_Address
            // 
            this.rtb_Address.Location = new System.Drawing.Point(165, 286);
            this.rtb_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(268, 75);
            this.rtb_Address.TabIndex = 41;
            this.rtb_Address.Text = "";
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(168, 243);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(265, 26);
            this.dtp_BirthDate.TabIndex = 36;
            this.dtp_BirthDate.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Location = new System.Drawing.Point(888, 395);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(288, 43);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_display.Location = new System.Drawing.Point(488, 395);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(357, 43);
            this.btn_display.TabIndex = 33;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(474, 37);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(702, 326);
            this.dgv.TabIndex = 32;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_user_CellContentClick);
            // 
            // cb_IsEmployee
            // 
            this.cb_IsEmployee.AutoSize = true;
            this.cb_IsEmployee.Location = new System.Drawing.Point(27, 363);
            this.cb_IsEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_IsEmployee.Name = "cb_IsEmployee";
            this.cb_IsEmployee.Size = new System.Drawing.Size(118, 24);
            this.cb_IsEmployee.TabIndex = 31;
            this.cb_IsEmployee.Text = "IsEmployee";
            this.cb_IsEmployee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label6.Location = new System.Drawing.Point(21, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label2.Location = new System.Drawing.Point(21, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Birth Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // frm_user_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 512);
            this.Controls.Add(this.gb_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_user_employee";
            this.Text = "Form Register";
            this.gb_Main.ResumeLayout(false);
            this.gb_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Main;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_display;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.CheckBox cb_IsEmployee;
        private System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.RichTextBox rtb_Address;
        public System.Windows.Forms.DateTimePicker dtp_BirthDate;
        public System.Windows.Forms.RichTextBox txt_Nama;
        public System.Windows.Forms.TextBox txt_Password;
        public System.Windows.Forms.RichTextBox txt_Sex;
        public System.Windows.Forms.RichTextBox txt_Status;
    }
}