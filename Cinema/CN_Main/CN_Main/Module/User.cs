using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN_Modeling;
using CN_Business;

namespace CN_Main
{
    public partial class frm_user : Form
    {
        private Users_Model usr;
        public frm_user()
        {
            InitializeComponent();
        }
        private void BL2FRM()
        {
            usr = new Users_Model();
            txt_Nama.Text = usr._Name;
            txt_Password.Text = usr._Password;
            txt_Status.Text = usr._Status;
            txt_Sex.Text = usr._Sex;
            dtp_BirthDate.Value = usr._BirthDate;
            rtb_Address.Text = usr._Address;
            cb_IsActive.Checked = usr._IsActive;
        }

        private void FRM2BL()
        {
            usr = new Users_Model();
            usr._Name = txt_Nama.Text;
            usr._Password= txt_Password.Text;
            usr._Status = txt_Status.Text;
            usr._Sex = txt_Sex.Text;
            usr._BirthDate = dtp_BirthDate.Value;
            usr._Address = rtb_Address.Text;
            usr._IsActive = cb_IsActive.Checked;
        }

        private bool PerformValidation(GroupBox gb)
        {
            foreach (Control c in gb.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (c is TextBox || c is ComboBox || c is RichTextBox )
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            PerformValidation(gb_Main);
            FRM2BL();
            User_CRUD CRUD = new User_CRUD();
            CRUD.Insert(usr);
        }
    }
}
