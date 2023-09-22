using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model.Repositories
{
    public class ReolRepository : IObjectInterface
    {
        private List<Reol> _reoler = new List<Reol>();
        public void Fjern(object obj)
        {
            throw new NotImplementedException();
        }

        public object HentViaStregkode(object obj)
        {
            string søgeStregkode = obj.ToString();
            foreach (var reol in _reoler)
            {
                if (reol.Id == søgeStregkode)
                    return reol;
            }
            return null;
        }

        public void Opdater(object obj)
        {
            throw new NotImplementedException();
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            if (obj is Reol reol)
            {
                _reoler.Add(reol);
            }
            else
            {
                throw new ArgumentException("Objektet er ikke af typen Vare");
            }
        }
    }
}
