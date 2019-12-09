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
    public partial class FrmUpdateTickets : Form
    {
        private Ticket_CRUDService ticketCRUD;
        private Ticket_Model ticket_Model;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmEditTickets"];
        public FrmUpdateTickets()
        {
            InitializeComponent();
            clear();
            LoadForm();
        }
        public void ATB()
        {
            ticket_Model = new Ticket_Model();
            ticket_Model.DayCode = txt_DayCode.Text;
            ticket_Model.Price = txt_Price.Text;
            ticket_Model.Type = txt_Type.Text;
            ticket_Model.ticketid = ((FrmEditTickets)f).ticketid;
        }

        public void LoadForm()
        {
            ticket_Model = new Ticket_Model();
            txt_DayCode.Text = ((FrmEditTickets)f).txt_DayCode.Text;
            txt_Price.Text = ((FrmEditTickets)f).txt_Price.Text;
            txt_Type.Text = ((FrmEditTickets)f).txt_Type.Text;
        }
        public void clear()
        {
            txt_DayCode.Text =
            txt_Price.Text =
            txt_Type.Text = string.Empty;
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
            ticket_Model = new Ticket_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    ticketCRUD = new Ticket_CRUDService();
                    if (ticketCRUD.Update(ticket_Model))
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
                ((FrmEditTickets)f).displaydatagrid();
            }
        }

    }
}
