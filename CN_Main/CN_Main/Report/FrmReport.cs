using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN_Main.Report
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnMyTrans_Click(object sender, EventArgs e)
        {
            MyTransactionViewer ftrans = new MyTransactionViewer();
            ftrans.ShowDialog();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            CinemaApprovalViewer fcin = new CinemaApprovalViewer();
            fcin.ShowDialog();
        }
    }
}
