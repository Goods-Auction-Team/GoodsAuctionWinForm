using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;
using System.Collections.Generic;
using System.Data.SQLite;
using System;
using Microsoft.Data.Sqlite;
using System.Collections;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Security.Principal;

namespace GoodsAuctionWinFormsApp.Control
{
    public class DBConnect : Controller

    {
        private Account user;
        private Item itemID;
        private ItemList item;
        private Account username;

        public DBConnect()
        {
        }



        public Account getUser()
        {
            return user;
        }

        private void setUser(Account account)
        {
            this.user = account;
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
        private static string connStr = @"Data Source=Auctiondb.db"; //@"Data Source =.;Initial Catalog = Auctiondb; Trusted_Connection=true";

        public static void InitDB()
        {

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(dbTables, conn))

                {
                    cmd.ExecuteNonQuery();

                }
            }

            string sql = "INSERT INTO ACCOUNT(username, password, type) VALUES(@u1, @p1, @t1), (@u2, @p2, @t2);";

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@u1", "aroe@augusta.edu");
                    cmd.Parameters.AddWithValue("@p1", "password".GetHashCode());
                    cmd.Parameters.AddWithValue("@t1", true);
                    cmd.Parameters.AddWithValue("@u2", "joy@shutup.net");
                    cmd.Parameters.AddWithValue("@p2", "password".GetHashCode());
                    cmd.Parameters.AddWithValue("@t2", false);
                    cmd.ExecuteNonQuery();
                }
            }


            sql = "INSERT INTO ITEM(itemId, itemName, itemDescription, startingBid, currentBid, timeRemaining, currentLeader) Values (@iI, @iN, @iD,@sB, @cB, @tR, @cL);";

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@iI", "1");
                    cmd.Parameters.AddWithValue("@iN", "Car");
                    cmd.Parameters.AddWithValue("@iD", "Fast, clean, one owner.");
                    cmd.Parameters.AddWithValue("@sB", "10000");
                    cmd.Parameters.AddWithValue("@cB", "10002");
                    cmd.Parameters.AddWithValue("@tR", "3");
                    cmd.Parameters.AddWithValue("@cL", "Joy");
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("@iI", "2");
                    cmd.Parameters.AddWithValue("@iN", "Pie");
                    cmd.Parameters.AddWithValue("@iD", "Tasty tasty.");
                    cmd.Parameters.AddWithValue("@sB", "2");
                    cmd.Parameters.AddWithValue("@cB", "44");
                    cmd.Parameters.AddWithValue("@tR", "3");
                    cmd.Parameters.AddWithValue("@cL", "Joy");
                    cmd.ExecuteNonQuery();
                }

            }

            sql = "INSERT INTO LOGOUT(account,time) VALUES (@a, @t);";

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@t", "");
                    cmd.Parameters.AddWithValue("@a", "Joy");
                    cmd.ExecuteNonQuery();
                }
            }

            sql = "INSERT INTO BIDS(itemId, buyerID, amount) VALUES (@i, @b, @a);";

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@i", "1");
                    cmd.Parameters.AddWithValue("@b", "Joy");
                    cmd.Parameters.AddWithValue("@a", "30");
                    cmd.ExecuteNonQuery();
                }
            }
            ReadData();

        }


        public static void ReadData()
        {

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
             
            {
                conn.Open();
                string sql = "SELECT * FROM ITEM;";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            StartupController.iList.Add(new Item(
                                r.GetInt32(0),
                                r.GetString(1),
                                r.GetString(2),
                                r.GetInt32(3),
                                r.GetInt32(4),
                                DateTime.Now.AddMinutes(r.GetInt32(5)),
                                r.GetString(6)
                                ));
                        }
                    }
                }
            }

            

        }

        public static Account findAccount(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT *  FROM [ACCOUNT] WHERE ([username]=@user);"; //not efficient, but where clause issues happened
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new Account(username, r.GetInt32(1), r.GetBoolean(2));
                        }
                        return null;
                    }
                }
            }
        }

       
        public static void UpdateItemDatabase(ItemList list)
        {

            

            string sql = "INSERT INTO ITEM(itemId, itemName, itemDescription, startingBid, currentBid, timeRemaining, currentLeader) Values (@iI, @iN, @iD,@sB, @cB, @tR, @cL);";
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(dbInsertDeletions, conn))

                {
                    cmd.ExecuteNonQuery();

                }
            }
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                foreach(Item i in StartupController.iList)
                {
                    cmd.Parameters.AddWithValue("@iI", i.getItemID());
                    cmd.Parameters.AddWithValue("@iN", i.getItemName());
                    cmd.Parameters.AddWithValue("@iD", i.getItemDescription());
                    cmd.Parameters.AddWithValue("@sB", i.getStartingBid());
                    cmd.Parameters.AddWithValue("@cB", i.getCurrentBid());
                    cmd.Parameters.AddWithValue("@tR", 5);
                    cmd.Parameters.AddWithValue("@cL", i.getCurrentLeader());
                    cmd.ExecuteNonQuery();
             
                }

            }


        }

        public static void UpdateLastLogout(Account loggingOutAccount)
        {
            //saves Account.getUsername & DATETIME
        }

        public static void UpdateBids(Item item, Account account)
        {
            //Saves Item Name, bid, and account's username
        }

    
        static string dbTables = @"
                    BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS ACCOUNT;
                    DROP TABLE IF EXISTS ITEM;
                    DROP TABLE IF EXISTS LOGOUT;
                    DROP TABLE IF EXISTS BIDS;
                    COMMIT;

            CREATE TABLE [ACCOUNT] (
            [username] TEXT PRIMARY KEY UNIQUE NOT NULL,
            [password] INTEGER NOT NULL,
            [type] BOOLEAN NOT NULL
            );



            CREATE TABLE [ITEM] (
            [itemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
            [itemName] TEXT NOT NULL,
            [itemDescription] TEXT NOT NULL,
            [startingBid] INTEGER NOT NULL,                     
            [currentBid] INTEGER NOT NULL,
            [timeRemaining] INTEGER NOT NULL,
            [currentLeader] TEXT NOT NULL
            );



            CREATE TABLE [LOGOUT] (
            [account] TEXT PRIMARY KEY  NOT NULL,
            [time] INTEGER NOT NULL,
                              
            FOREIGN KEY(account) REFERENCES [ACCOUNT](account)
            );



            CREATE TABLE [BIDS] (
            [itemID] INTEGER PRIMARY KEY NOT NULL,
            [buyerID] TEXT NOT NULL,
            [amount] INTEGER NOT NULL,



            FOREIGN KEY(itemID) REFERENCES [ITEM]([ID]),
            FOREIGN KEY(buyerID) REFERENCES [ACCOUNT]([ID])
            );";

        static string dbInsertDeletions = @"
                    BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS ITEM;
                    DROP TABLE IF EXISTS LOGOUT;
                    DROP TABLE IF EXISTS BIDS;
                    COMMIT;


            CREATE TABLE [ITEM] (
            [itemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
            [itemName] TEXT NOT NULL,
            [itemDescription] TEXT NOT NULL,
            [startingBid] INTEGER NOT NULL,                     
            [currentBid] INTEGER NOT NULL,
            [timeRemaining] INTEGER NOT NULL,
            [currentLeader] TEXT NOT NULL
            );";

        public static void InsertData(SQLiteConnection conn)
        {
            //string sql = "INSERT INTO ACCOUNT(username, password, type) VALUES(@u1, @p1, @t1), (@u2, @p2, @t2);"
            if (true)
                return;
        }
     
}
}
