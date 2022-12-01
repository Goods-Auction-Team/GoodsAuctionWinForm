using GoodsAuctionWinFormsApp.Boundary;
namespace GoodsAuctionWinFormsApp.Control
{
    public class StartupController : Controller
    {
        private LoginForm lf;

        public void initiate()
        {
            //DBConnect.initiateDB();
            lf = new LoginForm();
            
        }
    }
}
