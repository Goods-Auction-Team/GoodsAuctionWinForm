
namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class LoginForm : Form
    {

        //Constructor for LoginForm - the bool determines first logon vs someone having logged out.
        public LoginForm()
        {
            InitializeComponent();
            
        }

        //This will indicate logged out
        public void setLoggedOut()
        {
           failedLoginLabel.Text = "Logged out successully!";
           failedLoginLabel.Visible = true;
            this.Visible = true;
        }

        
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
            else
            {
                this.Hide();
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
            }
        }


    }
}
