using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolMarkedet.Model.Enum;

namespace ReolMarkedet.Model
{
    public class Item
    {
        public int ID { get; set; }
        public string Tenant { get; set; } 
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; } 
        public string Place { get; set; }

        public TypeEnum Type{ get; set; }
        public float Discount { get; set; }

        public Item(
            int id,  
            string tenant,
            string barcode, 
            string name,
            float price,
            string place,
            TypeEnum type, 
            float discount)
        {
            this.ID = id;
            this.Tenant = tenant;
            this.Barcode = barcode;
            this.Name = name;
            this.Price = price;
            this.Place = place;
            this.Type = type;
            this.Discount = discount;
        }
    }
}
