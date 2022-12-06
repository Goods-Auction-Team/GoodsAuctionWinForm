using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class AddItemControl : Controller
    {

        public static bool Submit(Item item)
        {
            StartupController.iList.Add(item);
            DBConnect.UpdateItemDatabase(StartupController.iList);

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

    }
}
