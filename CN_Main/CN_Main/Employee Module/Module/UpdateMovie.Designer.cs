namespace CN_Main
{
    partial class FrmUpdateMovie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IsReleased = new System.Windows.Forms.TextBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.txt_MovieDescription = new System.Windows.Forms.TextBox();
            this.txt_MovieIMDB = new System.Windows.Forms.TextBox();
            this.txt_MovieName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ReleaseDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_IsReleased);
            this.groupBox1.Controls.Add(this.txt_Duration);
            this.groupBox1.Controls.Add(this.txt_MovieDescription);
            this.groupBox1.Controls.Add(this.txt_MovieIMDB);
            this.groupBox1.Controls.Add(this.txt_MovieName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 391);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dtp_ReleaseDate
            // 
            this.dtp_ReleaseDate.CustomFormat = "yyyy-mm-dd";
            this.dtp_ReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReleaseDate.Location = new System.Drawing.Point(165, 214);
            this.dtp_ReleaseDate.Name = "dtp_ReleaseDate";
            this.dtp_ReleaseDate.Size = new System.Drawing.Size(138, 20);
            this.dtp_ReleaseDate.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(22, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Is Released    :";
            // 
            // txt_IsReleased
            // 
            this.txt_IsReleased.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_IsReleased.Location = new System.Drawing.Point(165, 254);
            this.txt_IsReleased.Name = "txt_IsReleased";
            this.txt_IsReleased.Size = new System.Drawing.Size(138, 24);
            this.txt_IsReleased.TabIndex = 30;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_Duration.Location = new System.Drawing.Point(165, 167);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(138, 24);
            this.txt_Duration.TabIndex = 28;
            // 
            // txt_MovieDescription
            // 
            this.txt_MovieDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieDescription.Location = new System.Drawing.Point(165, 123);
            this.txt_MovieDescription.Name = "txt_MovieDescription";
            this.txt_MovieDescription.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieDescription.TabIndex = 25;
            // 
            // txt_MovieIMDB
            // 
            this.txt_MovieIMDB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieIMDB.Location = new System.Drawing.Point(165, 72);
            this.txt_MovieIMDB.Name = "txt_MovieIMDB";
            this.txt_MovieIMDB.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieIMDB.TabIndex = 24;
            // 
            // txt_MovieName
            // 
            this.txt_MovieName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieName.Location = new System.Drawing.Point(165, 18);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(22, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Released Date    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(22, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Duration               :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Movie Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Movie IMDB           :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Name         :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 450);
            this.panel1.TabIndex = 23;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(0, 24);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(93, 41);
            this.Btn_Update.TabIndex = 20;
            this.Btn_Update.Text = "UPDATE";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label11.Location = new System.Drawing.Point(110, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 27);
            this.label11.TabIndex = 19;
            this.label11.Text = "EDIT MOVIE";
            // 
            // FrmUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUpdateMovie";
            this.Text = "Form Edit Movie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.TextBox txt_MovieDescription;
        private System.Windows.Forms.TextBox txt_MovieIMDB;
        private System.Windows.Forms.TextBox txt_MovieName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IsReleased;
        private System.Windows.Forms.DateTimePicker dtp_ReleaseDate;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label11;
    }
}