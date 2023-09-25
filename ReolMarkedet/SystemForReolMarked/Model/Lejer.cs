using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Lejer
    {
        public string Id { get; set; }
        public LejerBeskrivelse LejerBeskrivelse { get; set; }
        public Lejer(string id, LejerBeskrivelse lejerBeskrivelse)
        {
            Id = id;
            LejerBeskrivelse = lejerBeskrivelse;
        }
    }
}
