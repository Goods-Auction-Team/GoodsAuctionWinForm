﻿using System;

namespace GoodsAuctionWinFormsApp.Entity
{
    public class Account
    {
        private string username, password, type;

        public string GetUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
        public string getType()
        {
            return type;
        }
    }
}
