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
    public partial class frm_user_employee : Form
    {
        private Users_Model usr;
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;

        public frm_user_employee()
        {
            InitializeComponent();
            btnEdit = new DataGridViewButtonColumn();
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 70;
            btnEdit.Text = "Edit";
            dgv.Columns.Add(btnEdit);
            btnDelete = new DataGridViewButtonColumn();

            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 70;
            btnDelete.Text = "Delete";
            dgv.Columns.Add(btnDelete);
            displayTable();
        }


        private void FRM2BL()
        {
            usr = new Users_Model();
            usr._Name = txt_Nama.Text;
            usr._Password = txt_Password.Text;
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


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            displayTable();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            PerformValidation(gb_Main);
            FRM2BL();
            User_CRUD CRUD = new User_CRUD();
            CRUD.Insert(usr);
            MessageBox.Show("Registered Successfully!");
            displayTable();
        }

        private void displayTable()
        {
            try
            {
                User_CRUD CRUD = new User_CRUD();
                dt = CRUD.getAllData();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }

        private void dt_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string KodeProduct = dgv.SelectedRows[0].Cells["User_Id"].Value.ToString();
            if (dgv.Columns[e.ColumnIndex] == btnDelete)
            {
                bool DialogDel = MessageBox.Show("Are you sure to delete this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    User_CRUD CRUD = new User_CRUD();
                    if (CRUD.GetDeleteByID(KodeProduct))
                    {
                        MessageBox.Show("Data For ID: " + KodeProduct + " DELETED !!");
                    }
                    else
                    {
                        MessageBox.Show("Data For ID " + KodeProduct + " FAILED TO DELETE !!");
                    }
                    displayTable();
                }
            }
            else if (dgv.Columns[e.ColumnIndex] == btnEdit)
            {
                FRM2BL();
                frm_user_employee_2 frmEditProduct = new frm_user_employee_2();
                frmEditProduct.ShowDialog();
            }
        }
    }
}
