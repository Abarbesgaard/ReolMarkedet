using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ReolBeskrivelse
    {
        public ETypeAfReol TypeAfReol { get; set; }
        public decimal Pris { get; set; }
        public bool Status { get; set; }
        public ReolBeskrivelse(ETypeAfReol typeafReol, decimal pris, bool status)
        {
            TypeAfReol = typeafReol;
            Pris = pris;
            Status = status;
        }
    }
}
