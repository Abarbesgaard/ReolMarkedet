using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReolMarkedet.Model.Repositories
{
    public class VareRepository : IObjectInterface
    {
        public List<Vare> _varer = new List<Vare>();
        private Vare Vare { get; set; }

        public void Fjern(object obj)
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
            if (obj is Vare vare)
            {
                _varer.Add(vare);
            }
            else
            {
                throw new ArgumentException("Objektet er ikke af typen Vare");
            }
        }

        object IObjectInterface.HentViaStregkode(object obj)
        {
            string søgeStregkode = obj.ToString();
            foreach (var vare in _varer)
            {
                if (vare.Stregkode == søgeStregkode)
                    return vare;
            }
            return null;
        }

        public void List()
        {
            decimal varensSamletPris = 0;
            decimal rabat = 0;
            string mellemrum = "     ";

            foreach (var vare in _varer)
            {
                varensSamletPris = vare.VareBeskrivelse.Pris;
                if (vare.Rabat != null)
                {
                    varensSamletPris = Math.Round((vare.VareBeskrivelse.Pris - vare.VareBeskrivelse.Pris * vare.Rabat.ProcentSats), 2);
                    rabat = (vare.Rabat.ProcentSats * 100);
                    Console.WriteLine($"{vare.VareBeskrivelse.Name}: {varensSamletPris}{mellemrum}rabat:  {rabat}%");
                }
                else
                    Console.WriteLine($"{vare.VareBeskrivelse.Name}: {varensSamletPris}");
            }

        }
    }
}
