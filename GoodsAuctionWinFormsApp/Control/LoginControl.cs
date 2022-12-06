using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Boundary;


namespace GoodsAuctionWinFormsApp.Control
{
    public class LoginControl : Controller
    {
        private Account username;

        private static string un = "No User";

        
        public static bool Login(string username, string password)
        {
            //login
            //The return bool is for success or failure of the login
            Account loginAccount;

            loginAccount = DBConnect.getUser(username);
            bool success = validate(loginAccount);
            bool pwAccept = checkPassword(loginAccount, password);

            if (success && pwAccept)
            {
                if (loginAccount.getType())
                    new AddItemMenu();
                else
                    new PlaceBidMenu();
                return true;
            }
            else
            {
                return false;

            }
        }


        public static bool validate(Account a)
        {
            //test for validation of account
            //ANTI SQL-STUFF
            return true;
        }


        public static bool checkPassword(Account a, string password)
        {
            if(password.GetHashCode() == a.getPassword())
                return true;
            else
                return false;
        }
  
    }
}
