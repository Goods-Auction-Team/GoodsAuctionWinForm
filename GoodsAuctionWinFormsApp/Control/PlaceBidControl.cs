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

        public Item getItem(int itemID)
        {
            return null;
        }

        public static void UpateDatabase(ItemList update) {
            //This should be for the database

            StartupController.iList = update;
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
    }
}
