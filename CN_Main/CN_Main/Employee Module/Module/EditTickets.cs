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
    public partial class FrmEditTickets : Form
    {
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        private Ticket_CRUDService ticketCRUD;
        private Ticket_Model ticket_Model;
        public string ticketid;
        public FrmEditTickets()
        {
            InitializeComponent();
            loadbutton();
            displaydatagrid();
        }


        private void btn_Display_Click(object sender, EventArgs e)
        {
            displaydatagrid();
        }
        public void displaydatagrid()
        {
            try
            {
                ticketCRUD = new Ticket_CRUDService();
                dt = ticketCRUD.get_AllTickets(dt);
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
                txt_DayCode.Text = dg_main.SelectedRows[0].Cells["DayCode"].Value.ToString();
                txt_Price.Text = dg_main.SelectedRows[0].Cells["Price"].Value.ToString();
                txt_Type.Text = dg_main.SelectedRows[0].Cells["Type"].Value.ToString();
            }
        }
        public void ATB()
        {
            ticket_Model = new Ticket_Model();
            ticket_Model.DayCode = txt_DayCode.Text;
            ticket_Model.Price = txt_Price.Text;
            ticket_Model.Type = txt_Type.Text;
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

        [Obsolete]
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (PerformValidation(groupBox1))
                {
                    ATB();
                    ticketCRUD = new Ticket_CRUDService();
                    if (ticketCRUD.Insert(ticket_Model))
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

        private void dt_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketid = dg_main.SelectedRows[0].Cells["code"].Value.ToString();
            if (dg_main.Columns[e.ColumnIndex] == btnDelete)
            {
                bool DialogDel = MessageBox.Show("Are you sure to delete this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    ticketCRUD = new Ticket_CRUDService();
                    if (ticketCRUD.GetDeleteByID(ticketid))
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
                FrmUpdateTickets frmUpdateTickets = new FrmUpdateTickets();
                frmUpdateTickets.ShowDialog();
            }
        }
    }
}
