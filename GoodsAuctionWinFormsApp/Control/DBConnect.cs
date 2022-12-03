using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GoodsAuctionWinFormsApp.Control
{
    public static class DBConnect
    {
        public static void InitDB()
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nAuctionDb.db"))
            {
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    conn.Open();
                    cmnd.Connection = conn;
                    string strSql = @"BEGIN TRANSACTION; 
                     DROP TABLE IF EXISTS ACCOUNT;
                     DROP TABLE IF EXISTS ITEM;
                     DROP TABLE IF EXISTS LOGOUT;
                     DROP TABLE IF EXISTS BIDS;
                     COMMIT;";

                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();
                    string table = @"CREATE TABLE [ACCOUNT] (
                                 [username] TEXT PRIMARY KEY NOT NULL
                               , [password] TEXT NOT NULL
                               , [type] TEXT NOT NULL
                               , CONSTRAINT [PK_ACCOUNT] PRIMARY KEY ([username]));";

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
                }
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
                "                                          'Password1','auctioneer')";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText = "INSERT INTO ACCOUNT(username" +
                "                                          , password" +
                "                                          , type) VALUES ('bidder@email.com'," +
                "                                          'Password1','bidder')";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText = "INSERT INTO ITEM(itemId" +
                "                                         ,itemName" +
                "                                         ,itemDescription" +
                "                                         ,startingBid" +
                "                                         ,currentBid" +
                "                                         ,timeRemaining" +
                "                                         ,currentLeader" +
                "                                         ,Seller) VALUES ('','','','','','','','')";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText = "INSERT INTO LOGOUT(Id" +
    "                                         ,Date" +
    "                                         ,Time" +
    "                                         ,UName) VALUES('', '', '', '')";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText = "INSERT INTO BIDS(ItemNo" +
    "                                          , BuyerNo" +
    "                                          , Amount) VALUES ('','','')";
            sqliteCommand.ExecuteNonQuery();
        }
      public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand=conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM ACCOUNT";
            sqliteReader = sqliteCommand.ExecuteReader();   
            while(sqliteReader.Read())
            {
                string readerstring = sqliteReader.GetString(0);    
            }

            sqliteCommand.CommandText = "SELECT * FROM ITEM";
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                string readerstring = sqliteReader.GetString(0);
            }
            
            sqliteCommand.CommandText = "SELECT * FROM LOGOUT";
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                string readerstring = sqliteReader.GetString(0);
            }

            sqliteCommand.CommandText = "SELECT * FROM BIDS";
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                string readerstring = sqliteReader.GetString(0);
            }
        }
   
        
//Joy's code
      //public class DBConnect : Controller
      //  {
      //      private Account user;
      //      private Item itemID;
      //      private ItemList item;
      //      private Account username;
                        
      //      public DBConnect(Account username)
      //      {
      //          this.username = username;
      //      }

      //      public Account getUser()
      //      {
      //          return username;
      //      }
      //      public void saveLogout(Account username)
      //      {
      //          this.username = username;
      //      }

      //      public Item getItem(Item itemID)
      //      {
      //          //This item ID returns the item
      //          return null;
      //      }

      //      public ItemList modifyItem(Item itemID, string newBid, Account username)
      //      {
      //          return null;//This is the placebid where it updates the item after bid and 
      //                      //returns ItemList
      //          return null;
      //      }

      //      public ItemList saveItem(Item item)
      //      {
      //          //This is the addItem where the data is saved
      //          return null;
      //      }

      //      // adding saveLogout(un) from sequence diagram
      //      public bool saveLogout(string username)
      //      {
      //          // not sure if this is right, but I'm trying to check if it saved correctly
      //          // if true, sends it back to LoginForm for (logged out sucess)
      //          if (username != null)
      //          {
      //              return true;
      //          }
      //          else { return false; }
      //      }
      //  }
    }
}


