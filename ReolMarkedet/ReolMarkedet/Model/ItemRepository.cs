using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemRepository : IRepository
    {
        private List<Item> _items = new List<Item>();
        private Item _item { get; }

        
        public void AddToList()
        {
            _items.Add(_item);
        }

        public void RemoveFromList()
        {
            _items.Remove(_item);
        }

        public void UpdateList()
        {
            string userInput = string.Empty;
            int itemID = 0;
            
            if (itemID == int.Parse(userInput)) 
            { 
            
            }
        }
    }
}
