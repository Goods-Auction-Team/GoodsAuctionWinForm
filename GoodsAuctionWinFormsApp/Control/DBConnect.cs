using GoodsAuctionWinFormsApp.Boundary;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Control
{
    public class DBConnect : Controller
    {
        private Account user;
        private Item itemID;
        private ItemList item;
        private Account username;

        public void initDB()
        {
            
        }

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
    }
}

//John's code
//namespace CarRentalSystem.Controllers
//{
//    public static class DBConnector
//    {
//        public static void InitializeDB()
//        {
//            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
//            {
//                using (SQLiteCommand cmnd = new SQLiteCommand())
//                {
//                    conn.Open();
//                    cmnd.Connection = conn;
//                    string strSql = @"BEGIN TRANSACTION; 
//                    DROP TABLE IF EXISTS ACCOUNT;
//                    DROP TABLE IF EXISTS LOGIN;
//                    DROP TABLE IF EXISTS LOGOUT;
//                    DROP TABLE IF EXISTS ITEM;
//                    DROP TABLE IF EXISTS BIDS;
//                    COMMIT;";
//                    cmnd.CommandText = strSql;
//                    cmnd.ExecuteNonQuery();
//                    string table = @"CREATE TABLE [ACCOUNT] (
//                                  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
//                                , [username] INTEGER NOT NULL
//                                , [password] INTEGER NOT NULL
//                                , [type] TEXT NOT NULL
//                                );";
//                    // DOES THIS NEED TO BE DELETED?
//                    //cmnd.CommandText = table;
//                    // cmnd.ExecuteNonQuery();
//                    //table = @"CREATE TABLE [LOGIN] (
//                    // [acctID] INTEGER NOT NULL
//                    //, [timestamp] TEXT NOT NULL
//                    //, CONSTRAINT [PK_LOGIN] PRIMARY KEY ([acctID],[timestamp])
//                    // , FOREIGN KEY([acctID]) REFERENCES [ACCOUNT]([id])
//                    // );";
//                    cmnd.CommandText = table;
//                    cmnd.ExecuteNonQuery();
//                    table = @"CREATE TABLE [LOGOUT] (
//                    [Id] INTEGER NOT NULL
//                    , [Date] TEXT NOT NULL
//                    , [Time] TEXT NOT NULL
//                    , [UName] TEXT NOT NULL
//                    , CONSTRAINT [PK_LOGOUT] PRIMARY KEY ([Id])
//                    , FOREIGN KEY([UName]) REFERENCES [ACCOUNT]([UserName])
//                    );";
//                    cmnd.CommandText = table;
//                    cmnd.ExecuteNonQuery();
//                    table = @"CREATE TABLE [ITEM] (
//                    [ItemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
//                    , [ItemDescription] TEXT NOT NULL
//                    , [ItemName] TEXT NOT NULL
//                    , [StatingBid] TEXT NOT NULL
//                    , [Seller] TEXT NOT NULL
//                    , CONSTRAINT [PK_ITEM] PRIMARY KEY ([ItemId])
//                    , FOREIGN KEY([Seller]) REFERENCES [ACCOUNT]([Type])
//                    );";
//                    cmnd.CommandText = table;
//                    cmnd.ExecuteNonQuery();
//                    table = @"CREATE TABLE [BIDS] (
//                    [ItemNo] INTEGER NOT NULL
//                    , [BuyerNo] INTEGER NOT NULL
//                    , [Amount] INTEGER NOT NULL
//                    , CONSTRAINT [PK_BIDS] PRIMARY KEY ([ItemNo],[BuyerNo])
//                    );";
//                    // DOES THIS NEED TO BE DELETED/OR JUST MOD?
//                    cmnd.CommandText = table;
//                    cmnd.ExecuteNonQuery();
//                    strSql = @"BEGIN TRANSACTION; 
//                    INSERT INTO ACCOUNT (username, password, type) VALUES ($hashusr1, $hashpwd1, 'customer');
//                    INSERT INTO ACCOUNT (username, password, type) VALUES ($hashusr2, $hashpwd2, 'employee');
//                    INSERT INTO VEHICLE (make, model, year) VALUES ('Honda', 'Civic', '2021');
//                    INSERT INTO VEHICLE (make, model, year) VALUES ('Subaru', 'Outback', '2021');
//                    INSERT INTO RESERVATION (acctID, vid, startDate, endDate) VALUES (1, 1, 20211201, 20211203);
//                    COMMIT;";
//                    cmnd.CommandText = strSql;
//                    string usrname1 = "cus";
//                    string pwd1 = "1qaz";
//                    string usrname2 = "emp";
//                    string pwd2 = "2wsx";
//                    int x = usrname1.GetHashCode();
//                    int y = pwd1.GetHashCode();
//                    int x1 = usrname2.GetHashCode();
//                    int y1 = pwd2.GetHashCode();
//                    cmnd.Parameters.AddWithValue("$hashusr1", x);
//                    cmnd.Parameters.AddWithValue("$hashpwd1", y);
//                    cmnd.Parameters.AddWithValue("$hashusr2", x1);
//                    cmnd.Parameters.AddWithValue("$hashpwd2", y1);
//                    cmnd.ExecuteNonQuery();
//                    conn.Close();
//                }
//            }
//        }
//        public static Account GetUser(string usr, string pwd)
//        {
//            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
//            {
//                conn.Open();
//                int x = usr.GetHashCode();
//                int y = pwd.GetHashCode();
//                string stm = @"SELECT[Id]
//                        ,[username]
//                        ,[password]
//                        ,[type]             
//                        FROM[ACCOUNT]
//                        WHERE[username] == ($name)
//                        AND[password] == ($pd);";
//                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
//                {
//                    cmnd.Parameters.AddWithValue("$name", x);
//                    cmnd.Parameters.AddWithValue("$pd", y);
//                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
//                    {
//                        while (rdr.Read())
//                        {
//                            Account acct = new Account(rdr.GetInt32(0), usr, rdr.GetString(3));
//                            return acct;
//                        }
//                        Account act = new Account(0, null, null);
//                        return act;
//                    }
//                }
//            }
//        }
//        public static List<Item> getItem()
//        {
//            List<Item> ItemInfoList = new List<Item>();
//            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db")) //update
//            {
//                using (SQLiteCommand cmnd = new SQLiteCommand())
//                {
//                    conn.Open();
//                    cmnd.Connection = conn;
//                    cmnd.CommandText = "SELECT * FROM ITEM;";
//                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
//                    {
//                        while (rdr.Read())
//                        {
//                            ItemInfoList.Add(new Item(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4)));
//                        }
//                    }
//                }
//            }
//            return ItemInfoList;
//        }
//        public static void SaveLogin(string usr)
//        {
//            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
//            {
//                conn.Open();
//                DateTime time = DateTime.Now;
//                string t = time.ToString("s");
//                int id = 0;
//                int hash = usr.GetHashCode();
//                string stm = "SELECT [id] FROM ACCOUNT WHERE username = ($name);";
//                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
//                {
//                    cmnd.Parameters.AddWithValue("$name", hash);
//                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
//                    {
//                        while (rdr.Read())
//                        {
//                            id = rdr.GetInt32(0);
//                        }
//                    }
//                }
//                stm = @"INSERT INTO LOGIN VALUES($id, $time);";
//                using (SQLiteCommand cmnd = new SQLiteCommand())
//                {
//                    cmnd.Connection = conn;
//                    cmnd.CommandText = stm;
//                    cmnd.Parameters.AddWithValue("$id", id);
//                    cmnd.Parameters.AddWithValue("$time", t);
//                    cmnd.ExecuteNonQuery();
//                }
//            }
//        }
//        public static Item GetItem(int id) // returns item info from database
//        {
//            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
//            {
//                conn.Open();
//                {
//                    SQLiteCommand cmd = conn.CreateCommand();
//                    cmd.CommandText = "SELECT * FROM ITEM WHERE id = '" + id + "';";
//                    SQLiteDataReader reader = cmd.ExecuteReader();
//                    reader.Read();
//                    Item I = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
//                    reader.Close();
//                    conn.Close();
//                    return I;
//                }
//            }
//        }
//        public static bool Bids(int itemno, int buyerno, int amount) // DOUBLE CHECK  
//        {
//            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
//            {
//                conn.Open();
//                {
//                    SQLiteCommand cmd = conn.CreateCommand();
//                    // STILL WORKING
//                    cmd.CommandText = "SELECT 1 FROM RESERVATION WHERE vid = '" + vid
//                    + "' AND startDate = '" + inputStart
//                    + "' OR vid = '" + vid + "' AND startDate = '" + inputEnd
//                    + "' OR vid = '" + vid + "' AND endDate = '" + inputStart
//                    + "' OR vid = '" + vid + "' AND endDate = '" + inputEnd
//                    + "' OR vid = '" + vid + "' AND startDate < '" + inputStart
//                    + "' AND '" + inputStart + "' < endDate OR vid = '" + vid
//                    + "' AND startDate < '" + inputEnd + "' AND '" + inputEnd
//                    + "' < endDate OR vid = '" + vid + "' AND '" + inputStart
//                    + "' < startDate AND '" + inputEnd
//                    + "' > endDate;";
//                    SQLiteDataReader reader = cmd.ExecuteReader();
//                    reader.Read();
//                    if (reader.HasRows)
//                    {
//                        reader.Close();
//                        conn.Close();
//                        return false; // a reservation conflict exists; unavailable to reserve for user input dates
//                    }
//                    else
//                    {
//                        reader.Close();
//                        conn.Close();
//                        return true; // no conflict; available for user input dates
//                    }
//                }
//            }
//        }
//        // STILL WORKING
//        public static void SaveLogout(string usr)
//        {
//            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
//            {
//                conn.Open();
//                DateTime time = DateTime.Now;
//                string t = time.ToString("s");
//                int id = 0;
//                int hash = usr.GetHashCode();
//                string stm = "SELECT [id] FROM ACCOUNT WHERE username = ($name);";
//                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
//                {
//                    cmnd.Parameters.AddWithValue("$name", hash);
//                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
//                    {
//                        while (rdr.Read())
//                        {
//                            id = rdr.GetInt32(0);
//                        }
//                    }
//                }
//                stm = @"INSERT INTO LOGOUT VALUES($id, $time);";
//                using (SQLiteCommand cmnd = new SQLiteCommand())
//                {
//                    cmnd.Connection = conn;
//                    cmnd.CommandText = stm;
//                    cmnd.Parameters.AddWithValue("$id", id);
//                    cmnd.Parameters.AddWithValue("$time", t);
//                    cmnd.ExecuteNonQuery();
//                }
//            }
//        }
//        public static void Save(int itemno, int buyerno, int amount) // saves bids to database
//        {
//            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
//            {
//                conn.Open();
//                {
//                    SQLiteCommand cmd = conn.CreateCommand();
//                    try
//                    {
//                        cmd.CommandText = "INSERT INTO BIDS (ItemNo, BuyerNo, Amount) VALUES (  );"; // ADD BID VALUES TO TABLE?
//                        cmd.ExecuteNonQuery();
//                    }
//                    catch
//                    {
//                        AddItemForm.instance.Close();
//                        throw new Exception("Entry already exist in database"); // somewhat redundant
//                    }
//                    finally
//                    {
//                        AddItemForm.instance.Close(); // reservationForm closes after reservation saved to database
//                    }
//                }
//            }
//        }
//        //STOPPED
//        public static List<Vehicle> checkAvailDates(int start, int end)
//        {
//            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
//            {
//                conn.Open();
//                {
//                    List<Vehicle> V = new List<Vehicle>();
//                    SQLiteCommand cmd = conn.CreateCommand();
//                    cmd.CommandText = "SELECT * FROM Vehicle;";
//                    SQLiteDataReader r = cmd.ExecuteReader();
//                    while (r.Read())
//                    {
//                        V.Add(new Vehicle(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3)));
//                    }
//                    r.Close();
//                    cmd.CommandText = "SELECT vid FROM Reservation WHERE (startDate <= " + start
//                        + " AND endDate >= " + end
//                        + ") OR (startDate >= " + start + " AND startDate <= " + end
//                        + " AND endDate >= " + end
//                        + ") OR (startDate >= " + start + " AND endDate <= " + end + ")" +
//                        "OR (startDate <= " + start + " AND endDate <= " + end + " AND endDate >= " + start + ");";
//                    SQLiteDataReader reader = cmd.ExecuteReader();
//                    List<int> idlist = new List<int>();
//                    while (reader.Read())
//                    {
//                        int vid = reader.GetInt32(0);
//                        idlist.Add(vid);
//                    }
//                    reader.Close();
//                    conn.Close();
//                    for (int i = 0; i < idlist.Count; i++)
//                    {
//                        for (int j = 0; j < V.Count; j++)
//                        {
//                            if (idlist[i] == V[j].GetVid())
//                            {
//                                V.RemoveAt(j);
//                            }
//                        }
//                    }
//                    return V;
//                }
//            }
//        }
//    }
