using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN_Business;

namespace CN_Main
{
    public partial class FrmPromo : Form
    {
        private CinemaService cinemaService;
        DataSet datasetslide = new DataSet();
        DataSet datasetrelease = new DataSet();
        public FrmPromo()
        {
            InitializeComponent();
        }

        private void FrmPromo_Load(object sender, EventArgs e)
        {
            cinemaService = new CinemaService();
            datasetslide = cinemaService.get_promo_slide_data(datasetslide);
            try
            {
                slideshow1.ImageLocation = datasetslide.Tables[0].Rows[0][0].ToString();
                slideshow2.ImageLocation = datasetslide.Tables[0].Rows[1][0].ToString();
                slideshow3.ImageLocation = datasetslide.Tables[0].Rows[2][0].ToString();
                slideshow4.ImageLocation = datasetslide.Tables[0].Rows[3][0].ToString();
                //slide BIG
            }
            catch
            {

            }
            slidetimer.Interval = 3000;
            slidetimer.Start();
            slideshow1.Visible = true;
            slideshow2.Visible = false;
            slideshow3.Visible = false;
            slideshow4.Visible = false;

        }

        private void slidetimer_Tick(object sender, EventArgs e)
        {
            if (slideshow1.Visible == true)
            {
                slideshow1.Visible = false;
                slideshow2.Visible = true;
            }
            else if (slideshow2.Visible == true)
            {
                slideshow2.Visible = false;
                slideshow3.Visible = true;
            }
            else if (slideshow3.Visible == true)
            {
                slideshow3.Visible = false;
                slideshow4.Visible = true;
            }
            else
            {
                slideshow4.Visible = false;
                slideshow1.Visible = true;
            }

        }

    }
}
