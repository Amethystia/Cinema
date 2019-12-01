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
    public partial class FrmUpdateBookingTickets : Form
    {
        DataTable dt;
        private DataGridViewButtonColumn btnEdit, btnDelete;
        private BookingTicket_CRUDService bookingticketCRUD;
        private BookingTicket_Model BookingTicket_Model;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmEditBookingTickets"];
        public FrmUpdateBookingTickets()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            BookingTicket_Model = new BookingTicket_Model();
            txt_BookBy.Text = ((FrmEditBookingTickets)f).txt_BookBy.Text;
            txt_CinemaName.Text = ((FrmEditBookingTickets)f).txt_CinemaName.Text;
            txt_Theather.Text = ((FrmEditBookingTickets)f).txt_Theather.Text;
            txt_MovieName.Text = ((FrmEditBookingTickets)f).txt_MovieName.Text;
            txt_Time.Text = ((FrmEditBookingTickets)f).txt_Time.Text;
            txt_SeatNumber.Text = ((FrmEditBookingTickets)f).txt_SeatNumber.Text;
            txt_Price.Text = ((FrmEditBookingTickets)f).txt_Price.Text;
            txt_BookOn.Text = ((FrmEditBookingTickets)f).txt_BookOn.Text;
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
            BookingTicket_Model.Ticket_bookId = ((FrmEditBookingTickets)f).booking_TicketId;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            BookingTicket_Model = new BookingTicket_Model();
            if (PerformValidation(groupBox1))
            {
                ATB();
                bool DialogDel = MessageBox.Show("Are you sure to EDIT this Data", "EDIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (DialogDel)
                {
                    bookingticketCRUD = new BookingTicket_CRUDService();
                    if (bookingticketCRUD.Update(BookingTicket_Model))
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
                ((FrmEditBookingTickets)f).displaydatagrid();
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

    }
}
