
namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class LoginForm : Form
    {

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




        private void failedLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string un = usernameTextbox.Text;
            string pw = passwordTextbox.Text;
            bool success = Control.LoginControl.login(un, pw);
            if (!success)
            {
                failedLoginLabel.Visible = true;
            }
        }


    }
}
