using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class LogOutControl : Controller
    {
        private Account username;

        public static void logout()
        {
            //can pull UN from loginControl, rather than having the boundries hold the name

            // pass in username, return?
            /* Account account = DBConnect.getUser();
             */
        }

    }
}
