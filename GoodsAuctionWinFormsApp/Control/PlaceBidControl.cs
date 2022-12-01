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

        public void submit(int newBid, string username, PlaceBidMenu pbm)
        {

            //if bid went through, refresh itemlist in PlaceBidMenu
            //pbm.refreshList();
        }
    }
}
