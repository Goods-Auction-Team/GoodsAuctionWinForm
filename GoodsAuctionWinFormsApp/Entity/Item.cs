using System;

namespace GoodsAuctionWinFormsApp.Entity
{

    public class Item
    {
        private int itemID;
        private string itemName;
        private string itemDescription;
        private int startingBid;
        private int currentBid;
        private DateTime timeRemaining; //not sure if this is correct
        private string currentLeader;
        private int currentLeaderID;

        public int ItemID { get { return itemID;} }

        public Item()
        {

        }
        public Item(int itemID, string itemName, string itemDescription, int startingBid, int currentBid, DateTime timeRemaining, int currentLeaderID)
        {
            setItemID(itemID);
            setItemName(itemName);
            setItemDescription(itemDescription);
            setStartingBid(startingBid);
            setCurrentBid(currentBid);
            setTimeRemaining(timeRemaining);
            setCurrentLeaderID(currentLeaderID);
        }

        public int getItemID()
        {
            return this.itemID;
        }
        public void setItemID(int itemID)
        {
            this.itemID = itemID;
        }
        public string getItemName()
        {
            return this.itemName;
        }
        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }
        public string getItemDescription()
        {
            return this.itemDescription;
        }
        public void setItemDescription(string itemDescription)
        {
            this.itemDescription = itemDescription;
        }
        public float getStartingBid()
        {
            return this.startingBid;
        }
        public void setStartingBid(int startingBid)
        {
            this.startingBid = startingBid;
        }
        public int getCurrentBid()
        {
            return this.currentBid;
        }
        public void setCurrentBid(int currentBid)
        {
            this.currentBid = currentBid;
        }
        public DateTime getTimeRemaining()
        {
            return this.timeRemaining; //Not sure if this is correct
        }
        public void setTimeRemaining(DateTime timeRemaining)
        {
            this.timeRemaining = timeRemaining;
        }

        [Obsolete("use getCurrentLeaderID instead.")]
        public string getCurrentLeader()
        {
            return currentLeader; //maybe??
        }

        [Obsolete("use setCurrentLeaderID(int id) instead.")]
        public void setCurrentLeader(string username)
        {
            this.currentLeader = username;
        }


        public int getCurrentLeaderID()
        {
            return currentLeaderID; //maybe??
        }

        public void setCurrentLeaderID(int id)
        {
            this.currentLeaderID = id;
        }

    }
}
