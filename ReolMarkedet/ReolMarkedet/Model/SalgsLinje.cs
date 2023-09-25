using ReolMarkedet.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class SalgsLinje
    {
        public VareRepository VareRepository = new VareRepository();
        public ReolRepository ReolRepository = new ReolRepository();
        private List<ServiceYdelse> _serviceYdelse = new List<ServiceYdelse>();
        private List<Vare> _varer = new List<Vare>();
        private List<Reol> _reoler = new List<Reol>();

        public SalgsLinje(Vare vare)
        {
            _varer.Add(vare);
        }
        public SalgsLinje(ServiceYdelse serviceYdelse)
        {
            _serviceYdelse.Add(serviceYdelse);
        }

        public SalgsLinje(Reol reol)
        {
            _reoler.Add(reol);
        }

        public Reol HentReol()
        {
            if (_reoler.Count > 0)
            {
                return _reoler[0]; // Returnerer den første reol i listen
            }
            else
            {
                return null; // Returnerer null hvis der ikke er nogen reoler
            }
        }
        public Vare HentVare() 
        {
            if (_varer.Count > 0)
            {
                return _varer[0]; // Returnerer den første vare i listen
            }
            else
            {
                return null; // Returnerer null hvis der ikke er nogen varer
            }
        }
            
    }
}
