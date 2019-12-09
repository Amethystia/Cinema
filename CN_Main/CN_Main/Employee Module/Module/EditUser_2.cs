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
        private User_CRUD crud;
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frm_user_employee"];

        public frm_user_employee_2()
        {
            InitializeComponent();
            Clear();
            LoadForm();
        }
        public void LoadForm()
        {
            usr = new Users_Model();
            txt_Nama.Text = ((frm_user_employee)f).txt_Nama.Text;
            txt_Password.Text = ((frm_user_employee)f).txt_Password.Text;
            txt_Status.Text = ((frm_user_employee)f).txt_Status.Text;
            txt_Sex.Text = ((frm_user_employee)f).txt_Sex.Text;
            dtp_BirthDate.Text = ((frm_user_employee)f).dtp_BirthDate.Text;
            rtb_Address.Text = ((frm_user_employee)f).rtb_Address.Text;
            cb_IsEmployee.Checked= ((frm_user_employee)f).cb_IsEmployee.Checked;
            cb_IsEmployee.Text = "ISEmployee";
        }

        public void Clear()
        {
            txt_Nama.Text =
            txt_Password.Text =
            txt_Status.Text =
            txt_Sex.Text =
            dtp_BirthDate.Text =
            rtb_Address.Text =
            cb_IsEmployee.Text =
            string.Empty;
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
            if(cb_IsEmployee.Checked)
            {
                usr.IsEmployee = "1";
            }
            else
            {
                usr.IsEmployee = "0"; 
            }
            usr.UserId = ((frm_user_employee)f).id_user;
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
            usr = new Users_Model();
            if (PerformValidation(gb_Main))
            {
                FRM2BL();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    crud = new User_CRUD();
                    if (crud.Update(usr))
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
                ((frm_user_employee)f).displayTable();
                ((frm_user_employee)f).Clear();
            }
        }

        //public void LoadObject()
        //{
        //    Users_Model um = new Users_Model();
        //    um.Name = txt_Nama.Text;
        //    um.Password = txt_Password.Text;
        //    um.Status = txt_Status.Text;
        //    um.Sex = txt_Sex.Text;
        //    um.BirthDate = dtp_BirthDate.Value;
        //    um.Address = rtb_Address.Text;
        //    um.IsActive = cb_IsEmployee.Checked;
        //}

    }
}
