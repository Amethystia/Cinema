﻿namespace CN_Main
{
    partial class FrmMovieDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovieDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Cinemas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Theather = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Time = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(742, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(61, 40);
            this.btn_back.TabIndex = 16;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(410, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Class";
            // 
            // CB_Class
            // 
            this.CB_Class.FormattingEnabled = true;
            this.CB_Class.Location = new System.Drawing.Point(562, 104);
            this.CB_Class.Name = "CB_Class";
            this.CB_Class.Size = new System.Drawing.Size(136, 21);
            this.CB_Class.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(545, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(544, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(410, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cinema";
            // 
            // CB_Cinemas
            // 
            this.CB_Cinemas.FormattingEnabled = true;
            this.CB_Cinemas.Location = new System.Drawing.Point(561, 22);
            this.CB_Cinemas.Name = "CB_Cinemas";
            this.CB_Cinemas.Size = new System.Drawing.Size(136, 21);
            this.CB_Cinemas.TabIndex = 19;
            this.CB_Cinemas.SelectedIndexChanged += new System.EventHandler(this.cb_Cinemas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(545, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = ":";
            // 
            // CB_Theather
            // 
            this.CB_Theather.FormattingEnabled = true;
            this.CB_Theather.Location = new System.Drawing.Point(562, 76);
            this.CB_Theather.Name = "CB_Theather";
            this.CB_Theather.Size = new System.Drawing.Size(136, 21);
            this.CB_Theather.TabIndex = 26;
            this.CB_Theather.SelectedIndexChanged += new System.EventHandler(this.CB_Theather_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(410, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Theather";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(415, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 209);
            this.textBox1.TabIndex = 11;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(415, 141);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(119, 47);
            this.btn_book.TabIndex = 31;
            this.btn_book.Text = "BOOK";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(409, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Time";
            // 
            // CB_Time
            // 
            this.CB_Time.FormattingEnabled = true;
            this.CB_Time.Location = new System.Drawing.Point(561, 49);
            this.CB_Time.Name = "CB_Time";
            this.CB_Time.Size = new System.Drawing.Size(136, 21);
            this.CB_Time.TabIndex = 21;
            this.CB_Time.SelectedIndexChanged += new System.EventHandler(this.cb_Time_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(543, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = ":";
            // 
            // FrmMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 417);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_Theather);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_Cinemas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Time);
            this.Controls.Add(this.CB_Class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovieDetails";
            this.Load += new System.EventHandler(this.FrmMovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CB_Class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CB_Cinemas;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CB_Theather;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CB_Time;
        private System.Windows.Forms.Label label3;
    }
}
