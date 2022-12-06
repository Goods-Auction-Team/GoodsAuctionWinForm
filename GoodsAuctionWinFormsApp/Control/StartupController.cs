using GoodsAuctionWinFormsApp.Boundary;
using static GoodsAuctionWinFormsApp.Control.DBConnect;
using static GoodsAuctionWinFormsApp.Boundary.LoginForm;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {


        public static LoginForm login;
       
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

        [STAThread]
        public static void Initiate()
        {
         
            // call initDB 
            DBConnect.InitDB();
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(login = new LoginForm());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

        }
    }
}