﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CN_Business;

namespace CN_Main
{
    public partial class FrmMovieDetails : Form
    {
        public FrmMovieDetails()
        {
            InitializeComponent();
        }

        private CinemaService cinemaService;
        DataSet dsmovie = new DataSet();
        DataSet datasetduration = new DataSet();
        DataSet datasetcinema = new DataSet();
        DataSet datasetdate = new DataSet();
        DataSet datasettime = new DataSet();
        DataSet datasettheather = new DataSet();
        DataSet datasetclass = new DataSet();
        public static int get_number;
        private void FrmMovieDetails_Load(object sender, EventArgs e)
        {
            get_number = FrmMovies.sent_number;
            //Time2.Text = FrmMovies.list_movie_time2[get_number].ToString();
            //Time3.Text = FrmMovies.list_movie_time3[get_number].ToString();
            pictureBox1.Image = Bitmap.FromFile(FrmMovies.list_image_url[get_number].ToString());

            textBox1.ScrollBars = ScrollBars.Both;
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            textBox1.Text += "Movie Name: ";
            textBox1.Text += movieName;
            textBox1.Text += Environment.NewLine + Environment.NewLine + "Imdb: ";
            textBox1.Text += FrmMovies.list_movie_imdb[get_number].ToString();
            textBox1.Text += Environment.NewLine + Environment.NewLine + ("Synopsis: ");
            textBox1.Text += FrmMovies.list_movie_description[get_number].ToString();


            cinemaService = new CinemaService();
            datasetcinema = cinemaService.get_moviedetail_data(datasetcinema, movieName);
            CB_Cinemas.DataSource = datasetcinema.Tables[0];
            CB_Cinemas.DisplayMember = "cinema_name";
        }

        public static string movie_name;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Cinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Date();
        }

        public void LoadCB_Date()
        {
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            string Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasetdate = cinemaService.get_dates_data(dsmovie, Cinema_Name, movieName);
            CB_Date.DataSource = datasetdate.Tables[0];
            CB_Date.DisplayMember = "date";
        }

        private void CB_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Time();
        }

        public void LoadCB_Time()
        {
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            string Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasettime = cinemaService.get_times_data(dsmovie, Cinema_Name, movieName, Date);
            CB_Time.DataSource = datasettime.Tables[0];
            CB_Time.DisplayMember = "time";
        }
        private void cb_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Theater();
        }

        public void LoadCB_Theater()
        {
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            string Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasettheather = cinemaService.get_theater_data(dsmovie, Cinema_Name, movieName, Date, Time);
            CB_Theather.DataSource = datasettheather.Tables[0];
            CB_Theather.DisplayMember = "theather";
        }

        private void CB_Theather_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Class();
        }

        public void LoadCB_Class()
        {
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            string Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            string Date;
            Date = datasetdate.Tables[0].Rows[CB_Date.SelectedIndex][0].ToString();
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();
            string Theather;
            Theather = datasettheather.Tables[0].Rows[CB_Theather.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasetclass = cinemaService.get_class_data(dsmovie, Cinema_Name, movieName, Date, Time, Theather);
            CB_Class.DataSource = datasetclass.Tables[0];
            CB_Class.DisplayMember = "class";
        }

    }
}
