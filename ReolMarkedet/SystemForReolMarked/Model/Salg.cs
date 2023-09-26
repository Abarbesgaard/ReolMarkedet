using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Salg
    {
        public int Id { get; set; }
        public DateTime Dato { get; set; }
        public decimal Kommision { get; } = 0.15m;

        private static int SalgsNummer = 0;
        private SalgsLinje salgsLinje = new SalgsLinje();




        public Salg()
        {

            SalgsNummer++;
            Dato = DateTime.Now;
          


        }

        public void UdskrivKvitterig() 
        {
            
            Console.WriteLine($"SalgId: {SalgsNummer}");
            Console.WriteLine($"Dato: {Dato.ToString()}");
            salgsLinje.HentIndkøbsListeLinjer();
        }






    }
}
