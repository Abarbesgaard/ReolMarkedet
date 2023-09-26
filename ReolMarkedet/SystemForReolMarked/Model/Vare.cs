using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Vare
    {
        
        public string Stregkode { get; set; }
        public int RabatIProcent { get; set; }
        public Rabat VareRabat { get; private set; }
        public VareBeskrivelse VareBeskrivelse { get; set; }

        public Vare( string stregkode, string navn, EVareType vareType, decimal pris, int rabatIProcent = 0) 
        {
            Stregkode = stregkode;
            VareBeskrivelse = new VareBeskrivelse(navn, vareType, pris);
            RabatIProcent = rabatIProcent;
            VareRabat = new Rabat(this, rabatIProcent);
        }
    }
}
