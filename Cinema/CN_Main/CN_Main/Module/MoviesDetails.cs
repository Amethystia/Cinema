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


        public static int get_number;
        private void FrmMovieDetails_Load(object sender, EventArgs e)
        {
            get_number = FrmMovies.sent_number;

            pictureBox1.Image = Bitmap.FromFile(FrmMovies.list_image_url[get_number].ToString());

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Text += "Movie Name: ";
            textBox1.Text += FrmMovies.list_movie_name[get_number].ToString();
            textBox1.Text += Environment.NewLine + Environment.NewLine + "Imdb: ";
            textBox1.Text += FrmMovies.list_movie_imdb[get_number].ToString();
            textBox1.Text += Environment.NewLine + Environment.NewLine + ("Synopsis: ");
            textBox1.Text += FrmMovies.list_movie_description[get_number].ToString();

        }
       
        public static string movie_name;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
