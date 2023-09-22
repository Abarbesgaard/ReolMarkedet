using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public record LejerBeskrivelse(string ForNavn, string EfterNavn, bool Status, string BankOplysninger, string Email, string Tlf);
}
