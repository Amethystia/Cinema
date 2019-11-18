namespace CN_Main
{
    partial class FrmCinemaApproval
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gb_datagrid = new System.Windows.Forms.GroupBox();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.dgv_CinemaApproval = new System.Windows.Forms.DataGridView();
            this.cb_isApprove = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_requestor = new System.Windows.Forms.TextBox();
            this.txt_cinema = new System.Windows.Forms.TextBox();
            this.txt_moviename = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_datagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CinemaApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.txt_class);
            this.panel1.Controls.Add(this.txt_moviename);
            this.panel1.Controls.Add(this.txt_cinema);
            this.panel1.Controls.Add(this.txt_requestor);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.gb_datagrid);
            this.panel1.Controls.Add(this.cb_isApprove);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 450);
            this.panel1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 27);
            this.comboBox1.TabIndex = 49;
            // 
            // gb_datagrid
            // 
            this.gb_datagrid.Controls.Add(this.btn_reject);
            this.gb_datagrid.Controls.Add(this.btn_approve);
            this.gb_datagrid.Controls.Add(this.dgv_CinemaApproval);
            this.gb_datagrid.Location = new System.Drawing.Point(383, 3);
            this.gb_datagrid.Name = "gb_datagrid";
            this.gb_datagrid.Size = new System.Drawing.Size(429, 424);
            this.gb_datagrid.TabIndex = 1;
            this.gb_datagrid.TabStop = false;
            // 
            // btn_reject
            // 
            this.btn_reject.BackColor = System.Drawing.Color.Red;
            this.btn_reject.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold);
            this.btn_reject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reject.Location = new System.Drawing.Point(260, 20);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(137, 49);
            this.btn_reject.TabIndex = 2;
            this.btn_reject.Text = "Reject";
            this.btn_reject.UseVisualStyleBackColor = false;
            // 
            // btn_approve
            // 
            this.btn_approve.BackColor = System.Drawing.Color.Maroon;
            this.btn_approve.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold);
            this.btn_approve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_approve.Location = new System.Drawing.Point(6, 19);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(137, 49);
            this.btn_approve.TabIndex = 1;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = false;
            // 
            // dgv_CinemaApproval
            // 
            this.dgv_CinemaApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CinemaApproval.Location = new System.Drawing.Point(6, 74);
            this.dgv_CinemaApproval.Name = "dgv_CinemaApproval";
            this.dgv_CinemaApproval.Size = new System.Drawing.Size(391, 337);
            this.dgv_CinemaApproval.TabIndex = 0;
            // 
            // cb_isApprove
            // 
            this.cb_isApprove.AutoSize = true;
            this.cb_isApprove.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.cb_isApprove.Location = new System.Drawing.Point(196, 383);
            this.cb_isApprove.Name = "cb_isApprove";
            this.cb_isApprove.Size = new System.Drawing.Size(155, 31);
            this.cb_isApprove.TabIndex = 48;
            this.cb_isApprove.Text = "IS Approve";
            this.cb_isApprove.UseVisualStyleBackColor = true;
            this.cb_isApprove.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Class";
            this.label7.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(172, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 27);
            this.label13.TabIndex = 47;
            this.label13.Text = ":";
            this.label13.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Requestor";
            this.label1.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label14.Location = new System.Drawing.Point(12, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 27);
            this.label14.TabIndex = 46;
            this.label14.Text = "Theather";
            this.label14.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 14);
            this.panel2.TabIndex = 45;
            this.panel2.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = ":";
            this.label2.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.Location = new System.Drawing.Point(12, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 27);
            this.label12.TabIndex = 44;
            this.label12.Text = "Price";
            this.label12.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cinema";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(172, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = ":";
            this.label3.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(172, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 27);
            this.label11.TabIndex = 42;
            this.label11.Text = ":";
            this.label11.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Movie Name";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(172, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = ":";
            this.label6.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(12, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "Date";
            this.label8.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(172, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 27);
            this.label10.TabIndex = 38;
            this.label10.Text = ":";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(172, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = ":";
            this.label9.UseWaitCursor = true;
            // 
            // txt_requestor
            // 
            this.txt_requestor.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txt_requestor.Location = new System.Drawing.Point(196, 92);
            this.txt_requestor.Name = "txt_requestor";
            this.txt_requestor.Size = new System.Drawing.Size(172, 29);
            this.txt_requestor.TabIndex = 50;
            // 
            // txt_cinema
            // 
            this.txt_cinema.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txt_cinema.Location = new System.Drawing.Point(196, 134);
            this.txt_cinema.Name = "txt_cinema";
            this.txt_cinema.Size = new System.Drawing.Size(172, 29);
            this.txt_cinema.TabIndex = 51;
            // 
            // txt_moviename
            // 
            this.txt_moviename.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txt_moviename.Location = new System.Drawing.Point(196, 187);
            this.txt_moviename.Name = "txt_moviename";
            this.txt_moviename.Size = new System.Drawing.Size(172, 29);
            this.txt_moviename.TabIndex = 52;
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txt_class.Location = new System.Drawing.Point(196, 234);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(172, 29);
            this.txt_class.TabIndex = 53;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(196, 295);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(172, 29);
            this.dtp_date.TabIndex = 54;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txt_price.Location = new System.Drawing.Point(196, 336);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(172, 29);
            this.txt_price.TabIndex = 55;
            // 
            // FrmCinemaApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCinemaApproval";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_datagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CinemaApproval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_datagrid;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.DataGridView dgv_CinemaApproval;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cb_isApprove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_moviename;
        private System.Windows.Forms.TextBox txt_cinema;
        private System.Windows.Forms.TextBox txt_requestor;
    }
}