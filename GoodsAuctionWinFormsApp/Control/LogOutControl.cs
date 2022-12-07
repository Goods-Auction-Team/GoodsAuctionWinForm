using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class LogOutControl : Controller
    {
 

        public static void logout(Account a)
        {

            a.SetLastLogin(DateTime.Now);

            //updates db with username being logged out
            DBConnect.UpdateLastLogout(a);

            //creates login form w/ logout message
            StartupController.login.Show();
            StartupController.login.setLoggedOut();
            


        }

    }
}
