using GoodsAuctionWinFormsApp.Boundary;
using static GoodsAuctionWinFormsApp.Control.DBConnect;
using static GoodsAuctionWinFormsApp.Boundary.LoginForm;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {


        public static LoginForm login = new LoginForm();
        public static Account jeffAccount = new Account();
       
        public static ItemList iList = new ItemList();

        public static void Initiate()
        {
            // call initDB 
            //DBConnect.InitDB();


            DBConnect.InitDB();
 

            jeffAccount.SetPassword("time".GetHashCode());
            jeffAccount.SetUsername("jeff");


            Application.Run(login);
        }
    }
}