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
using Stimulsoft.Report;
namespace CN_Main
{
    public partial class FrmTransactionHistoriees : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public FrmTransactionHistoriees()
        {
            InitializeComponent();
            DisplaysTable();
        }
        public void DisplaysTable()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmLogin"];
            string username = ((FrmLogin)f).txt_UserName.Text;
            try
            {
                CinemaService cs = new CinemaService();
                dt = cs.get_bookedtickets_data(dt,username);

                dg_BookingTicket.DataSource = null;
                dg_BookingTicket.Columns.Clear();
                dg_BookingTicket.DataSource = dt;
                dg_BookingTicket.AllowUserToAddRows = false;
                dg_BookingTicket.ReadOnly = true;

                dt2 = cs.get_bookingcinema_data(dt2,username);

                dt_bookingcinema.DataSource = null;
                dt_bookingcinema.Columns.Clear();
                dt_bookingcinema.DataSource = dt2;
                dt_bookingcinema.AllowUserToAddRows = false;
                dt_bookingcinema.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            //report.RegData(dataSet1);

            report.Load("..\\..\\Reports\\SimpleList.mrt");
            report.Render(true);

            string file = "SimpleList.";

                file += "pdf";
                report.ExportDocument(StiExportFormat.Pdf, file);
                System.Diagnostics.Process.Start(file);
        }
    }
}
