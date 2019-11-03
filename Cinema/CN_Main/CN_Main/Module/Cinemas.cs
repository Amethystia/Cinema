using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CN_Business;

namespace CN_Main
{
    public partial class FrmCinemas : Form
    {
        private CinemaService cinemaService;
        MySqlConnection cs = new MySqlConnection("Data Source='localhost';initial catalog= cinema_simd;integrated Security=true");
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        

        public FrmCinemas()
        {
            InitializeComponent();
            LoadCB_Moviename();
        }

        public void LoadCB_Moviename()
        {
            cinemaService = new CinemaService();
            ds = cinemaService.get_movies_data(ds);
            CB_Movie.DataSource = ds.Tables[0];
            CB_Movie.DisplayMember = "movie_name";
        }

        private void CB_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        public void LoadCB_Cinemaname()
        {
            string Movie_Names;
            Movie_Names = ds.Tables[0].Rows[CB_Movie.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            ds = cinemaService.get_cinemas_data(ds, Movie_Names);
            CB_Cinemas.DataSource = ds.Tables[0];
            CB_Cinemas.DisplayMember = "cinema_name";
        }

        public void LoadCB_Date()
        {
            string Cinema_Name;
            Cinema_Name = ds.Tables[0].Rows[CB_Cinemas.SelectedIndex][0].ToString();

            cinemaService = new CinemaService();
            ds = cinemaService.get_cinemas_data(ds, Cinema_Name);
            CB_Cinemas.DataSource = ds.Tables[0];
            CB_Cinemas.DisplayMember = "cinema_name";
        }

        private void CB_Cinemas_DropDownClosed(object sender, EventArgs e)
        {
           
        }
    }
}
