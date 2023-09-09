//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReolMarkedet.Model
//{
//    public class OldItemSale
//    {
//        public DateTime DateOfSale { get; private set; }
//        private List<OldItem> items;
//        public void Add(OldItem item)
//        {
//           items.Add(item);
//        }

//        public double CalculateTotalItemPrice()
//        {
//            double total = 0;
//            foreach (OldItem item in items)
//            {   
//                total += item.Price;
//            }
//            return total;
//        }

//        public OldItemSale()
//        {
//            DateTime dateOfSale = DateTime.Now;
//            items = new List<OldItem>();
//        }
//    }
//}
