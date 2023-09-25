using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Reol
    {
        public string Id { get; set; }
        public ReolBeskrivelse ReolBeskrivelse { get; set; }
        public Rabat Rabat { get; set; }
        private Lejer _lejer;

        public Reol(string id, ReolBeskrivelse reolbeskrivelse, Rabat rabat = null, Lejer lejer = null)
        {

        }

    }
}
