using System;

namespace GoodsAuctionWinFormsApp.Entity
{
    public class Account
    {
        private string username;
        private int password;
        private static DateTime lastLogin;

        public string getUsername()
        {
            return username;
        }

        public void SetUsername(string newUsername)
        {
            username = newUsername;
        }

        public void SetPassword(int newPassword)
        {
            password = newPassword;
        }

        public int getPassword()
        {
            //return password;
            return password;
        }
        public bool getType()
        {
            //true = auctioneer
            //false = bidder
            return true;
        }

        public void SetLastLogin(DateTime datetime)
        {
            lastLogin = datetime;
        }

        public static DateTime GetLastLogin()
        {
            return lastLogin;
        }

    }
}
