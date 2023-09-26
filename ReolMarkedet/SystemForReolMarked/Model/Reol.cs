using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Reol
    {
        public int ReolId { get; set; }
        public ReolBeskrivelse ReolBeskrivelse { get; set; }
        public Rabat UdlejningsRabat { get; private set; }
        public static Lejer Lejer { get; private set; }

        public LejerRepository lejerRepo = new LejerRepository();

        public Reol(int reolId, ETypeAfReol typeAfReol, bool status, decimal pris, int antalUdlejningsUger = 0, Rabat udlejningsRabat = null)
        {
            ReolId = reolId;
            ReolBeskrivelse = new ReolBeskrivelse(typeAfReol, status, pris, antalUdlejningsUger );
            UdlejningsRabat = new Rabat(this, antalUdlejningsUger);
            
        }

        //public void TilføjLejer(string reolId, string lejerId) 
        //{
        //    List<Lejer> lejerList = lejerRepo.HentAlleLejere();
        //    foreach(Lejer l in lejerList) 
        //    {
        //        if (l.LejerId == lejerId) 
        //        {
        //            Reol.Lejer = l;

        //        }
        //    }

        //}
        
      

    }
}
