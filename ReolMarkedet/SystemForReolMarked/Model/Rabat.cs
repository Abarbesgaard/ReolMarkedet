using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Rabat
    {
        public int ProcentSats { get; set; }
        public int AntalUger { get; set; }
        public Vare Vare { get; set; }
        public Reol Reol { get; set; }
        public Rabat(Vare vare = null, Reol reol = null, int procentSats = 0, int antalUger = 0)
        {
            ProcentSats = procentSats;
            AntalUger = antalUger;
            Vare = vare;
            Reol = reol;

        }

        public Rabat (ServiceYdelse serviceYdelse, )

        public decimal VærdiAfRabat()
        {

            decimal værdiAfRabat = Vare.VareBeskrivelse.Pris * ProcentSats / 100;
            return værdiAfRabat;
        }
    }
}
