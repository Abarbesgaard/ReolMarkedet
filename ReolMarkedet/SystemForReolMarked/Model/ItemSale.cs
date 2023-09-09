using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemSale 
    {
        public DateTime dateTime { get; set; }
        private List<Item> itemsInSale;
        
        

        public decimal CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }

        public ItemSale()
        {
            dateTime = DateTime.Now;
            itemsInSale = new List<Item>();
        }

        public void AddToitemsInSale (Item item)
        {
            itemsInSale.Add(item);
        }

        public (decimal TotalPrice, string Text) CalculatePricesPlusDiscountsPlusTotalValue()
        {
            decimal TotalPrice = 0;
            string Text = "";
            StringBuilder TextBuilder = new StringBuilder();

            foreach  (Item item in itemsInSale)
            {
                String ItemName = item.ItemName;
                decimal ItemPrice = item.ItemPrice;
                decimal ValueOfItemDiscount = item.DiscountInProcent.CalculateValueOfItemDiscount(item);
              
                TextBuilder.AppendLine($"{ItemName}: {ItemPrice}, Rabat: {ValueOfItemDiscount}");
                TotalPrice += (ItemPrice - ValueOfItemDiscount);
            }
            
            Text = TextBuilder.ToString();
            return (TotalPrice, Text);
        }
    }
}
