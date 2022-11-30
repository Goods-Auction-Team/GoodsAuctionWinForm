using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsAuctionWinFormsApp.Entity
{
    public class ItemList
    {
        List<Item> itemList = new List<Item>();

        public void addItem(Item newItem)
        {
            itemList.Add(newItem);
        }

        public List<Item> returnList()
        {
            return itemList;
        }
    }
}
