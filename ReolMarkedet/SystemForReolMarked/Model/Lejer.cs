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

        public Lejer(string fornavn, string efternavn, string status, string bankoplysninger, string email, string tlf, int lejerId)
        {
            LejerId = lejerId;
            LejerBeskrivelse = new LejerBeskrivelse(fornavn, efternavn, status, bankoplysninger, email, tlf);
        }

        public override string ToString()
        {
            return $"lejerId: {LejerId}, fornavn: {LejerBeskrivelse.Fornavn}, efternavn: {LejerBeskrivelse.Efternavn}, status: {LejerBeskrivelse.Status}, bankoplysninger: {LejerBeskrivelse.BankOplysninger}, email: {LejerBeskrivelse.Email}, tlf: {LejerBeskrivelse.Tlf}";
        }
    }
}
