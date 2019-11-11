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
    public partial class FrmMovies : Form
    {
        public FrmMovies()
        {
            InitializeComponent();
        }

        PictureBox[] images = new PictureBox[8];
        public static ArrayList list_image_url = new ArrayList();
        public static ArrayList list_movie_name = new ArrayList();
        public static ArrayList list_movie_imdb = new ArrayList();
        public static ArrayList list_movie_description = new ArrayList();
        int b = 0;
        int c = 0;
        public static int j = 0;
        int[] movie_images_b;
        int[] movie_images_j;
        int max_count;
        public static int sent_number;

        private void FrmMovies_Load(object sender, EventArgs e)
        {
            list_image_url.Clear();
            list_movie_name.Clear();
            list_movie_imdb.Clear();
            list_movie_description.Clear();
            btn_Previous.Visible = false;

            images = new PictureBox[] {pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,
                pictureBox6,pictureBox7,pictureBox8};

            DBConnection cla = new DBConnection();
            DataTable tab = cla.table_get_data("select * from Movies");

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                list_movie_name.Add(tab.Rows[i][1]);
                list_movie_imdb.Add(tab.Rows[i][2]);
                list_movie_description.Add(tab.Rows[i][3]);
                list_image_url.Add(tab.Rows[i][4]);
            }

            max_count = tab.Rows.Count;

            if (tab.Rows.Count % 8 == 0)
            {
                movie_images_b = new int[tab.Rows.Count / 8];
                movie_images_j = new int[tab.Rows.Count / 8];
            }
            else
            {
                movie_images_b = new int[(tab.Rows.Count / 8) + 1];
                movie_images_j = new int[(tab.Rows.Count / 8) + 1];
            }

            for (int i = 0; i < movie_images_b.Length; i++)
            {
                if (b + 1 < max_count)
                {
                    movie_images_b[i] = 8 * i;
                    movie_images_j[i] = 8 * (i + 1);
                    b += 1;
                }
                else
                {
                    movie_images_b[i] = b;
                    movie_images_j[i] = max_count;
                }
            }
            get_images();
        }

        private void get_images()
        {
            images_hide();
            for (int i = movie_images_b[j]; i < movie_images_j[j]; i++)
            {
                images[c].Visible = true;
                images[c].Image = Bitmap.FromFile(list_image_url[i].ToString());
                images[c].Tag = i;
                c++;
            }
            c = 0;
        }

        private void images_hide()
        {

            for (int i = 0; i < images.Length; i++)
            {
                images[i].Visible = false;
            }

        }


        #region picturebox
        private void btn_Next_Click(object sender, EventArgs e)
        {
            btn_Previous.Visible = true;
            btn_Next.Visible = false;

            if (j < movie_images_b.Length - 1)
            {
                j++;
                get_images();

            }
            else
            {
                j = 0;
                get_images();

            }
        }
        private void btn_Previous_Click(object sender, EventArgs e)
        {
            btn_Previous.Visible = false;
            btn_Next.Visible = true;
            if (j > 0)
            {
                j--;
                get_images();

            }
            else
            {
                j = movie_images_b.Length - 1;
                get_images();

            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox picture;

            if (sender is PictureBox)
            {
                picture = sender as PictureBox;

                picture.Width = 150;
                picture.Height = 180;
            }

        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picture;

            if (sender is PictureBox)
            {
                picture = sender as PictureBox;

                picture.Width = 120;
                picture.Height = 150;
            }
        }
        private void picture_click(object sender, EventArgs e)
        {
            
            PictureBox click;

            if (sender is PictureBox)
            {
                click = sender as PictureBox;

                sent_number = Convert.ToInt16(click.Tag);

                FrmMovieDetails frm = new FrmMovieDetails();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();

            }

        }
        #endregion 
    }
}
