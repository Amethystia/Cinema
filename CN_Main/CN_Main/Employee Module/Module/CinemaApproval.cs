using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CN_Business;

namespace CN_Main
{
    public partial class FrmCinemaApproval : Form
    {
        DataTable dt = new DataTable();
        public FrmCinemaApproval()
        {
            InitializeComponent();
            loadcombo();
            DisplaysTable();
        }

        public void loadcombo()
        {
            dtp_date.Enabled=txt_moviename.Enabled = txt_class.Enabled = txt_cinema.Enabled = txt_price.Enabled = txt_requestor.Enabled = cb_isApprove.Enabled=false;
        }

        public void DisplaysTable()
        {
            try
            {
            CinemaApprovalService cinemaApprovalService = new CinemaApprovalService();
            dt = cinemaApprovalService.getrequestdata();

                dgv_CinemaApproval.DataSource = null;
                dgv_CinemaApproval.Columns.Clear();
                dgv_CinemaApproval.DataSource = dt;
                dgv_CinemaApproval.AllowUserToAddRows = false;
                dgv_CinemaApproval.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message.ToString());
            }
        }
    }
}
