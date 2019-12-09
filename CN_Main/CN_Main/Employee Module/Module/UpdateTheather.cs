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
    public partial class FrmUpdateTheather : Form
    {
        private Theather_CRUDService theatherCRUD;
        private Theather_Model theather_Model;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmEditTheather"];
        public FrmUpdateTheather()
        {
            InitializeComponent();
            clear();
            LoadForm();
        }

   
        public void ATB()
        {
            theather_Model = new Theather_Model();
            theather_Model.cinema = txt_Cinema.Text;
            theather_Model.theather_name = txt_TheatherName.Text;
            theather_Model.seats = txt_Seats.Text;
            theather_Model.theather_id = ((FrmEditTheather)f).theather_Id;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            theather_Model = new Theather_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    theatherCRUD = new Theather_CRUDService();
                    if (theatherCRUD.Update(theather_Model))
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
                ((FrmEditTheather)f).displaydatagrid();
            }
        }
            public void LoadForm()
        {
            theather_Model = new Theather_Model();
            txt_Cinema.Text = ((FrmEditTheather)f).txt_Cinema.Text;
            txt_Seats.Text = ((FrmEditTheather)f).txt_Seats.Text;
            txt_TheatherName.Text = ((FrmEditTheather)f).txt_TheatherName.Text;
        }
        public void clear()
        {
            txt_Cinema.Text =
            txt_Seats.Text =
            txt_TheatherName.Text = string.Empty;
        }
    }
}
