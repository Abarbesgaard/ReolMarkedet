using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ReolBeskrivelse
    {
        
        public ETypeAfReol TypeAfReol { get; }
        public decimal Pris { get; }
        public bool Status { get; set; }
        public int AntalUdlejningsUger { get; private set; }

        public ReolBeskrivelse(ETypeAfReol typeafReol, bool status, decimal pris = 100.0m, int antalUdlejningsUger = 0)
        {
         
            TypeAfReol = typeafReol;
            Status = status;
            Pris = pris;
            AntalUdlejningsUger = antalUdlejningsUger;
            
        }
    }
}
