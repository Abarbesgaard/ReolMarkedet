using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Lejer
    {
        public int LejerId { get; set; }
        public LejerBeskrivelse LejerBeskrivelse { get; set; }

        public Lejer(int lejerId, string fornavn, string efternavn, bool status, string bankoplysninger, string email, string tlf)
        {
            LejerId = lejerId;
            LejerBeskrivelse = new LejerBeskrivelse(fornavn, efternavn, status, bankoplysninger, email, tlf);
        }
    }
}
