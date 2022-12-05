using GoodsAuctionWinFormsApp.Boundary;
using static GoodsAuctionWinFormsApp.Control.DBConnect;
using static GoodsAuctionWinFormsApp.Boundary.LoginForm;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {


        public static LoginForm login = new LoginForm();
        public static Account andrewAccount = new Account();
        public static Account jeffAccount = new Account();
        public static Item item1 = new Item();
        public static Item item2 = new Item();
        public static ItemList iList = new ItemList();

        public static void Initiate()
        {
            // call initDB 
            //DBConnect.InitDB();



            andrewAccount.SetPassword("password".GetHashCode());
            andrewAccount.SetUsername("Andrew");

            jeffAccount.SetPassword("time".GetHashCode());
            jeffAccount.SetUsername("jeff");

            item1.setItemDescription("Mega Pie!");
            item1.setItemID(1);
            item1.setItemName("MosterPie");
            item1.setTimeRemaining((DateTime.Now).AddMinutes(1));

            item2.setItemName("Vrrrrm Car");
            item2.setItemID(2);
            item2.setItemDescription("Car go fast!");
            item2.setTimeRemaining((DateTime.Now).AddMinutes(5));

            iList.Add(item1);
            iList.Add(item2);

            Application.Run(login);
        }
    }
}