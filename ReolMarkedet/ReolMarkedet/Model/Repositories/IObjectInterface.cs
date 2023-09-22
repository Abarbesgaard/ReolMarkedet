using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model.Repositories
{
    public interface IObjectInterface
    {
        void Tilføj(Object obj);
        void Fjern(Object obj);
        void Opdater(Object obj);
        void Slet(Object obj);

        Object HentViaStregkode(Object obj);

    }
}
