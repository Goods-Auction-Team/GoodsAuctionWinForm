﻿using GoodsAuctionWinFormsApp.Entity;
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

            //loginAccount = StartupController.andrewAccount;
            loginAccount = DBConnect.findAccount(username);

            if (loginAccount == null)
                return false;
            bool success = validate(loginAccount);
            bool pwAccept = checkPassword(loginAccount, password);

            if (success && pwAccept)
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
        public static bool validate(Account a)
        {
            //test for validation of account
            //ANTI SQL-STUFF



            // MUST contain EXACTLY 1 @, >= 1 .
            // NO   +, $, /,\, ', {,},&



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
