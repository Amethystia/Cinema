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
        public FrmSeats(string moname)
        {
            InitializeComponent();
        }

        private void lounges_click(object sender, EventArgs e)
        {
            Button btn;

            if (panel2.Width == 65)
            {
                panel2.Visible = true;
                //pictureBox2.Visible = false;
                panel2.Width = 225;
                //PanelAnimator.ShowSync(panel2);
                //LogoAnimator.ShowSync(pictureBox1);

                if (sender is Button)
                {
                    btn = sender as Button;

                    Txt_Theather.SelectedText = btn.Text;

                }

            }
            else
            {
                if (sender is Button)
                {
                    btn = sender as Button;

                    Txt_Theather.SelectedText = btn.Text;

                }
            }
        }

        Button[] seat = new Button[40];
        Label[] seat_number_label = new Label[4];

        int seat_number = 1;
        static string student, normal;

        ArrayList seats = new ArrayList();
        int full_seat;

        private void Cinema_Load(object sender, EventArgs e)
        {

            seat = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
            button31, button32, button33, button34, button35, button36};

            seat_number_label = new Label[] { label1, label2, label3, label4 };

            //txt_MovieName.Text = CN_Business;
            //bunifuCustomLabel4.Text = Form9.movie_lounge;

            //CinemaClass cla = new CinemaClass();
            //DataTable tab = cla.table_get_data("select lounge_seat_count from Lounges where lounge_name = '" + Form9.movie_lounge + "'");

            //seat_number = Convert.ToInt16(tab.Rows[0][0]);

            //seat_ready();

            ////DataTable tab2 = cla.table_get_data("select * from TicketPrice");

            //student = tab2.Rows[0][0].ToString();
            //normal = tab2.Rows[0][1].ToString();

            //radioButton1.Text = "Student" + Environment.NewLine + "($" + tab2.Rows[0][0] + ")";
            //radioButton2.Text = "Normal" + Environment.NewLine + "($" + tab2.Rows[0][1] + ")";

            //sales_seat();

        }


        private void sales_seat()
        {
            //full_seat = 0;

            //CinemaClass cla = new CinemaClass();
            //DataTable table = cla.table_get_data("select movie_seat_number from MovieTicketPrice where movie_name = '" + Form9.movie_name + "'");

            //if (table.Rows.Count > 0)
            //{
            //    for (int i = 0; i < table.Rows.Count; i++)
            //    {
            //        seats.Add(table.Rows[i][0]);
            //    }
            //}

            //Button btn;

            //foreach (Control item in this.Controls)
            //{
            //    if (item is Button)
            //    {
            //        btn = (Button)item;

            //        if (seats.Contains(btn.Text))
            //        {
            //            btn.BackColor = Color.FromArgb(255, 111, 111);
            //            full_seat++;
            //        }
            //    }
            //}

            //bunifuCustomLabel6.Text = "Full Seat" + Environment.NewLine + full_seat;

            //bunifuCustomLabel7.Text = "Empty Seat" + Environment.NewLine + (seat_number - full_seat);

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
            else if (seat_number < 41)
            {
                seat_number_label[0].Visible = true;
                seat_number_label[1].Visible = true;
                seat_number_label[2].Visible = true;
                seat_number_label[3].Visible = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //CinemaClass cla = new CinemaClass();

            //if (radioButton1.Checked)
            //{
            //    //bool turn = cla.query_commad("insert into MovieTicketPrice(movie_name,movie_seat_number,movie_customer_name,movie_ticket_price,movie_lounge,movie_customer_date) values('" + bunifuTextbox1.text + "','" + bunifuTextbox2.text + "','" + bunifuTextbox3.text + "','" + student + "','" + bunifuCustomLabel4.Text + "','" + DateTime.Now.ToShortDateString() + "')");

            //    if (turn)
            //    {
            //        MessageBox.Show("Ticket Sold Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
            //else
            //{
            //    bool turn = cla.query_commad("insert into MovieTicketPrice(movie_name,movie_seat_number,movie_customer_name,movie_ticket_price,movie_lounge,movie_customer_date) values('" + bunifuTextbox1.text + "','" + bunifuTextbox2.text + "','" + bunifuTextbox3.text + "','" + normal + "','" + bunifuCustomLabel4.Text + "','" + DateTime.Now.ToShortDateString() + "')");

            //    if (turn)
            //    {
            //        MessageBox.Show("Ticket Sold Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}

            sales_seat();

        }

        private void bunifuTextbox3_Enter(object sender, EventArgs e)
        {
            //bunifuTextbox3.text = "";
        }

        private void Form10_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            //pictureBox2.Visible = true;
            //panel2.Width = 65;
            //PanelAnimator.ShowSync(panel2);
            //panel2.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
