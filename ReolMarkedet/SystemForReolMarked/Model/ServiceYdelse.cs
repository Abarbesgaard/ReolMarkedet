using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ServiceYdelse
    {
        public  string Stregkode { get; }
        public  decimal Pris { get; set; }
     

        public ETypeOfService TypeOfService { get; set; }

        public ServiceYdelse(string stregkode, decimal pris, ETypeOfService typeOfService) 
        {
            Stregkode = stregkode;
            
        }  
    }
}
