namespace CN_Main
{
    partial class FrmEditPromotion
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_main = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MovieImage = new System.Windows.Forms.TextBox();
            this.txt_MovieName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_main)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(420, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 39);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Update);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_MovieImage);
            this.groupBox1.Controls.Add(this.txt_MovieName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 391);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Click For Import";
            // 
            // txt_MovieImage
            // 
            this.txt_MovieImage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieImage.Location = new System.Drawing.Point(149, 72);
            this.txt_MovieImage.Name = "txt_MovieImage";
            this.txt_MovieImage.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieImage.TabIndex = 26;
            this.txt_MovieImage.Click += new System.EventHandler(this.txt_MovieImage_Click);
            // 
            // txt_MovieName
            // 
            this.txt_MovieName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_MovieName.Location = new System.Drawing.Point(149, 19);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(138, 24);
            this.txt_MovieName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Movie Image  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name              :";
            // 
            // FrmEditPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditPromotion";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_MovieImage;
        public System.Windows.Forms.TextBox txt_MovieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}