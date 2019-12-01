using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CN_Business;
using CN_Modeling;

namespace CN_Main
{
    public partial class FrmEditMovie : Form
    {
        private CinemaService CinemaService;
        private Movie_CRUDService Movie_CRUDService;
        private Movie_Model movie_Model;
        public string Movie_Id;
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;

        public FrmEditMovie()
        {
            InitializeComponent();
            loadbutton();
            displaydatagrid();
        }
        private void loadbutton()
        {

            btnEdit = new DataGridViewButtonColumn();
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 50;
            btnEdit.Text = "Edit";
            dg_main.Columns.Add(btnEdit);
            btnDelete = new DataGridViewButtonColumn();

            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 50;
            btnDelete.Text = "Delete";
            dg_main.Columns.Add(btnDelete);
        }
        private bool PerformValidation(GroupBox gb)
        {
            foreach (Control c in gb.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (c is TextBox || c is ComboBox || c is RichTextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show(string.Format("Empty field {0 }", c.Name.Substring(4)));
                        c.Focus();
                        return false;
                    }
                }
                else if (c is RadioButton)
                {
                    //handle me
                    return false;
                }
                else if (c is CheckBox)
                {
                    //handle me
                    return false;
                }
            }
            return true;
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            displaydatagrid();
        }

        public void displaydatagrid()
        {
            try
            {
                CinemaService = new CinemaService();
                dt = CinemaService.get_ALLMovies(dt);
                dg_main.DataSource = null;
                dg_main.DataSource = dt;
                dg_main.AllowUserToAddRows = false;
                dg_main.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }

        [Obsolete]
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (PerformValidation(groupBox1))
                {
                    ATB();
                    CinemaService = new CinemaService();
                    if (CinemaService.Insert(movie_Model))
                    {
                        MessageBox.Show("Data Saved");
                        displaydatagrid();
                    }
                    else
                    {
                        MessageBox.Show("ERROR,Data Failed To Saved");
                        displaydatagrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }
        public void ATB()
        {
            
            string slide = txt_SlideImage.Text;
            if (slide.Contains(@"\"))
            {
                slide.Replace(@"\""", @"'\\'");
            }

            string movie = txt_MovieImage.Text;
            if (movie.Contains(@"\"))
            {
                movie.Replace(@"\""", @"'\\\\'");
            }
            movie_Model = new Movie_Model();
            movie_Model.MovieName = txt_MovieName.Text;
            movie_Model.MovieIMDB = txt_MovieIMDB.Text;
            movie_Model.MovieDescription = txt_MovieDescription.Text;
            movie_Model.MovieImage = movie;
            movie_Model.SlideImage = slide;
            movie_Model.Duration = txt_Duration.Text;
            movie_Model.ReleasedDate = dtp_ReleaseDate.Value.ToString("yyyy-MM-dd");
            if (txt_IsReleased.Text == "True") { movie_Model.IsReleased = "1"; } else { movie_Model.IsReleased = "0"; };
        }
        OpenFileDialog file = new OpenFileDialog();
        static string file_path, file_path2;
        public void getimage()
        {

            file.ShowDialog();
            if (!String.IsNullOrEmpty(file.FileName))
            {
                Bitmap bitmap = new Bitmap(file.FileName);

                if (Directory.Exists(Directory.GetCurrentDirectory() + @"\image"))
                {
                    bitmap.Save(Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName);
                    file_path = Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName;
                }
                else
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\image");
                    bitmap.Save(Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName);
                    file_path = Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName;
                }
                txt_MovieImage.Text = file_path;
            }
        }
        public void getimage2()
        {

            file.ShowDialog();
            if (!String.IsNullOrEmpty(file.FileName))
            {
                Bitmap bitmap2 = new Bitmap(file.FileName);

                if (Directory.Exists(Directory.GetCurrentDirectory() + @"\image"))
                {
                    bitmap2.Save(Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName);
                    file_path2 = Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName;
                }
                else
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\image");
                    bitmap2.Save(Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName);
                    file_path2 = Directory.GetCurrentDirectory() + @"\image\" + file.SafeFileName;
                }
                txt_SlideImage.Text = file_path2;
            }
        }
        private void txt_MovieImage_Click(object sender, EventArgs e)
        {
            getimage();
        }
        private void txt_SlideImage_Click(object sender, EventArgs e)
        {
            getimage2();
        }
        private void dg_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_main.SelectedRows.Count > 0)
            {
                txt_MovieName.Text = dg_main.SelectedRows[0].Cells["Movie_Name"].Value.ToString();
                txt_MovieIMDB.Text = dg_main.SelectedRows[0].Cells["Movie_IMDB"].Value.ToString();
                txt_MovieDescription.Text = dg_main.SelectedRows[0].Cells["Movie_Description"].Value.ToString();
                txt_MovieImage.Text = dg_main.SelectedRows[0].Cells["Movie_Image"].Value.ToString();
                txt_SlideImage.Text = dg_main.SelectedRows[0].Cells["Slide_Image"].Value.ToString();
                txt_Duration.Text = dg_main.SelectedRows[0].Cells["Duration"].Value.ToString();
                dtp_ReleaseDate.Text = dg_main.SelectedRows[0].Cells["Release_Date"].Value.ToString();
                txt_IsReleased.Text = dg_main.SelectedRows[0].Cells["IsReleased"].Value.ToString();
            }
        }

        private void dt_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Movie_Id = dg_main.SelectedRows[0].Cells["Movie_Id"].Value.ToString();
            if (dg_main.Columns[e.ColumnIndex] == btnDelete)
            {
                bool DialogDel = MessageBox.Show("Are you sure to delete this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    Movie_CRUDService = new Movie_CRUDService();
                    if (Movie_CRUDService.GetDeleteByID(Movie_Id))
                    {
                        MessageBox.Show("Data DELETED !!");
                    }
                    else
                    {
                        MessageBox.Show("Data FAILED TO DELETE !!");
                    }
                    displaydatagrid();
                }
            }
            else if (dg_main.Columns[e.ColumnIndex] == btnEdit)
            {
                ATB();
                FrmUpdateMovie frmupdateMovie = new FrmUpdateMovie();
                frmupdateMovie.ShowDialog();
            }
        }

    }
}
