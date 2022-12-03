using System;
using System.Collections;

namespace GoodsAuctionWinFormsApp.Entity
{

    //Allows enumeration of List
    public class ItemList :IEnumerable<Item>
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

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}


