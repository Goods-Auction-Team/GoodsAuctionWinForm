using GoodsAuctionWinFormsApp.Boundary;
using static GoodsAuctionWinFormsApp.Control.DBConnect;
using static GoodsAuctionWinFormsApp.Boundary.LoginForm;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {


        public static LoginForm login = new LoginForm();
       
        public static ItemList iList = new ItemList();


        //this function should only be necessary for hardcoding
        public static int nextID()
        {
            int id = 0;
            foreach(Item i in iList)
            {
               if(i.getItemID() > id)
                {
                    id = i.getItemID();
                }
            }
            return id + 1;
        }


        public static void Initiate()
        {
            // call initDB 
            //DBConnect.InitDB();


            DBConnect.InitDB();


            Application.Run(login);
        }
    }
}