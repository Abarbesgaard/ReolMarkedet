using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public interface IItemRepository
    {
        void AddItemToList(Item item);
        void RemoveItemFromList(Item item);

        void UpdateItemList(Item item);
    }
}
