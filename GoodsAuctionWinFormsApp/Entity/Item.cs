using System;

namespace GoodsAuctionWinFormsApp.Entity
{

    public class Item
    {
        private int itemID;
        private string itemName;
        private string itemDescription;
        private float startingBid;
        private float currentBid;
        private DateTime timeRemaining; //not sure if this is correct
        private string currentLeader;
        private Account username;

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
        public void setStartingBid(float startingBid)
        {
            this.startingBid = startingBid;
        }
        public float getCurrentBid()
        {
            return this.currentBid;
        }
        public void setCurrentBid(float currentBid)
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
        public string getCurrentLeader()
        {
            return currentLeader; //maybe??
        }
        public void setCurrentLeader(string username)
        {
            this.currentLeader = username;
        }

    }
}