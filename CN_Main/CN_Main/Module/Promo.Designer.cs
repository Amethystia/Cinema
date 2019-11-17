namespace CN_Main
{
    partial class FrmPromo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slideshow1 = new System.Windows.Forms.PictureBox();
            this.slideshow2 = new System.Windows.Forms.PictureBox();
            this.slideshow3 = new System.Windows.Forms.PictureBox();
            this.slideshow4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slidetimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 450);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.slideshow1);
            this.panel2.Controls.Add(this.slideshow2);
            this.panel2.Controls.Add(this.slideshow3);
            this.panel2.Controls.Add(this.slideshow4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 450);
            this.panel2.TabIndex = 0;
            // 
            // slideshow1
            // 
            this.slideshow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideshow1.InitialImage = ((System.Drawing.Image)(resources.GetObject("slideshow1.InitialImage")));
            this.slideshow1.Location = new System.Drawing.Point(0, 0);
            this.slideshow1.Name = "slideshow1";
            this.slideshow1.Size = new System.Drawing.Size(899, 450);
            this.slideshow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshow1.TabIndex = 26;
            this.slideshow1.TabStop = false;
            // 
            // slideshow2
            // 
            this.slideshow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideshow2.InitialImage = ((System.Drawing.Image)(resources.GetObject("slideshow2.InitialImage")));
            this.slideshow2.Location = new System.Drawing.Point(0, 0);
            this.slideshow2.Name = "slideshow2";
            this.slideshow2.Size = new System.Drawing.Size(899, 450);
            this.slideshow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshow2.TabIndex = 24;
            this.slideshow2.TabStop = false;
            // 
            // slideshow3
            // 
            this.slideshow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideshow3.InitialImage = ((System.Drawing.Image)(resources.GetObject("slideshow3.InitialImage")));
            this.slideshow3.Location = new System.Drawing.Point(0, 0);
            this.slideshow3.Name = "slideshow3";
            this.slideshow3.Size = new System.Drawing.Size(899, 450);
            this.slideshow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshow3.TabIndex = 23;
            this.slideshow3.TabStop = false;
            // 
            // slideshow4
            // 
            this.slideshow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideshow4.InitialImage = ((System.Drawing.Image)(resources.GetObject("slideshow4.InitialImage")));
            this.slideshow4.Location = new System.Drawing.Point(0, 0);
            this.slideshow4.Name = "slideshow4";
            this.slideshow4.Size = new System.Drawing.Size(899, 450);
            this.slideshow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideshow4.TabIndex = 27;
            this.slideshow4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-65, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(875, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // slidetimer
            // 
            this.slidetimer.Tick += new System.EventHandler(this.slidetimer_Tick);
            // 
            // FrmPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPromo";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FrmPromo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideshow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox slideshow1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox slideshow2;
        private System.Windows.Forms.PictureBox slideshow3;
        private System.Windows.Forms.PictureBox slideshow4;
        private System.Windows.Forms.Timer slidetimer;
    }
}