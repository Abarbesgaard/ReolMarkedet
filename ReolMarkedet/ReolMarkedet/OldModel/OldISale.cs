using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public interface ISale
    {
        DateTime DateTime { get; set; }
        void Sale();
        void Add();
        double CalculateTotalPrice();
    }
}
