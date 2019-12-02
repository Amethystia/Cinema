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
    public partial class FrmEditPromotion : Form
    {
        private Promotion_CRUDService promotion_CRUDService;
        private Promotion_Model Promotion_Model;
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;

        public FrmEditPromotion()
        {
            InitializeComponent();
            displaydatagrid();
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
                promotion_CRUDService = new Promotion_CRUDService();
                dt = promotion_CRUDService.get_AllPromotion(dt);
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

        public void ATB()
        {
            string movie = txt_MovieImage.Text;
            if (movie.Contains(@"\"))
            {
                movie.Replace(@"\""", @"'\\\\'");
            }
            Promotion_Model = new Promotion_Model();
            Promotion_Model.Movie_name = txt_MovieName.Text;
            Promotion_Model.Movie_URL = movie;
            Promotion_Model.Promotion_ID = dg_main.SelectedRows[0].Cells["Promotion_Id"].Value.ToString();
        }
        OpenFileDialog file = new OpenFileDialog();
        static string file_path;
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
        private void txt_MovieImage_Click(object sender, EventArgs e)
        {
            getimage();
        }
   
        private void dg_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_main.SelectedRows.Count > 0)
            {
                txt_MovieName.Text = dg_main.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_MovieImage.Text = dg_main.SelectedRows[0].Cells["Picture_URL"].Value.ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Promotion_Model = new Promotion_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    promotion_CRUDService = new Promotion_CRUDService();
                    if (promotion_CRUDService.Update(Promotion_Model))
                    {
                        MessageBox.Show("Data UPDATED !!");
                        displaydatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Data FAILED UPDATED !!");
                        displaydatagrid();
                    }
                }
            }
        }

    }
}
