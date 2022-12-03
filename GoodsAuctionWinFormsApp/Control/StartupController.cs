using GoodsAuctionWinFormsApp.Boundary;
using static GoodsAuctionWinFormsApp.Control.DBConnect;
using static GoodsAuctionWinFormsApp.Boundary.LoginForm;

namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {
        public void Initiate()
        {

            // call initDB 
            DBConnect.InitDB();

            // open login form?
            addForm(new LoginForm());

        }
    }
}
