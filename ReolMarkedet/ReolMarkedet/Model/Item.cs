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
        public int Id { get; set; }
        public string Tenant { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Place { get; set; }
        public TypeEnum Type { get; set; }
        public float Discount { get; set; }

        
    }
}
