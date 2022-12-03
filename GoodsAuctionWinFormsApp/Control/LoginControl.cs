using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Boundary;


namespace GoodsAuctionWinFormsApp.Control
{
    public class LoginControl : Controller
    {
        private Account username;

        private static string un = "No User";

        public static string GetUser()
        {
            return un;
        }

        public static bool login(string username, string password)
        {
            //login
            //The return bool is for success or failure of the login


            //This is going to store the current user in the 'un' variable, so it can be used for logout & placebid
            un = username;

            return false;
        }

        public bool validate(Account a)
        {
            //test for validation of account
            return false;
        }


  
    }
}
