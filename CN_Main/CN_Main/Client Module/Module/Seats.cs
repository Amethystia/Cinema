using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using CN_Business;

namespace CN_Main
{
    public partial class FrmSeats : Form
    {
        DataTable dataTable = new DataTable();
        DataTable salesTable = new DataTable();
        public FrmMovieDetails  md;
        string result;


        public FrmSeats(FrmMovieDetails InheritMDi)
        {
            InitializeComponent();
            md = InheritMDi;
            loadTicketData();
        }

      

        private void lounges_click(object sender, EventArgs e)
        {
            Button btn;

            if (panel2.Width == 65)
            {
                panel2.Visible = true;
                panel2.Width = 225;

                if (sender is Button)
                {
                    btn = sender as Button;
                    Txt_Seats.Clear();
                    Txt_Seats.SelectedText = btn.Text;
                }
            }
            else
            {
                if (sender is Button)
                {
                    btn = sender as Button;
                    Txt_Seats.Clear();
                    Txt_Seats.SelectedText = btn.Text;
                }
            }
        }

        Button[] seat = new Button[36];
        Label[] seat_number_label = new Label[4];

        int seat_number = 1;

        ArrayList seats = new ArrayList();
        int full_seat;

        private void Cinema_Load(object sender, EventArgs e)
        {
            txt_ticket.Enabled = txt_MovieName.Enabled = Txt_Seats.Enabled = false;
            seat = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
            button31, button32, button33, button34, button35, button36};

            seat_number_label = new Label[] { label1, label2, label3, label4 };

            txt_MovieName.Text = FrmMovieDetails.movie_name;
            string theather = FrmMovieDetails.theather;
            Txt_Seats.Text = theather;

            CinemaService cinemaService = new CinemaService();
            cinemaService.get_seats_data(dataTable, theather);

            seat_number = Convert.ToInt16(dataTable.Rows[0][0]);
            panel2.Width = 65;
            panel2.Visible = false;

            seat_ready();
            sales_seat();

        }


        private void sales_seat()
        {
            full_seat = 0;
            CinemaService cinemaService = new CinemaService();
            string cinemaid = FrmMovieDetails.cinemaid;
            salesTable = cinemaService.get_booked_data(salesTable, md.CB_Theather.Text,md.CB_Cinemas.Text,txt_MovieName.Text,md.CB_Time.Text);

            if (salesTable.Rows.Count > 0)
            {
                for (int i = 0; i < salesTable.Rows.Count; i++)
                {
                    seats.Add(salesTable.Rows[i][0]);
                }
            }

            Button btn;

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    btn = (Button)item;

                    if (seats.Contains(btn.Text))
                    {
                        btn.BackColor = Color.FromArgb(255, 111, 111);
                        btn.Enabled = false;
                        full_seat++;
                    }
                }
            }

            label5.Text = "Full Seat" + Environment.NewLine + full_seat;

            label6.Text = "Empty Seat" + Environment.NewLine + (seat_number - full_seat);
        }

        private void seat_ready()
        {
            for (int i = 0; i < seat.Length; i++)
            {
                seat[i].Visible = false;
            }

            for (int i = 0; i < seat_number; i++)
            {
                seat[i].Visible = true;
            }
            for (int i = 0; i < seat_number_label.Length; i++)
            {
                seat_number_label[i].Visible = false;
            }
            if (seat_number < 11)
            {
                seat_number_label[0].Visible = true;
            }
            else if (seat_number < 21)
            {
                seat_number_label[0].Visible = true;
                seat_number_label[1].Visible = true;
            }
            else if (seat_number < 31)
            {
                seat_number_label[0].Visible = true;
                seat_number_label[1].Visible = true;
                seat_number_label[2].Visible = true;
            }
        }

        private void loadTicketData()
        {
            BookingService SS = new BookingService();
            string wk = DateTime.Today.DayOfWeek.ToString();
            string Daycode;
            if (wk != "Saturday" && wk != "Sunday")
            {
                Daycode = "1";
                result = SS.get_ticket_data(result, md.CB_Class.Text, Daycode);
                txt_ticket.Text = result;
            }
            else
            {
                Daycode = "2";
                result = SS.get_ticket_data(result, md.CB_Class.Text, Daycode);
                txt_ticket.Text = result;
            }

        }
        private void btn_BuyTickets_Click(object sender, EventArgs e)
        {
            BookingService ss = new BookingService();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmLogin"];
            string username = ((FrmLogin)f).txt_UserName.Text;
            bool result = ss.buytickets(username, md.CB_Cinemas.Text, md.CB_Theather.Text, txt_MovieName.Text, md.CB_Time.Text, Txt_Seats.Text, txt_ticket.Text);
            if (result)
            {
                MessageBox.Show("Ticket Sold Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sales_seat();
        }

    }
}
