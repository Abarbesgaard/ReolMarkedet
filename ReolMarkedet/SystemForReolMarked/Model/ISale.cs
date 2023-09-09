using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public interface ISale
    {
        DateTime dateTime { get; set; }

        void Sale();
        decimal CalculateTotalPrice();
    }
}
