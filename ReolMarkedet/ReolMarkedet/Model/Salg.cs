using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    // Ikke implementerert ordenlig
    public record Salg(int Id, DateTime Dato, decimal Total, List<SalgsLinje> SalgsLinjer, decimal Kommission = 1.15m)
    {
        public void StartSalg()
        {

        }
        public decimal BeregnTotalPris()
        { 
            decimal totalPris = 0m;
            foreach(var salgsLinje in SalgsLinjer)
            {
                Vare vare = salgsLinje.HentVare();
               
                if (vare != null)
                {
                   
                    totalPris += vare.VareBeskrivelse.Pris;
                }
            }
            return totalPris; 
        }
        public void TilføjSalgsLinje(Vare vare)
        {
            SalgsLinjer.Add(new SalgsLinje(vare));
        }
        public void TilføjSalgsLinje(ServiceYdelse serviceYdelse)
        {
            SalgsLinjer.Add(new SalgsLinje(serviceYdelse));
        }
        public void TilføjSalgsLinje(Reol reol)
        {
            SalgsLinjer.Add(new SalgsLinje(reol));
        }
        public void StopSalg() 
        {
        }
    }
}
