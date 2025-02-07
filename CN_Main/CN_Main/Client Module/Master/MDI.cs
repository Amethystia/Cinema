﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN_Business;

namespace CN_Main
{
    public partial class FrmMDI : Form
    {
        string result;
        public FrmMDI()
        {
            InitializeComponent();
            checkEmployee();
        }
        public void checkEmployee()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmLogin"];
            string username = ((FrmLogin)f).txt_UserName.Text;
            LoginService login = new LoginService();
            result=login.get_isemployee(result, username);
            if(result == "True")
            {
                btn_Employee.Visible = true;
            }
            else
            {
                btn_Employee.Visible = false;
            }
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
            Panel_SideBar.Location = new Point(0, 75);
            OpenFormInPanel(new FrmHome());
        }

        private void btn_Movies_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 125);
            OpenFormInPanel(new FrmMovies());
        }
        private void btn_GroupBooking_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 175);
            OpenFormInPanel(new FrmCinemas());
        }
        private void btn_Promotion_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 225);
            OpenFormInPanel(new FrmPromo());
        }
        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 275);
            OpenFormInPanel(new FrmTransactionHistoriees());
        }
        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Panel_SideBar.Location = new Point(0, 325);
            FrmMDI_Employee frmMDI_CRUD = new FrmMDI_Employee();
            this.Hide();
            frmMDI_CRUD.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout()
        {
            FrmLogin formlogin = new FrmLogin();
            this.Hide();
            formlogin.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            logout();
        }
    }
}
