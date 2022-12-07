using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class PlaceBidControl : Controller
    {

        /*private PlaceBidMenu pbm;

        public PlaceBidControl(PlaceBidMenu pbm)
        {
            this.pbm = pbm;
        }*/


        private Item itemID;


        public static void UpateDatabase(ItemList update, Item i) {
            //This should be for the database

            StartupController.iList = update;
            DBConnect.UpdateBids(i);
            DBConnect.UpdateItemDatabase(StartupController.iList);
        }

        public static bool CheckBid(int bid, int currentBid)
        {
            if (bid > currentBid)
            {

                return true;
            }
            else
                return false;
        }

        public static bool CheckTime(DateTime dt)
        {
            if (dt > DateTime.Now)
                return true;
            return false;
        }
    }
}
