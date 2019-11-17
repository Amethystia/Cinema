using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CN_Business;

namespace CN_Main
{
    public partial class FrmCinemas : Form
    {
        private CinemaService cinemaService;
        DataSet dsmovie = new DataSet();
        DataSet datasetduration = new DataSet();
        DataSet datasetcinema = new DataSet();
        DataSet datasetprice = new DataSet();
        DataSet datasettime = new DataSet();
        DataSet datasettheather = new DataSet();
        DataSet datasetclass = new DataSet();
        string result;

        public FrmCinemas()
        {
            InitializeComponent();
            LoadCB_Cinemaname(); // done get movie name
            clearall();
        }

        public void LoadCB_Cinemaname()
        {
            // Disabled Due Change Schema
            //string Movie_Names;
            //Movie_Names = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
                cinemaService = new CinemaService();
                datasetcinema = cinemaService.get_cinemas_data(dsmovie);
                CB_Cinemas.DataSource = datasetcinema.Tables[0];
                CB_Cinemas.DisplayMember = "cinema_name";
        }

        private void CB_Cinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Moviename();
        }

        public void LoadCB_Moviename()
        {
            if (CB_Cinemas.Text != null && CB_Cinemas.Text!="")
            {
                string Cinema_Name;
                Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();

                cinemaService = new CinemaService();
                dsmovie = cinemaService.get_movies_data(dsmovie, Cinema_Name);
                CB_Movie.DataSource = dsmovie.Tables[0];
                CB_Movie.DisplayMember = "movie_name";


                string Movie_Name;
                Movie_Name = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
                datasetduration = cinemaService.get_duration_data(datasetduration, Movie_Name);
                cb_Duration.DataSource = datasetduration.Tables[0];
                cb_Duration.DisplayMember = "duration";
                cb_Duration.Enabled = false;


                datasetclass = cinemaService.get_class_data(datasetclass, Cinema_Name);
                cb_class.DataSource = datasetclass.Tables[0];
                cb_class.DisplayMember = "class";
            }
        }
        private void btn_Request_Click(object sender, EventArgs e)
        {
            BookingService ss = new BookingService();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmLogin"];
            string username = ((FrmLogin)f).txt_UserName.Text;
            bool result = ss.requestcinema(username,CB_Cinemas.Text,CB_Movie.Text,cb_class.Text,dtp_date.Value.ToString("yyyyMMddHHmmss"),txt_Price.Text);
            if (result)
            {
                MessageBox.Show("Request has been Submitted, Transaction cannot be cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Cinemas.Text != null && CB_Cinemas.Text != "")
            {
                cinemaService = new CinemaService();
                string classes;
                classes = datasetclass.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
                string wk = DateTime.Today.DayOfWeek.ToString();
                string Daycode;
                if (wk != "Saturday" && wk != "Sunday")
                {
                    Daycode = "1";
                    result = cinemaService.get_price_data(result, classes, Daycode);
                    int hasil = Convert.ToInt32(result) * 30;
                    result = hasil.ToString();
                    txt_Price.Text = result;
                }
                else
                {
                    Daycode = "2";
                    result = cinemaService.get_price_data(result, classes, Daycode);
                    int hasil = Convert.ToInt32(result) * 30;
                    result = hasil.ToString();
                    txt_Price.Text = result;
                }
            }
        }

        public void clearall()
        {
            txt_Price.Text = cb_Duration.Text = cb_Duration.Text = cb_class.Text = CB_Movie.Text = CB_Cinemas.Text = null;
        }
    }
}
