using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CN_Business;


namespace CN_Main
{
    public partial class FrmHome : Form
    {
        private CinemaService cinemaService;
        DataSet datasetslide = new DataSet();
        DataSet datasetrelease = new DataSet();
        public FrmHome()
        {
            InitializeComponent();
        }


        private void home_Load(object sender, EventArgs e)
        {
            cinemaService = new CinemaService();
            datasetslide = cinemaService.get_slide_data(datasetslide);
            try
            {
                slideshowpic1.ImageLocation = datasetslide.Tables[0].Rows[0][0].ToString();
                slidepic2.ImageLocation = datasetslide.Tables[0].Rows[1][0].ToString();
                slidepic3.ImageLocation = datasetslide.Tables[0].Rows[2][0].ToString();
                slidepic4.ImageLocation = datasetslide.Tables[0].Rows[3][0].ToString();
                //slide BIG
            }
            catch
            {

            }
            slidetimer.Interval = 3000;
            slidetimer.Start();
            slideshowpic1.Visible = true;
            slidepic2.Visible = false;
            slidepic3.Visible = false;
            slidepic4.Visible = false;

            datasetrelease = cinemaService.get_release_data(datasetrelease);
            if (datasetrelease.Tables[0].Rows.Count > 4)
            {
                mtitle1.Text = datasetrelease.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = datasetrelease.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = datasetrelease.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = datasetrelease.Tables[0].Rows[1][1].ToString();
                mtitle3.Text = datasetrelease.Tables[0].Rows[2][0].ToString();
                subpic3.ImageLocation = datasetrelease.Tables[0].Rows[2][1].ToString();
                mtitle4.Text = datasetrelease.Tables[0].Rows[datasetslide.Tables[0].Rows.Count - 1][0].ToString();
                subpic4.ImageLocation = datasetrelease.Tables[0].Rows[datasetslide.Tables[0].Rows.Count - 1][1].ToString();

            }
            else if (datasetslide.Tables[0].Rows.Count == 3)
            {
                mtitle1.Text = datasetslide.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = datasetslide.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = datasetslide.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = datasetslide.Tables[0].Rows[1][1].ToString();
                mtitle3.Text = datasetslide.Tables[0].Rows[2][0].ToString();
                subpic3.ImageLocation = datasetslide.Tables[0].Rows[2][1].ToString();

            }
            else if (datasetslide.Tables[0].Rows.Count == 2)
            {
                mtitle1.Text = datasetslide.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = datasetslide.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = datasetslide.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = datasetslide.Tables[0].Rows[1][1].ToString();
            }
            else if (datasetslide.Tables[0].Rows.Count == 1)
            {
                mtitle1.Text = datasetslide.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = datasetslide.Tables[0].Rows[0][1].ToString();

            }
            else
            {
                mtitle1.Text = "Unavailable";
                mtitle1.Text = "Unavailable";
                mtitle1.Text = "Unavailable";
                mtitle1.Text = "Unavailable";
            }


        }

        private void slidetimer_Tick(object sender, EventArgs e)
        {
            if (slideshowpic1.Visible == true)
            {
                slideshowpic1.Visible = false;
                slidepic2.Visible = true;
            }
            else if (slidepic2.Visible == true)
            {
                slidepic2.Visible = false;
                slidepic3.Visible = true;
            }
            else if (slidepic3.Visible == true)
            {
                slidepic3.Visible = false;
                slidepic4.Visible = true;
            }
            else
            {
                slidepic4.Visible = false;
                slideshowpic1.Visible = true;
            }

        }

        private void swallbtn_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
            }
        }
    }
}
