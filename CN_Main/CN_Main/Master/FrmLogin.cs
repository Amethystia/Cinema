using System;
using System.Drawing;
using System.Windows.Forms;
using CN_Modeling;
using CN_Business;

namespace CN_Main
{
    public partial class FrmLogin : Form
    {
        public bool result = true;
        public FrmLogin()
        {
            InitializeComponent();
            txt_UserName.Text = null;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        #region TextBox
        private void clearTxt()
        {
            txt_UserName.Text = "User Name";
            txt_Password.Text = "Password";
            txt_Password.UseSystemPasswordChar = false;
        }
      
        #endregion

    

        //validasi ada isi atau nga
        public void  PerformValidation()
        {
           if (String.IsNullOrEmpty(txt_UserName.Text) || txt_UserName.Text == "User Name")
                    {
                    result = false;
                    MessageBox.Show("Your Name is Empty");
                    }
           if (String.IsNullOrEmpty(txt_Password.Text) || txt_Password.Text == "Password" )
                    {
                    result = false;
                    MessageBox.Show("Your Password is Empty");
                    }
            if (txt_UserName.Text != "User Name" && txt_Password.Text != "Password")
            {
                result = true;
            }
        }


        public void btn_Login_Click(object sender, EventArgs e)
        {
                PerformValidation();
                if(result == true)
                {
                    string status = LoginService.LoginServices(txt_UserName.Text, txt_Password.Text);
                    if (status == "Login Success")
                    {
                        MessageBox.Show("Login Success, Welcome: " + txt_UserName.Text);
                    //-- Show form kedua -- 
                    FrmMDI FormMdi = new FrmMDI();
                    this.Hide();
                    FormMdi.ShowDialog();
                    this.Close();
                }
                    else if (status != "Login Success")
                    {
                        MessageBox.Show("Invalid User Name / Password");
                    }
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txt_UserName_Click(object sender, EventArgs e)
        {
            //txt_UserName.Clear();

        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            //txt_Password.Clear();
        
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            frm_user FormUser = new frm_user();
            FormUser.ShowDialog();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformValidation();
                if (result == true)
                {
                    string status = LoginService.LoginServices(txt_UserName.Text, txt_Password.Text);
                    if (status == "Login Success")
                    {
                        MessageBox.Show("Login Success, Welcome: " + txt_UserName.Text);
                        //-- Show form kedua -- 
                        FrmMDI FormMdi = new FrmMDI();
                        this.Hide();
                        FormMdi.ShowDialog();
                        this.Close();
                    }
                    else if (status != "Login Success")
                    {
                        MessageBox.Show("Invalid User Name / Password");
                    }
                }
            }
        }
    }
}
