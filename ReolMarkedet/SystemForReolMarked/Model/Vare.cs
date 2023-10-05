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

        public int Reol{ get; set; }

        private Rabat vareRabat;

        public  Rabat VareRabat
        {
            get { return vareRabat; }
            set { vareRabat = new Rabat(this, RabatIProcent); }
        }

        public VareBeskrivelse VareBeskrivelse { get; set; }

        public Vare(string StregKode, string navn, EVareType vareType, decimal pris, int rabatIProcent = 0) 
        {
            Stregkode = StregKode;
            VareBeskrivelse = new VareBeskrivelse(navn, vareType, pris);
            RabatIProcent = rabatIProcent;
            
        }

        public void TilknytReolTilVare(string stregkode, int reolId) 
        {
            VareRepository vareRepo = new VareRepository();
            int stregkodeInt = int.Parse(stregkode);
            Object vareObject = vareRepo.HentObject(stregkodeInt);
            if (vareObject is Vare vare) 
            {
                vare.Reol = reolId;
                vareRepo.Update(vare);  
            }
        }

        public void ÆndrVareNavn(string stregkode, string vareNavn) 
        {
            VareRepository vareRepo = new VareRepository();
            int stregkodeInt = int.Parse (stregkode);
            Object vareObject = vareRepo.HentObject(stregkodeInt);
            if (vareObject is Vare vare)
            {
                vare.VareBeskrivelse.Navn = vareNavn;
                vareRepo.Update(vare);
            }

        }




    }
}
