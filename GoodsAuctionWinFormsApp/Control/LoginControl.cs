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


            if(!validate(username))
                return false;

            loginAccount = DBConnect.findAccount(username);

            if (loginAccount == null)
                return false;
            
            bool pwAccept = checkPassword(loginAccount, password);

            if (pwAccept)
            {
                if (loginAccount.getType())
                {
                    AddItemMenu newMenu = new AddItemMenu();
                    newMenu.Show();
                    newMenu.refresh(StartupController.iList);
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
        public static bool validate(string username)
        {
            //test for validation of account
            //ANTI SQL-STUFF
            int countAT = 0, countDOT = 0;

            foreach (char c in username)
            {
                if (c == '+' || c == '$' || c == '/' || c == '\'' || c == '{' || c == '}' || c == '\\' || c == '[' || c == ']' || c == '*' || c == '%' || c == '&' || c == '!')
                    return false;

                if (c == '@')
                    countAT++;
                if(c == '.')
                    countDOT++;
            }
            if (countAT != 1 || countDOT == 0)
                return false;
            else
                return true;
            
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
