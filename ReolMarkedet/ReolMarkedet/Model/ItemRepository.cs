using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemRepository : IItemRepository
    {
        private List<Item> _items = new List<Item>();
        private Item _item;

        
        public void AddItemToList(Item item)
        {
            _item = item;
            _items.Add(item);
        }

        public void RemoveItemFromList(Item item)
        {
            _item = item;
            _items.Remove(_item);
        }

        public void UpdateItemList(Item item)
        {
            _item = item;
            string userInput = string.Empty;
            int itemID = 0;
            
            if (itemID == int.Parse(userInput)) 
            { 
            
            }
        }
    }
}
