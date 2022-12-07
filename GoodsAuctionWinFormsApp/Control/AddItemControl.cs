using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class AddItemControl : Controller
    {


        //submit item if checks are passed, otherwise triggers a fail in AddItemForm
        public static bool Submit(Item item)
        {

            if (!validate(item.getItemName()) || !validate(item.getItemDescription()))
                return false;


            item.setItemID( StartupController.nextID());


            StartupController.iList.Add(item);
            DBConnect.UpdateItemDatabase(StartupController.iList);

            AddItemMenu menu = new AddItemMenu();
            menu.refresh(StartupController.iList);
            menu.Show();

            return true;
        }

        //creates the AddItemForm from
        public static void AddItem()
        {
            AddItemForm form = new AddItemForm();
            form.Show();
        }



        //checks for SQL injection special character in both Name and Descrition
        public static bool validate(string field)
        {
            foreach (char c in field)
            {
                if (c == '+' || c == '$' || c == '/' || c == '\'' || c == '{' || c == '}' || c == '\\' || c == '[' || c == ']' || c == '*' || c == '%')
                    return false;
            }

            return true;

        }
    }
}
