using GoodsAuctionWinFormsApp.Boundary;
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
            StartupController.iList.Add(item);


            AddItemMenu menu = new AddItemMenu();
            menu.refresh(StartupController.iList);
            menu.Show();

            return true;
        }

        public static void AddItem()
        {
            AddItemForm form = new AddItemForm();
            form.Show();
        }
        public void saveItem(Item item)
        {

        }
    }
}
