using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class AddItemControl : Controller
    {
        private Item Item; //not sure if this is correct

        public static void insertNewItem(string itemName, string itemDescription, int startBid, int duration)
        {
            // this is suppose call AddItemForm and create the form?
        }

        public static bool Submit(Item item)
        {
            //code here to check for validity and to send to entity


            return true;
        }

        public void saveItem(Item)
        {

        }
    }
}
