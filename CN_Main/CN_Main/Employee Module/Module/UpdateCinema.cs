using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN_Business;
using CN_Modeling;

namespace CN_Main
{
    public partial class FrmUpdateCinema : Form
    {
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        private Cinema_CRUD_Service CinemaCRUD;
        private Cinema_Model cinema_Model;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmEditCinema"];
        public FrmUpdateCinema()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            cinema_Model = new Cinema_Model();
            txt_CinemaName.Text = ((FrmEditCinema)f).txt_CinemaName.Text;
            txt_MovieName.Text = ((FrmEditCinema)f).txt_MovieName.Text;
            txt_Theather.Text = ((FrmEditCinema)f).txt_Theather.Text;
            txt_Time.Text = ((FrmEditCinema)f).txt_Time.Text;
            txt_Class.Text = ((FrmEditCinema)f).txt_Class.Text;
        }
        public void ATB()
        {
            cinema_Model = new Cinema_Model();
            cinema_Model.Cinema_Name = txt_CinemaName.Text;
            cinema_Model.Movie_name = txt_MovieName.Text;
            cinema_Model.Theather = txt_Theather.Text;
            cinema_Model.Time = txt_Time.Text;
            cinema_Model.Class = txt_Class.Text;
            cinema_Model.Cinema_Id = ((FrmEditCinema)f).Cinema_Id;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            cinema_Model = new Cinema_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    CinemaCRUD = new Cinema_CRUD_Service();
                    if (CinemaCRUD.Update(cinema_Model))
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
                ((FrmEditCinema)f).displaydatagrid();
            }
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
    }
}
