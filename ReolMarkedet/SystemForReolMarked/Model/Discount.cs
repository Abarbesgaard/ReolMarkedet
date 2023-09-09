using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Discount
    {
        public Item Item { get; }
        public int DiscountInProcent { get; }

        public Discount(Item item, int chosenprocentDiscount)
        {
            DiscountInProcent = chosenprocentDiscount;
            Item = item;
        }

        public decimal CalculateValueOfItemDiscount(Item item)
        {
            decimal ValueOfItemDiscount = Item.ItemPrice * DiscountInProcent / 100;
            return ValueOfItemDiscount;
        }


        
    }
}
