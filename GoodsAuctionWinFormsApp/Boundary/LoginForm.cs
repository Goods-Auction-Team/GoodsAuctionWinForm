﻿
using Microsoft.VisualBasic.Logging;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class LoginForm : Form
    {

        //Constructor for LoginForm - the bool determines first logon vs someone having logged out.
        public LoginForm(bool loggedOut)
        {
            InitializeComponent();
            if (loggedOut)
            {

                failedLoginLabel.Text = "Logged out successully!";
                failedLoginLabel.Visible = true;
            }
        }
        private string error;


        
        //This will pull the UN & PW typed in in the boxes and call LoginController's login function. If that returns false (i.e. login failed)
        //displays failed login.
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            bool success = Control.LoginControl.login(usernameTextbox.Text, passwordTextbox.Text);
            if (!success)
            {
                failedLoginLabel.Text = "Login Failed-- Check Username/ Password!";
                failedLoginLabel.Visible = true;
            }
        }


    }
}
