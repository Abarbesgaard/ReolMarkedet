using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class LejerBeskrivelse
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public bool Status { get; set; }
        public string BankOplysninger { get; set; }
        public string Email { get; set; }
        public string Tlf { get; set; }

        public LejerBeskrivelse(string fornavn, string efternavn, bool status, string bankoplysninger, string email, string tlf)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Status = status;
            BankOplysninger = bankoplysninger;
            Email = email;
            Tlf = tlf;
        }
    }
}
