using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class LogOutControl : Controller
    {
        private Account username;

        public static void logout(Account a)
        {

            a.SetLastLogin(DateTime.Now);
            //can pull UN from loginControl, rather than having the boundries hold the name

            // pass in username, return?
            /* Account account = DBConnect.getUser();
             */

            StartupController.login.Show();
        }

    }
}
