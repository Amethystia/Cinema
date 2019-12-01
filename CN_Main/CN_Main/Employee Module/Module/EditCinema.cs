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
    public partial class FrmEditCinema : Form
    {
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        private Cinema_CRUD_Service CinemaCRUD;
        private Cinema_Model cinema_Model;
        public string Cinema_Id;
        public FrmEditCinema()
        {
            InitializeComponent();
            loadbutton();
            displaydatagrid();
        }

        [Obsolete]
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (PerformValidation(groupBox1))
                {
                    ATB();
                    CinemaCRUD = new Cinema_CRUD_Service();
                    if (CinemaCRUD.Insert(cinema_Model))
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


        private void btn_Display_Click(object sender, EventArgs e)
        {
            displaydatagrid();
        }
        public void displaydatagrid()
        {
            try
            {
                CinemaCRUD = new Cinema_CRUD_Service();
                dt = CinemaCRUD.get_AllCinemas(dt);
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

        private void dg_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_main.SelectedRows.Count > 0)
            {
                txt_CinemaName.Text = dg_main.SelectedRows[0].Cells["Cinema_Name"].Value.ToString();
                txt_MovieName.Text = dg_main.SelectedRows[0].Cells["Movie_Name"].Value.ToString();
                txt_Theather.Text = dg_main.SelectedRows[0].Cells["Theather"].Value.ToString();
                txt_Time.Text = dg_main.SelectedRows[0].Cells["Time"].Value.ToString();
                txt_Class.Text = dg_main.SelectedRows[0].Cells["Class"].Value.ToString();
            }
        }
        public void ATB()
        {
            cinema_Model = new Cinema_Model();
            cinema_Model.Cinema_Name = txt_CinemaName.Text;
            cinema_Model.Movie_name = txt_MovieName.Text;
            cinema_Model.Theather = txt_Theather.Text;
            cinema_Model.Time = txt_Time.Text;
            cinema_Model.Class = txt_Class.Text;
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
        private void dt_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cinema_Id = dg_main.SelectedRows[0].Cells["Cinema_Id"].Value.ToString();
            if (dg_main.Columns[e.ColumnIndex] == btnDelete)
            {
                bool DialogDel = MessageBox.Show("Are you sure to delete this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    CinemaCRUD = new Cinema_CRUD_Service();
                    if (CinemaCRUD.GetDeleteByID(Cinema_Id))
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
                FrmUpdateCinema frmUpdateCinema = new FrmUpdateCinema();
                frmUpdateCinema.ShowDialog();
            }
        }
    }
}
