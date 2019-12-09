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
        public string id_user;
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
            if (cb_IsEmployee.Checked)
            {
                usr.IsEmployee = "1";
            }
            else
            {
                usr.IsEmployee = "0";
            }
            id_user = dgv.SelectedRows[0].Cells["user_id"].Value.ToString();
            usr.UserId = id_user;
        }

        public void Clear()
        {

            txt_Nama.Text =
            txt_Password.Text =
            txt_Status.Text =
            txt_Sex.Text =
            rtb_Address.Text = string.Empty;
            cb_IsEmployee.Checked = false;
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

        public void displayTable()
        {
            try
            {
                User_CRUD CRUD = new User_CRUD();
                dt = CRUD.getAllData();
                dgv.DataSource = null;
                dgv.DataSource = dt;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                txt_Nama.Text = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_Password.Text = dgv.SelectedRows[0].Cells["Password"].Value.ToString();
                txt_Status.Text = dgv.SelectedRows[0].Cells["Status"].Value.ToString();
                txt_Sex.Text = dgv.SelectedRows[0].Cells["Sex"].Value.ToString();
                dtp_BirthDate.Text = dgv.SelectedRows[0].Cells["BirthDate"].Value.ToString();
                rtb_Address.Text = dgv.SelectedRows[0].Cells["Address"].Value.ToString();
                if (dgv.SelectedRows[0].Cells["IsEmployee"].Value.ToString() == "True"){
                    cb_IsEmployee.Checked = true;
                }
                else
                {
                    cb_IsEmployee.Checked = false;
                }
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
