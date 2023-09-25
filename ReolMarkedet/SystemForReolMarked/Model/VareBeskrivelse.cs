using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class VareBeskrivelse
    {
        public string Navn { get; set; }
        public EVareType VareType { get; set; }
        public decimal Pris { get; set; }
        public VareBeskrivelse(string navn, EVareType vareType, decimal pris) 
        {
            Navn = navn;
            VareType = vareType;
            Pris = pris;
        }
    }
}
