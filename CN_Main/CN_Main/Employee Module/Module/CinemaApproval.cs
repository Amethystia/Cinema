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
        DataSet datasettheather = new DataSet();
        public FrmCinemaApproval()
        {
            InitializeComponent();
            loadcombo();
            DisplaysTable();
        }

        public void loadcombo()
        {
            dtp_date.Enabled=txt_moviename.Enabled = txt_class.Enabled = txt_cinema.Enabled = txt_price.Enabled = txt_requestor.Enabled = btn_approve.Enabled=btn_reject.Enabled= false;
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
        public void LoadCB_Theather()
        {
            if (txt_cinema.Text != null && txt_moviename.Text != "")
            {
                CinemaApprovalService cinemaApprovalService = new CinemaApprovalService();
                datasettheather = cinemaApprovalService.gettheatherdata(datasettheather,txt_cinema.Text,txt_class.Text,txt_moviename.Text);
                cb_theather.DataSource = datasettheather.Tables[0];
                cb_theather.DisplayMember = "Theather";
            }
        }

        public void clearall()
        {
            txt_cinema.Text = txt_class.Text = txt_moviename.Text = txt_price.Text = txt_requestor.Text  =txt_Status.Text= string.Empty;
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            bool DialogDel = MessageBox.Show("Are you sure to Approve this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (DialogDel)
            {
                CinemaApprovalService cinemaApprovalService = new CinemaApprovalService();
                string bookingid = dgv_CinemaApproval.SelectedRows[0].Cells["cinema_bookid"].Value.ToString();
                cinemaApprovalService.approvedata(bookingid);
                DisplaysTable(); clearall(); LoadCB_Theather();
            }
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            bool DialogDel = MessageBox.Show("Are you sure to Reject this Data", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (DialogDel)
            {
                CinemaApprovalService cinemaApprovalService = new CinemaApprovalService();
                string bookingid = dgv_CinemaApproval.SelectedRows[0].Cells["cinema_bookid"].Value.ToString();
                cinemaApprovalService.rejectdata(bookingid);
                DisplaysTable(); clearall(); LoadCB_Theather();
            }
        }

        public void dgv_CinemaApproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CinemaApproval.SelectedRows.Count > 0)
            {
                txt_requestor.Text = dgv_CinemaApproval.SelectedRows[0].Cells["book_by"].Value.ToString();
                txt_cinema.Text = dgv_CinemaApproval.SelectedRows[0].Cells["cinema_name"].Value.ToString();
                txt_moviename.Text = dgv_CinemaApproval.SelectedRows[0].Cells["movie_name"].Value.ToString();
                txt_class.Text = dgv_CinemaApproval.SelectedRows[0].Cells["class"].Value.ToString();
                dtp_date.Text = dgv_CinemaApproval.SelectedRows[0].Cells["date"].Value.ToString();
                txt_price.Text = dgv_CinemaApproval.SelectedRows[0].Cells["price"].Value.ToString();
                txt_Status.Text = dgv_CinemaApproval.SelectedRows[0].Cells["RequestStatus"].Value.ToString();
            }
            btn_reject.Enabled = btn_approve.Enabled = true;
            LoadCB_Theather();
        }
    }
}
