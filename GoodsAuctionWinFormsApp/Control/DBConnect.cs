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
        }

        public ItemList modifyItem(Item itemID, string newBid, Account username)
        {
            //This is the placebid where it updates the item after bid and 
            //returns ItemList
        }

        public ItemList saveItem(Item item)
        {
            //This is the addItem where the data is saved
        }

    }
}
