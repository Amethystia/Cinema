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
    public partial class FrmUpdateMovie : Form
    {
        private Movie_Model movie_Model;
        private Movie_CRUDService movie_CRUDService;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmEditMovie"];
        public FrmUpdateMovie()
        {
            InitializeComponent();
            LoadForm();
        }
        private bool PerformValidation(GroupBox gb)
        {
            foreach (Control c in gb.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (c is TextBox || c is ComboBox || c is RichTextBox)
                {
                    //if (txt_SlideImage.Text != string.Empty)
                    //{
                        if (string.IsNullOrWhiteSpace(c.Text))
                        {
                            MessageBox.Show(string.Format("Empty field {0 }", c.Name.Substring(4)));
                            c.Focus();
                            return false;
                        }
                    //}
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

        public void LoadForm()
        {
            movie_Model = new Movie_Model();
            txt_MovieName.Text = ((FrmEditMovie)f).txt_MovieName.Text;
            txt_MovieIMDB.Text = ((FrmEditMovie)f).txt_MovieIMDB.Text;
            txt_MovieDescription.Text = ((FrmEditMovie)f).txt_MovieDescription.Text;
            //txt_MovieImage.Text = ((FrmEditMovie)f).txt_MovieImage.Text;
            //txt_SlideImage.Text = ((FrmEditMovie)f).txt_SlideImage.Text;
            txt_Duration.Text = ((FrmEditMovie)f).txt_Duration.Text;
            dtp_ReleaseDate.Value = ((FrmEditMovie)f).dtp_ReleaseDate.Value;
            txt_IsReleased.Text = ((FrmEditMovie)f).txt_IsReleased.Text;
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
                //txt_MovieImage.Text = file_path;
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
                //txt_SlideImage.Text = file_path2;
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

        [Obsolete]
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            movie_Model = new Movie_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    movie_CRUDService = new Movie_CRUDService();
                    if (movie_CRUDService.Update(movie_Model))
                    {
                        MessageBox.Show("Data UPDATED !!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data FAILED UPDATED !!");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Password !!");
                }
                ((FrmEditMovie)f).displaydatagrid();
            }
        }
        public void ATB()
        {

            //string slide = txt_SlideImage.Text;
            //if (slide.Contains(@"\"))
            //{
            //    slide.Replace(@"\""", @"'\\'");
            //}

            //string movie = txt_MovieImage.Text;
            //if (movie.Contains(@"\"))
            //{
            //    movie.Replace(@"\""", @"'\\\\'");
            //}
            movie_Model = new Movie_Model();
            movie_Model.MovieName = txt_MovieName.Text;
            movie_Model.MovieIMDB = txt_MovieIMDB.Text;
            movie_Model.MovieDescription = txt_MovieDescription.Text;
            //movie_Model.MovieImage = movie;
            //movie_Model.SlideImage = slide;
            movie_Model.Duration = txt_Duration.Text;
            movie_Model.ReleasedDate = dtp_ReleaseDate.Value.ToString("yyyy-MM-dd");
            if (txt_IsReleased.Text == "True") { movie_Model.IsReleased = "1"; } else { movie_Model.IsReleased = "0"; };
            movie_Model.MovieID = ((FrmEditMovie)f).Movie_Id;
        }

    }
}
