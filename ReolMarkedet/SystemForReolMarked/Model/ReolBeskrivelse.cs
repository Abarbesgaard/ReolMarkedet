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
        public string Status { get; set; } = "ledig";

        private int antalUdlejningsUger;

        public int AntalUdlejningsUger { get; set; } = 0;

        
        public DateTime FørsteLedigedato { get; set; } = new DateTime(2000, 1, 1, 00, 00, 0);

        public ReolBeskrivelse(ETypeAfReol typeafReol, string status, decimal pris = 100.0m, DateTime førsteLedigedato, int antalUdlejningsUger)
        {
         
            TypeAfReol = typeafReol;
            Status = status;
            Pris = pris;
            AntalUdlejningsUger = antalUdlejningsUger;
            FørsteLedigedato = førsteLedigedato;
            
        }
    }
}
