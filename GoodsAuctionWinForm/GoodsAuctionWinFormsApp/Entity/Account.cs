using System;

namespace GoodsAuctionWinFormsApp.Entity
{
    public class Account
    {
        private string username, password, lastLogout;

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
