using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model.Repositories
{
    public class SalgRepository : IObjectInterface
    {
        private List<Salg> _salg = new List<Salg>();
        public void Fjern(object obj)
        {
            throw new NotImplementedException();
        }

        public object HentViaStregkode(object obj)
        {
            string søgeStregkode = obj.ToString();
            foreach (var salg in _salg)
            {
                if (salg.Id.ToString() == søgeStregkode)
                    return salg;
            }
            return null;
        }

        public void List()
        {
            throw new NotImplementedException();
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
            if (obj is Salg salg)
            {
                _salg.Add(salg);
            }
            else
            {
                throw new ArgumentException("Objektet er ikke af typen Salg");
            }
        }
    }
}
