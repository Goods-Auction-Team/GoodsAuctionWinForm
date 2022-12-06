using System;

namespace GoodsAuctionWinFormsApp.Entity
{
    public class Account
    {
        private string username;
        private int password;

        public string GetUsername()
        {
            return username;
        }

        public int getPassword()
        {
            return password;
        }
        public bool getType()
        {
            //true = auctioneer
            //false = bidder
            return true;
        }
    }
}
