using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public interface IObjectInterface
    {

       public void Tilføj(Object obj);

        public List<Object> HentAlle(string idEllerStregkode);

        public void Update(Object obj);

        public void Slet(Object obj);

    }

}


    