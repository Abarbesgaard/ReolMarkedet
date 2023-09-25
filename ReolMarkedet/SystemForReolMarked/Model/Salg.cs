using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class Salg
    {
        public  int Id { get; set; }
        public DateTime Dato { get; set; }
        public decimal Kommision { get; } = 0.15m;

        private static int SalgsNummer = 0;
        



        public Salg() 
        {

            SalgsNummer++;
            Dato = DateTime.Now;
            SalgsLinje salgsLinje = new SalgsLinje();


        }

        




    }
}
