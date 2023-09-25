using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Vare
    {
        private string navn;
        private EVareType vareType;
        private decimal pris;

        public string Stregkode { get; set; }
        public Rabat Rabat { get; set; }
        public VareBeskrivelse VareBeskrivelse { get; set; }
        public Vare( string stregkode, VareBeskrivelse vareBeskrivelse, int rabat = 0) 
        {
            Stregkode = stregkode;
            Rabat = new Rabat(this, rabat, 0);
            VareBeskrivelse = new VareBeskrivelse(navn, vareType, pris);
        }
    }
}
