using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class AddItemControl : Controller
    {

        public static bool Submit(Item item)
        {

            if (!validate(item.getItemName()) || !validate(item.getItemDescription()))
                return false;

            //This should be used in hardcoding
            item.setItemID( StartupController.nextID());


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

        public static bool validate(string field)
        {
            //test for validation of name&description
            //ANTI SQL-STUFF


            foreach (char c in field)
            {
                if (c == '+' || c == '$' || c == '/' || c == '\'' || c == '{' || c == '}' || c == '\\' || c == '[' || c == ']' || c == '*' || c == '%')
                    return false;
            }

            return true;

        }
    }
}
