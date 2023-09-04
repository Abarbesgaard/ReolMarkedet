using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemSale : ISale
    {
        public DateTime Date { get; set; }

        public List<Item> items = new List<Item>();

        public void CreateSale()
        {
            float result = 0;
            foreach (var item in items) 
            {
                result += item.Price;
            }
            Console.WriteLine(result);
        }
    }
}
