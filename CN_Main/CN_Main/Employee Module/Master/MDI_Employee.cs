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
using CN_Main.Report;

namespace CN_Main
{
    public partial class FrmMDI_Employee : Form
    {
        public FrmMDI_Employee()
        {
            InitializeComponent();
            OpenFormInPanel(new FrmHome());
        }

        public void OpenFormInPanel(object FormChild)
        {
            if (this.Panel_Container.Controls.Count > 0)
                this.Panel_Container.Controls.RemoveAt(0);
            Form FC = FormChild as Form;
            FC.TopLevel = false;
            FC.Dock = DockStyle.Fill;
            this.Panel_Container.Controls.Add(FC);
            this.Panel_Container.Tag = FC;
            FC.Show();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmHome());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 73);
            OpenFormInPanel(new FrmHome());
        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 127);
            OpenFormInPanel(new FrmEditMovie());
        }
        private void btn_Cinema_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 181);
            OpenFormInPanel(new FrmEditCinema());
        }
        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 231);
            OpenFormInPanel(new FrmEditTickets());
        }
        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 285);
            OpenFormInPanel(new FrmEditPromotion());
        }
        private void btn_Theather_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 338);
            OpenFormInPanel(new FrmEditTheather());
        }
        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 392);
            OpenFormInPanel(new FrmEditBookingTickets());
        }
        private void btn_ApproveCinema_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 446);
            OpenFormInPanel(new FrmCinemaApproval());
        }
        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmReport());
        }
        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 504);
            FrmMDI frmMDI = new FrmMDI();
            this.Hide();
            frmMDI.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
