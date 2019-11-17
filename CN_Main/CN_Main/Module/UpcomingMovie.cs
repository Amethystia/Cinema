using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CN_Business;

namespace CN_Main
{
    public partial class FrmUpcomingMovie : Form
    {
        private CinemaService cinemaService;
        DataSet dsmovie = new DataSet();
        DataSet datasetduration = new DataSet();
        DataSet datasetcinema = new DataSet();
        DataSet datasetdate = new DataSet();
        DataSet datasettime = new DataSet();
        DataSet datasettheather = new DataSet();
        DataSet datasetclass = new DataSet();

        public FrmUpcomingMovie()
        {
            InitializeComponent();
            LoadCB_Cinemaname(); // done get movie name

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
        }
        private void CB_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Date();
        }

        public void LoadCB_Date()
        {
            string Movie_Name;
            Movie_Name = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
            string Cinema_Name;
            Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasetdate = cinemaService.get_dates_data(dsmovie, Cinema_Name, Movie_Name);
            CB_Date.DataSource = datasetdate.Tables[0];
            CB_Date.DisplayMember = "date";
        }


        public void LoadCB_Time()
        {
            string Movie_Name;
            Movie_Name = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
            string Cinema_Name;
            Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasettime = cinemaService.get_times_data(dsmovie, Cinema_Name, Movie_Name, Date);
            CB_Time.DataSource = datasettime.Tables[0];
            CB_Time.DisplayMember = "time";
        }

        private void CB_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Time();
        }
        public void LoadCB_Theater()
        {
            string Movie_Name;
            Movie_Name = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
            string Cinema_Name;
            Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasettheather = cinemaService.get_theater_data(dsmovie, Cinema_Name, Movie_Name, Date, Time);
            CB_Theather.DataSource = datasettheather.Tables[0];
            CB_Theather.DisplayMember = "theather";
        }

        private void CB_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Theater();
        }
        public void LoadCB_Class()
        {
            string Movie_Name;
            Movie_Name = dsmovie.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();
            string Cinema_Name;
            Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();
            string Theather;
            Theather = datasettheather.Tables[0].Rows[CB_Theather.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasetclass = cinemaService.get_class_data(dsmovie, Cinema_Name, Movie_Name, Date, Time, Theather);
            CB_Class.DataSource = datasetclass.Tables[0];
            CB_Class.DisplayMember = "class";
        }

        private void CB_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Class();
        }

       
    }
}
