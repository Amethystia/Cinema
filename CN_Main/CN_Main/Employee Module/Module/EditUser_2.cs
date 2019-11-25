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
    public partial class frm_user_employee_2 : Form
    {
        private Users_Model usr;
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;

        public frm_user_employee_2()
        {
            InitializeComponent();
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
            usr._IsActive = cb_IsEmployee.Checked;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            User_CRUD uc = new User_CRUD();
            Users_Model um = new Users_Model();
            if (uc.Update(um))
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

        public void LoadObject()
        {
            Users_Model um = new Users_Model();
            um.Name = txt_Nama.Text;
            um.Password = txt_Password.Text;
            um.Status = txt_Status.Text;
            um.Sex = txt_Sex.Text;
            um.BirthDate = dtp_BirthDate.Value;
            um.Address = rtb_Address.Text;
            um.IsActive = cb_IsEmployee.Checked;
        }

    }
}
