using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Rabat
    {
        public int RabatIProcent { get; set; }
        public int AntalUger { get; set; }
        public Vare Vare { get; set; }
        public Reol Reol { get; set; }

        

        public Rabat(Vare vare, int rabatIProcent = 0)
        {
            Vare = vare; 
            RabatIProcent = rabatIProcent;
           
        }

        public Rabat(Reol reol, int antalUger) 
        {
            Reol = reol;
            AntalUger = antalUger;
        }
                

        public decimal BeregnVærdiAfVareRabat()
        {
            decimal værdiAfVareRabat = Vare.VareBeskrivelse.Pris * RabatIProcent / 100;
            return værdiAfVareRabat;
        }

        public decimal BeregnVærdiAfReolRabat()
        {
            decimal værdiAfReolRabat = 0m;

            if (0 < Reol.ReolBeskrivelse.AntalUdlejningsUger && Reol.ReolBeskrivelse.AntalUdlejningsUger <= 3)
            {
                værdiAfReolRabat = 0.0m;
                return værdiAfReolRabat;
            }
            if (Reol.ReolBeskrivelse.AntalUdlejningsUger == 4)
            {
                værdiAfReolRabat = 50.0m;
                return værdiAfReolRabat;
            }

            if ( 4 < Reol.ReolBeskrivelse.AntalUdlejningsUger && Reol.ReolBeskrivelse.AntalUdlejningsUger <=7) 
            {
                decimal opnåetLejeRabatvedLejeOver4Uger = (50/400) * 100;
                værdiAfReolRabat = opnåetLejeRabatvedLejeOver4Uger * Reol.ReolBeskrivelse.AntalUdlejningsUger;
                return værdiAfReolRabat;
            }

            if (Reol.ReolBeskrivelse.AntalUdlejningsUger == 8) 
            {
                værdiAfReolRabat = 200.0m;
                return værdiAfReolRabat;
            }

            if ( 8 < Reol.ReolBeskrivelse.AntalUdlejningsUger) 
            {
                decimal UgentligRabatPåReol = 25.0m;
                værdiAfReolRabat = AntalUger * UgentligRabatPåReol;
                return værdiAfReolRabat;
            }

            else 
            {
                throw new Exception();
                
            }
                    

        }
    }
}
