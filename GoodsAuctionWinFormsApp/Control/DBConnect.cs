using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;
using System.Collections.Generic;
using System.Data.SQLite;
using System;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace GoodsAuctionWinFormsApp.Control
{
    public class DBConnect : Controller

    {
        private Account user;
        private Item itemID;
        private ItemList item;
        private Account username;

        public DBConnect(Account username)
        {
            this.username = username;
        }

        

        public Account getUser()
        {
            return username;
        }
        public void saveLogout(Account username)
        {
            this.username = username;
        }

        public Item getItem(Item itemID)
        {
            //This item ID returns the item
            return null;
        }

        public ItemList modifyItem(Item itemID, string newBid, Account username)
        {
            return null;//This is the placebid where it updates the item after bid and 
                        //returns ItemList
            return null;
        }

        public ItemList saveItem(Item item)
        {
            //This is the addItem where the data is saved
            return null;
        }

        // adding saveLogout(un) from sequence diagram
        public bool saveLogout(string username)
        {
            // not sure if this is right, but I'm trying to check if it saved correctly
            // if true, sends it back to LoginForm for (logged out sucess)
            if (username != null)
            {
                return true;
            }
            else { return false; }
        }
        private static string conn = @"Data Source =.;Initial Catalog = Auctiondb; Trusted_Connection=true";

        public static void InitDB()
        {

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=Auctiondb.mdf;"))

            using (SQLiteCommand cmnd = new SQLiteCommand())

            {
                //conn.Open();
                //cmnd.Connection = conn;
                //string strSql = @"BEGIN TRANSACTION; 
                //     DROP TABLE IF EXISTS ACCOUNT;
                //     DROP TABLE IF EXISTS ITEM;
                //     DROP TABLE IF EXISTS LOGOUT;
                //     DROP TABLE IF EXISTS BIDS;
                //     COMMIT;";

                //cmnd.CommandText = strSql;
                //cmnd.ExecuteNonQuery();
                //string table = @"CREATE TABLE [ACCOUNT] (
                //                 [username] TEXT PRIMARY KEY NOT NULL
                //               , [password] INTEGER NOT NULL
                //               , [type] TEXT NOT NULL
                //               , CONSTRAINT [PK_ACCOUNT] PRIMARY KEY ([username]));";

                //cmnd.CommandText = table;
                //cmnd.ExecuteNonQuery();
                //table = @"CREATE TABLE [ITEM] (
                //    [ItemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                //    , [ItemName] TEXT NOT NULL
                //    , [ItemDescription] TEXT NOT NULL
                //    , [StatingBid] INTEGER NOT NULL                     
                //    , [currentBid] INTEGER NOT NULL
                //    , [timeRemaining] INTEGER NOT NULL
                //    , [currentLeader] TEXT NOT NULL
                //    , [Seller] TEXT NOT NULL
                //    , CONSTRAINT [PK_ITEM] PRIMARY KEY ([ItemId])
                //    , FOREIGN KEY([Seller]) REFERENCES [ACCOUNT]([username]));";

                //cmnd.CommandText = table;
                //cmnd.ExecuteNonQuery();
                //table = @"CREATE TABLE [LOGOUT] (
                //                [Id] TEXT NOT NULL
                //              , [Date] INTEGER NOT NULL
                //              , [Time] INTEGER NOT NULL
                //              , [UName] TEXT NOT NULL)
                //              , CONSTRAINT [PK_LOGOUT] PRIMARY KEY ([Id])
                //              , FOREIGN KEY([UName]) REFERENCES [ACCOUNT]([username]));";

                //cmnd.CommandText = table;
                //cmnd.ExecuteNonQuery();
                //table = @"CREATE TABLE [BIDS] (
                //                [ItemNo] TEXT PRIMARY KEY NOT NULL
                //              , [BuyerNo] TEXT PRIMARY KEY NOT NULL
                //              , [Amount] INTEGER NOT NULL
                //              , CONSTRAINT [PK_BIDS] PRIMARY KEY ([ItemNo],[BuyerNo]));";

                ReadData(conn);

            }

        }


        public static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "INSERT INTO ACCOUT(username" +
                "                                          , password" +
                "                                          , type) VALUES ('','','')";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText = "INSERT INTO ACCOUNT(username" +
                "                                          , password" +
                "                                          , type) VALUES ('auctioneer@email.com'," +
                "                                          1232590539,'auctioneer')";
            sqliteCommand.ExecuteNonQuery();


            sqliteCommand.CommandText = "INSERT INTO ACCOUNT(username" +
                "                                          , password" +
                "                                          , type)";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText = "INSERT INTO ITEM(itemId" +
                "                                         ,itemName" +
                "                                         ,itemDescription" +
                "                                         ,startingBid" +
                "                                         ,currentBid" +
                "                                         ,timeRemaining" +
                "                                         ,currentLeader" +
                "                                         ,Seller)";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText = "INSERT INTO LOGOUT(Id" +
    "                                         ,Date" +
    "                                         ,Time" +
    "                                         ,UName)";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText = "INSERT INTO BIDS(ItemNo" +
    "                                          , BuyerNo" +
    "                                          , Amount)";
            sqliteCommand.ExecuteNonQuery();
        }

        public static void ReadData(SQLiteConnection conn)
        {
            //SQLiteDataReader sqliteReader;
            //SQLiteCommand sqliteCommand;
            //sqliteCommand = conn.CreateCommand();


            //sqliteCommand.CommandText = "SELECT * FROM ITEM";
            //sqliteReader = sqliteCommand.ExecuteReader();
            //while (sqliteReader.Read())
            //{
            //    string readerstring = sqliteReader.GetString(0);
            //}



             Item item1 = new Item();
            Item item2 = new Item();
            item1.setItemDescription("Mega Pie!");
            item1.setItemID(1);
            item1.setItemName("MosterPie");
            item1.setTimeRemaining((DateTime.Now).AddMinutes(1));

            item2.setItemName("Vrrrrm Car");
            item2.setItemID(2);
            item2.setItemDescription("Car go fast!");
            item2.setTimeRemaining((DateTime.Now).AddMinutes(5));

            StartupController.iList.Add(item1);
            StartupController.iList.Add(item2);




        }


        public static Account findAccount(string username)
        {
            //SQLiteCommand sqliteCommand;
            //sqliteCommand = conn.CreateCommand();
            //sqliteCommand.CommandText = "SELECT * FROM ACCOUNT";
            //sqliteReader = sqliteCommand.ExecuteReader();
            //while (sqliteReader.Read())
            //{
            //    Account import = new Account();
            //    import.SetUsername(sqliteReader.GetString(0));
            //    import.SetPassword(int.Parse(sqliteReader.GetString(1)));
            //    import.SetType(bool.Parse(sqliteReader.GetString(2)));

            //}

            bool found = false;

             Account andrewAccount = new Account();
            andrewAccount.SetPassword("password".GetHashCode());
            andrewAccount.SetUsername("aroe@augusta.edu");
            andrewAccount.SetType(false);

            Account Joy = new Account();
            Joy.SetPassword("password".GetHashCode());
            Joy.SetUsername("Joy@shutup.net");
            Joy.SetType(true);
           

            Account user = new Account();

            if (andrewAccount.getUsername() == username)
                return andrewAccount;
            if (Joy.getUsername() == username)
                 return Joy;



            // return user;
            //if (found)
            //    return user;
            else
                return null;
        }

        public static void UpdateItemDatabase(ItemList list)
        {

           //overwrites ITEMs with this list

        }

        public static void UpdateLastLogout(Account loggingOutAccount)
        {
            //saves Account.getUsername & DATETIME
        }

        public static void UpdateBids(Item item, Account account)
        {
            //Saves Item Name, bid, and account's username
        }
    }
}