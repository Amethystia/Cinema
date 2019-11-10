using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN_Main
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(object FormChild)
        {
            if (this.Panel_Container.Controls.Count > 0)
                this.Panel_Container.Controls.RemoveAt(0);
            Form FC = FormChild as Form;
            FC.TopLevel = false;
            FC.Dock = DockStyle.Fill;
            this.Panel_Container.Controls.Add(FC);
            this.Panel_Container.Tag = FC;
            FC.Show();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmHome());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmHome());
        }

        private void btn_Movies_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmMovies());
        }
        private void btn_Cinemas_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmCinemas());
        }

        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmPromo());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
