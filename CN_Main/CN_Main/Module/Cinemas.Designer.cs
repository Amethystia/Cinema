﻿namespace CN_Main
{
    partial class FrmCinemas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_Duration = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Request = new System.Windows.Forms.Button();
            this.CB_Movie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CB_Cinemas = new System.Windows.Forms.ComboBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.cb_class);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.cb_Duration);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Request);
            this.panel1.Controls.Add(this.CB_Movie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CB_Cinemas);
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 390);
            this.panel1.TabIndex = 1;
            // 
            // cb_class
            // 
            this.cb_class.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(132, 284);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(280, 21);
            this.cb_class.TabIndex = 87;
            this.cb_class.SelectedIndexChanged += new System.EventHandler(this.cb_class_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(35, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Select Class :";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(558, 257);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(507, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "PRICE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(-6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 33);
            this.label2.TabIndex = 83;
            this.label2.Text = "REQUEST BOOKING THEATHER";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd/mm/yyyy HH:MM";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(132, 311);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 82;
            // 
            // cb_Duration
            // 
            this.cb_Duration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Duration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_Duration.FormattingEnabled = true;
            this.cb_Duration.Location = new System.Drawing.Point(558, 226);
            this.cb_Duration.Name = "cb_Duration";
            this.cb_Duration.Size = new System.Drawing.Size(99, 21);
            this.cb_Duration.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(499, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Duration :";
            // 
            // btn_Request
            // 
            this.btn_Request.BackColor = System.Drawing.Color.Lime;
            this.btn_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Request.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Request.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Request.Location = new System.Drawing.Point(502, 302);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(112, 57);
            this.btn_Request.TabIndex = 79;
            this.btn_Request.Text = "REQUEST NOW";
            this.btn_Request.UseVisualStyleBackColor = false;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // CB_Movie
            // 
            this.CB_Movie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CB_Movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CB_Movie.FormattingEnabled = true;
            this.CB_Movie.Location = new System.Drawing.Point(132, 254);
            this.CB_Movie.Name = "CB_Movie";
            this.CB_Movie.Size = new System.Drawing.Size(280, 21);
            this.CB_Movie.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Select Cinema :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(36, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Select Movie :";
            // 
            // CB_Cinemas
            // 
            this.CB_Cinemas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CB_Cinemas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CB_Cinemas.FormattingEnabled = true;
            this.CB_Cinemas.Location = new System.Drawing.Point(132, 229);
            this.CB_Cinemas.Name = "CB_Cinemas";
            this.CB_Cinemas.Size = new System.Drawing.Size(280, 21);
            this.CB_Cinemas.TabIndex = 73;
            this.CB_Cinemas.SelectedIndexChanged += new System.EventHandler(this.CB_Cinemas_SelectedIndexChanged);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelbl.Location = new System.Drawing.Point(39, 311);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(69, 13);
            this.datelbl.TabIndex = 69;
            this.datelbl.Text = "Select Date :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(611, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 107);
            this.pictureBox5.TabIndex = 66;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(486, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 107);
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(355, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 107);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(222, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 107);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 107);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "OUR CINEMAS";
            // 
            // FrmCinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 390);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCinemas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.ComboBox CB_Movie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CB_Cinemas;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label label6;
    }
}
