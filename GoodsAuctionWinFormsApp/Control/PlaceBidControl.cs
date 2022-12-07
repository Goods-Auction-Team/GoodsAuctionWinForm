using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class PlaceBidControl : Controller
    {


        private Item itemID;


        //updates the Itemlist and then sends it to the DB, as well as adds the bid
        public static void UpateDatabase(ItemList update, Item i) {

            StartupController.iList = update;
            DBConnect.UpdateBids(i);
            DBConnect.UpdateItemDatabase(StartupController.iList);
        }


        //ensures bid size
        public static bool CheckBid(int bid, int currentBid)
        {
            if (bid > currentBid)
            {

                return true;
            }
            else
                return false;
        }

        //ensures time has not passed ending time
        public static bool CheckTime(DateTime dt)
        {
            if (dt > DateTime.Now)
                return true;
            return false;
        }
    }
}
