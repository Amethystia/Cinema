using System;
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
        DataSet datasetcinemaid= new DataSet();
        public static int get_number;
        private void FrmMovieDetails_Load(object sender, EventArgs e)
        {
            get_number = FrmMovies.sent_number;
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

        public static string movie_name,theather,cinemaid;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Cinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB_Time();

        }

        public void LoadCB_Time()
        {
            string movieName = FrmMovies.list_movie_name[get_number].ToString();
            string Cinema_Name = datasetcinema.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();
            cinemaService = new CinemaService();
            datasettime = cinemaService.get_times_data(dsmovie, Cinema_Name, movieName);
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
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasettheather = cinemaService.get_theater_data(dsmovie, Cinema_Name, movieName, Time);
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
            string Time;
            Time = datasettime.Tables[0].Rows[CB_Time.SelectedIndex][0].ToString();
            string Theather;
            Theather = datasettheather.Tables[0].Rows[CB_Theather.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            datasetclass = cinemaService.get_class_data(dsmovie, Cinema_Name, movieName, Time, Theather);
            datasetcinemaid = cinemaService.get_cinemaid_data(dsmovie, Cinema_Name, movieName,Time, Theather);
            cinemaid = datasetcinemaid.ToString();
            CB_Class.DataSource = datasetclass.Tables[0];
            CB_Class.DisplayMember = "class";
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            movie_name = FrmMovies.list_movie_name[get_number].ToString();
            theather = datasettheather.Tables[0].Rows[CB_Theather.SelectedIndex][0].ToString();

            FrmSeats frm = new FrmSeats(this);
            frm.Show();
        }
    }
}
