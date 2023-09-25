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

        private static ReolRepository instance;
        public static ReolRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ReolRepository();
            }
            return instance;
        }
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

        public void List()
        {          
            foreach (Reol reol in _reoler)
            {
                if (reol.Lejer == null)
                    Console.WriteLine($"Id: {reol.Id} Type: {reol.ReolBeskrivelse.TypeAfReol}. Er ikke udlejet");
                
            }      
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
