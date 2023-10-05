using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Reol
    {
        public override string ToString()
        {
            return $"ReolId: {ReolId}, ReolType: {ReolBeskrivelse.TypeAfReol}, Status: {ReolBeskrivelse.Status}, Pris: {ReolBeskrivelse.Pris}, Antal UdlejningsUger: {ReolBeskrivelse.AntalUdlejningsUger}"; 
        }
        public int ReolId { get; set; }
        public ReolBeskrivelse ReolBeskrivelse { get; set; }

        private Rabat udlejningsRabat;

        public Rabat UdlejningsRabat
        {
            get { return udlejningsRabat; }
            set { udlejningsRabat = new Rabat(this, ReolBeskrivelse.AntalUdlejningsUger); }
        }

        public int LejerId { get; set; }

       

        public LejerRepository lejerRepo = new LejerRepository();

        public Reol(int reolId, ETypeAfReol typeAfReol, string status, decimal pris, int antalUdlejningsUger = 0)
        {
            ReolId = reolId;
            ReolBeskrivelse = new ReolBeskrivelse(typeAfReol, status, pris, antalUdlejningsUger );
            FørsteLedigedato = førsteLedigedato;
            UdlejningsRabat = new Rabat(this, antalUdlejningsUger);
            
        }

        public void TilknytLejerTilReol(int reolId, int lejerId) 
        {
            LejerRepository lejerRepo = new LejerRepository();
            Object lejerObject = lejerRepo.HentObject(lejerId);
            if(lejerObject is Lejer)
            {
                Lejer lejer = (Lejer) lejerObject;  
                this.LejerId = lejerId;
                this.ReolBeskrivelse.Status = "Udlejet";
            }
           
        }

        public DateTime BeregnLejemåletsStartDato(int reolId) 
        {
            DateTime dagsDato = DateTime.Now;
            int dagsDatoInt = (int)dagsDato.DayOfWeek;
            int dageTilFørstkommendeSøndag = 7 - dagsDatoInt;
            DateTime lejemåletsStartDato = dagsDato.AddDays(dageTilFørstkommendeSøndag);
            return lejemåletsStartDato;

        }
        
        public DateTime BeregnDatoHvorLejemålUdløber(int reolId) 
        {
            ReolRepository reolRepo = new ReolRepository(); 
            Object reolObject = reolRepo.HentObject(reolId);
            if(reolObject is Reol) 
            {
                Reol reol = (Reol)reolObject;

                DateTime dagsDato = DateTime.Now;
                int dagsDatoInt = (int)dagsDato.DayOfWeek;
                int dageTilFørstkommendeLørdag= 6 - dagsDatoInt;
                int lejemåletIAntalDage = reol.ReolBeskrivelse.AntalUdlejningsUger * 7;
                int samletAntalDageTilLejemålUdløber = dageTilFørstkommendeLørdag + lejemåletIAntalDage;
                DateTime lejemålsSlutDato = dagsDato.AddDays(samletAntalDageTilLejemålUdløber);
                return lejemålsSlutDato;

            }
            else { throw new Exception(); }
            


        }


       
        
      

    }
}
