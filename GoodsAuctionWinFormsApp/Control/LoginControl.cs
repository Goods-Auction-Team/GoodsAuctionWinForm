using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp;


namespace GoodsAuctionWinFormsApp.Control
{
    public class LoginControl : Controller
    {
        private Account username;

       private static Account loginAccount;

        public static Account getAccount()
        {
            return loginAccount;
        }

        public static bool login(string username, string password)
        {
            //The return bool is for success or failure of the login

            loginAccount = StartupController.andrewAccount;
            bool success = validate(loginAccount);
            bool pwAccept = checkPassword(loginAccount, password);

            if (success && pwAccept)
            {
                if (loginAccount.getType())
                {
                    AddItemMenu newMenu = new AddItemMenu();
                    newMenu.Show();
                }
                else
                {
                    PlaceBidMenu newMenUPlace = new PlaceBidMenu();
                    newMenUPlace.Show();
                    newMenUPlace.refresh(StartupController.iList);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        //Need to Validate
        public static bool validate(Account a)
        {
            //test for validation of account
            //ANTI SQL-STUFF

            return true;

            //if (a != null /* &&  a is in DB?*/ )
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}            
        }


        //complete
        public static bool checkPassword(Account a, string password)
        {
            
            if (password.GetHashCode() == a.getPassword())
            {
                return true;
                
            } 
            else
            {
                return false;
            }
        }
  
    }
}
