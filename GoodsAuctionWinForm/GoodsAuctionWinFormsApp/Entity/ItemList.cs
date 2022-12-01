using System;


namespace GoodsAuctionWinFormsApp.Entity
{

    public class ItemList
    {
        List<Item> ItemList1 = new List<Item>();

        public void addItem(Item newItem)
        {
            ItemList1.Add(newItem);
        }

        public List<Item> returnList()
        {
            return ItemList1;
        }
    }
}


