namespace CN_Main
{
    partial class FrmEditMovie
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
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IsReleased = new System.Windows.Forms.TextBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.txt_SlideImage = new System.Windows.Forms.TextBox();
            this.txt_MovieImage = new System.Windows.Forms.TextBox();
            this.txt_MovieDescription = new System.Windows.Forms.TextBox();
            this.txt_MovieIMDB = new System.Windows.Forms.TextBox();
            this.txt_MovieName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_main = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(316, 12);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(98, 39);
            this.btn_Display.TabIndex = 16;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(420, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 39);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_ReleaseDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_IsReleased);
            this.groupBox1.Controls.Add(this.txt_Duration);
            this.groupBox1.Controls.Add(this.txt_SlideImage);
            this.groupBox1.Controls.Add(this.txt_MovieImage);
            this.groupBox1.Controls.Add(this.txt_MovieDescription);
            this.groupBox1.Controls.Add(this.txt_MovieIMDB);
            this.groupBox1.Controls.Add(this.txt_MovieName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 391);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Click For Import";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Click For Import";
            // 
            // dtp_ReleaseDate
            // 
            this.dtp_ReleaseDate.CustomFormat = "yyyy-mm-dd";
            this.dtp_ReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReleaseDate.Location = new System.Drawing.Point(149, 324);
            this.dtp_ReleaseDate.Name = "dtp_ReleaseDate";
            this.dtp_ReleaseDate.Size = new System.Drawing.Size(138, 20);
            this.dtp_ReleaseDate.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(6, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Is Released    :";
            // 
            // txt_IsReleased
            // 
            this.txt_IsReleased.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_IsReleased.Location = new System.Drawing.Point(149, 364);
            this.txt_IsReleased.Name = "txt_IsReleased";
            this.txt_IsReleased.Size = new System.Drawing.Size(138, 24);
            this.txt_IsReleased.TabIndex = 30;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_Duration.Location = new System.Drawing.Point(149, 277);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(138, 24);
            this.txt_Duration.TabIndex = 28;
            // 
            // txt_SlideImage
            // 
            this.txt_SlideImage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_SlideImage.Location = new System.Drawing.Point(149, 223);
            this.txt_SlideImage.Name = "txt_SlideImage";
            this.txt_SlideImage.Size = new System.Drawing.Size(138, 24);
            this.txt_SlideImage.TabIndex = 27;
            this.txt_SlideImage.Click += new System.EventHandler(this.txt_SlideImage_Click);
            // 
            // txt_MovieImage
            // 
            this.txt_MovieImage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieImage.Location = new System.Drawing.Point(149, 171);
            this.txt_MovieImage.Name = "txt_MovieImage";
            this.txt_MovieImage.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieImage.TabIndex = 26;
            this.txt_MovieImage.Click += new System.EventHandler(this.txt_MovieImage_Click);
            // 
            // txt_MovieDescription
            // 
            this.txt_MovieDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieDescription.Location = new System.Drawing.Point(149, 124);
            this.txt_MovieDescription.Name = "txt_MovieDescription";
            this.txt_MovieDescription.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieDescription.TabIndex = 25;
            // 
            // txt_MovieIMDB
            // 
            this.txt_MovieIMDB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieIMDB.Location = new System.Drawing.Point(149, 73);
            this.txt_MovieIMDB.Name = "txt_MovieIMDB";
            this.txt_MovieIMDB.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieIMDB.TabIndex = 24;
            // 
            // txt_MovieName
            // 
            this.txt_MovieName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieName.Location = new System.Drawing.Point(149, 19);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(6, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Released Date    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Duration               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Slide Image          :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Movie Image        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Movie Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Movie IMDB           :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Name         :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Display);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 450);
            this.panel1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_main);
            this.groupBox2.Location = new System.Drawing.Point(316, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 391);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // dg_main
            // 
            this.dg_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_main.Location = new System.Drawing.Point(3, 16);
            this.dg_main.Name = "dg_main";
            this.dg_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_main.Size = new System.Drawing.Size(506, 372);
            this.dg_main.TabIndex = 1;
            this.dg_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_main_CellClick);
            this.dg_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_user_CellContentClick);
            // 
            // FrmEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditMovie";
            this.Text = "FormHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_Duration;
        public System.Windows.Forms.TextBox txt_SlideImage;
        public System.Windows.Forms.TextBox txt_MovieImage;
        public System.Windows.Forms.TextBox txt_MovieDescription;
        public System.Windows.Forms.TextBox txt_MovieIMDB;
        public System.Windows.Forms.TextBox txt_MovieName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_main;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_IsReleased;
        public System.Windows.Forms.DateTimePicker dtp_ReleaseDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}