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
            username = DBConnect.GetUser(
            return false;
        }

        public bool validate(Account a)
        {
            //test for validation of account
            return false;
        }


  
    }
}
