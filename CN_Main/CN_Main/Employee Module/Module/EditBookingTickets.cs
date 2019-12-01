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
    public partial class FrmEditBookingTickets : Form
    {
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        private BookingTicket_CRUDService bookingticketCRUD;
        private BookingTicket_Model BookingTicket_Model;
        public string booking_TicketId;
        public FrmEditBookingTickets()
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
                bookingticketCRUD = new BookingTicket_CRUDService();
                dt = bookingticketCRUD.get_AllBooking(dt);
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
                txt_BookBy.Text = dg_main.SelectedRows[0].Cells["Book_By"].Value.ToString();
                txt_CinemaName.Text = dg_main.SelectedRows[0].Cells["Cinema_Name"].Value.ToString();
                txt_Theather.Text = dg_main.SelectedRows[0].Cells["Theather"].Value.ToString();
                txt_MovieName.Text = dg_main.SelectedRows[0].Cells["Movie_name"].Value.ToString();
                txt_Time.Text = dg_main.SelectedRows[0].Cells["Time"].Value.ToString();
                txt_SeatNumber.Text = dg_main.SelectedRows[0].Cells["Seat_Number"].Value.ToString();
                txt_Price.Text = dg_main.SelectedRows[0].Cells["Price"].Value.ToString();
                txt_BookOn.Text = dg_main.SelectedRows[0].Cells["BookedOn"].Value.ToString();
            }
        }
        public void ATB()
        {
            BookingTicket_Model = new BookingTicket_Model();
            BookingTicket_Model.Book_By = txt_BookBy.Text;
            BookingTicket_Model.Cinema_Name = txt_CinemaName.Text;
            BookingTicket_Model.Theather = txt_Theather.Text;
            BookingTicket_Model.Movie_Name = txt_MovieName.Text;
            BookingTicket_Model.Time = txt_Time.Text;
            BookingTicket_Model.Seat_Number = txt_SeatNumber.Text;
            BookingTicket_Model._Price = txt_Price.Text;
            BookingTicket_Model.BookOn = txt_BookOn.Text;
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

        [Obsolete]
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (PerformValidation(groupBox1))
                {
                    ATB();
                    bookingticketCRUD = new BookingTicket_CRUDService();
                    if (bookingticketCRUD.Insert(BookingTicket_Model))
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
            booking_TicketId = dg_main.SelectedRows[0].Cells["Ticket_BookId"].Value.ToString();
            if (dg_main.Columns[e.ColumnIndex] == btnDelete)
            {
                bool DialogDel = MessageBox.Show("Are you sure to delete this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    bookingticketCRUD = new BookingTicket_CRUDService();
                    if (bookingticketCRUD.GetDeleteByID(booking_TicketId))
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
                FrmUpdateBookingTickets frmUpdateBookingTickets = new FrmUpdateBookingTickets();
                frmUpdateBookingTickets.ShowDialog();
            }
        }
    }
}
