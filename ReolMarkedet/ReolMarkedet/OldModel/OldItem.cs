//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReolMarkedet.Model
//{
//    public class OldItem
//    {
//        public int Id { get; set; }
//        public OldTenant Tenant { get; set; }
//        public string Barcode { get; set; }
//        public string ItemName { get; set; }
//        public double ItemPrice { get; set; }
//        public OldPlaceType Place { get; set; }
//        public OldItemType Type { get; set; }
//        public OldDiscount Discount { get; set; }

      

//        public OldItem(int id, OldTenant tenant, string barcode, string name, double price, OldPlaceType place, OldItemType type, int chosenDiscountInProcent = 0)
//        {
//            Id = id;
//            Tenant = tenant;
//            Barcode = barcode;
//            Name = name;
//            Price = price;
//            Place = place;
//            Type = type;
//            Discount = new OldDiscount(this, chosenDiscountInProcent);
                      
//        }

       

       
//    }
//}
