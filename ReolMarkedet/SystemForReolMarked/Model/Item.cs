using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReolMarkedet.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public Tenant Tenant { get; }
        public string Barcode { get; }
        public string ItemName { get; }
        public decimal ItemPrice { get;  }
        public PlaceType PlaceEnum { get; }
        public ItemType TypeEnum { get; }
        public Discount DiscountInProcent { get; set; }


        public Item(Tenant tenant, string barcode, string itemName, decimal itemPrice, PlaceType placeEnum, ItemType typeEnum, int discountInProcent = 0)
        { 
            Tenant = tenant;
            Barcode = barcode;
            ItemName = itemName;
            ItemPrice = itemPrice;
            PlaceEnum = placeEnum;
            TypeEnum = typeEnum;
            DiscountInProcent = new Discount(this, discountInProcent);

        }
    }
}
