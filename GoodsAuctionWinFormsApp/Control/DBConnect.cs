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

                    /*conn.Open();
                    cmnd.Connection = conn;
                    string strSql = @"BEGIN TRANSACTION; 
                     DROP TABLE IF EXISTS ACCOUNT;
                     DROP TABLE IF EXISTS ITEM;
                     DROP TABLE IF EXISTS LOGOUT;
                     DROP TABLE IF EXISTS BIDS;
                     COMMIT;";

                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();
                    string table = @"CREATE TABLE [ACCOUNT] (ID int NOT NULL IDENTIFY(1,1),
                                 [username] TEXT PRIMARY KEY NOT NULL
                               , [password] INTEGER NOT NULL
                               , [type] TEXT NOT NULL
                               , CONSTRAINT [PK_ACCOUNT] PRIMARY KEY ([ID]));";

                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [ITEM] (
                    [ItemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [ItemName] TEXT NOT NULL
                    , [ItemDescription] TEXT NOT NULL
                    , [StatingBid] INTEGER NOT NULL                     
                    , [currentBid] INTEGER NOT NULL
                    , [timeRemaining] INTEGER NOT NULL
                    , [currentLeader] TEXT NOT NULL
                    , [Seller] TEXT NOT NULL
                    , CONSTRAINT [PK_ITEM] PRIMARY KEY ([ItemId])
                    , FOREIGN KEY([Seller]) REFERENCES [ACCOUNT]([username]));";

                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [LOGOUT] (
                                [Id] TEXT NOT NULL
                              , [Date] INTEGER NOT NULL
                              , [Time] INTEGER NOT NULL
                              , [UName] TEXT NOT NULL)
                              , CONSTRAINT [PK_LOGOUT] PRIMARY KEY ([Id])
                              , FOREIGN KEY([UName]) REFERENCES [ACCOUNT]([username]));";

                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
                    table = @"CREATE TABLE [BIDS] (
                                [ItemNo] TEXT PRIMARY KEY NOT NULL
                              , [BuyerNo] TEXT PRIMARY KEY NOT NULL
                              , [Amount] INTEGER NOT NULL
                              , CONSTRAINT [PK_BIDS] PRIMARY KEY ([ItemNo],[BuyerNo]));";

                    //ReadData(conn);
                    //*/
                }
            }


            string sql = "INSERT INTO ACCOUNT(username, password, type) VALUES(@u1, @p1, @t1), (@u2, @p2, @t2);"

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@u1", "aroe@augusta.edu");
                    cmd.Parameters.AddWithValue("@p1", hash("Password1"));
                    cmd.Parameters.AddWithValue("@t1", true);
                    cmd.Parameters.AddWithValue("@u2", "joy@shutup.net");
                    cmd.Parameters.AddWithValue("@p2", hash("Password2"));
                    cmd.Parameters.AddWithValue("@t2", false);
                    cmd.ExecuteNonQuery();
                }
            }
                }

            string sql = "INSERT INTO ITEM(itemId, itemName, itemDescription, startingBid, currentBid, timeRemaining, currentLeader) Values (@iI, @iN, @iD,@sB, @cB, @tR, @cL";

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
                }
            }
                }
            string sql = "INSERT INTO LOGOUT(date,time,accID) VALUES (@d, @t, @a);"

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@d", "");
                    cmd.Parameters.AddWithValue("@t", "");
                    cmd.Parameters.AddWithValue("@a", "Joy");
                    cmd.ExecuteNonQuery();
                }
            }
                }
            string sql = "INSERT INTO BIDS(buyerID, amount) VALUES (@i, @b, @a);" 

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@i", "");
                    cmd.Parameters.AddWithValue("@b", "");
                    cmd.Parameters.AddWithValue("@a", "Joy");
                    cmd.ExecuteNonQuery();
                }
            }
                }

        public static void ReadData()
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
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
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
                                r.GetInt32(6)
                                ));
                        }
                    }
                }
            }

            /*
            Item item1 = new Item();
            Item item2 = new Item();
            item1.setItemDescription("Mega Pie!");
            item1.setItemID(1);
            item1.setItemName("MosterPie");
            item1.setTimeRemaining((DateTime.Now).AddMinutes(1));
                        item1.setStartingBid(45);

            item2.setItemName("Vrrrrm Car");
            item2.setItemID(2);
            item2.setItemDescription("Car go fast!");
            item2.setTimeRemaining((DateTime.Now).AddMinutes(5));
                        item2.setStartingBid(5555);

            StartupController.iList.Add(item1);
            StartupController.iList.Add(item2);

            */


        }

        public static string hash(string input)
        {
            StringBuilder s = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                byte[] result = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                foreach (byte b in result)
                    s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }


        public static Account findAccount(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT *  FROM [ACCOUNT] WHERE ([username]=@user AND [password]=@pass);"; //not efficient, but where clause issues happened
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", hash(password));
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new Account(r.GetInt32(0), username, password, r.GetBoolean(3));
                        }
                        return null;
                    }
                }
            }
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

           /* bool found = false;

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
            else
                return null;*/
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


        static string dbTables = @"
                    BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS ACCOUNT;
                    DROP TABLE IF EXISTS ITEM;
                    DROP TABLE IF EXISTS LOGOUT;
                    DROP TABLE IF EXISTS BIDS;
                    COMMIT;

            CREATE TABLE [ACCOUNT] (
            [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  
            [username] TEXT UNIQUE,
            [password] CHAR(64),
            [type] BIT
            );



            CREATE TABLE [ITEM] (
            [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,

            [itemName] TEXT NOT NULL,
            [itemDescription] TEXT NOT NULL,
            [startingBid] INTEGER NOT NULL,                     
            [currentBid] INTEGER NOT NULL,
            [timeRemaining] INTEGER NOT NULL,
            [currentLeaderID] INTEGER NOT NULL
            );



            CREATE TABLE [LOGOUT] (
            [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
            [date] INTEGER NOT NULL,
            [time] INTEGER NOT NULL,
            [accID] INTEGER NOT NULL,
                              
            FOREIGN KEY(accID) REFERENCES [ACCOUNT]([ID])
            );



            CREATE TABLE [BIDS] (
            [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  
            [itemID] TEXT NOT NULL,
            [buyerID] TEXT NOT NULL,
            [amount] INTEGER NOT NULL,



            FOREIGN KEY(itemID) REFERENCES [ITEM]([ID]),
            FOREIGN KEY(buyerID) REFERENCES [ACCOUNT]([ID])
            );";


        public static void InsertData(SQLiteConnection conn)
        {
            //string sql = "INSERT INTO ACCOUNT(username, password, type) VALUES(@u1, @p1, @t1), (@u2, @p2, @t2);"
            if (true)
                return;
        }
        static string dbInserts = @"

    }
}
