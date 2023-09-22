using ReolMarkedet.Model;
using ReolMarkedet.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReolMarkedet.CTRL
{
    public class Controller
    {
        IObjectInterface nyvare = new VareRepository();
        IObjectInterface reol = new ReolRepository();

        public void EtEllerAndetMedReoler()
        {
            reol.Tilføj(new Reol("123", new ReolBeskrivelse(ETypeAfReol.Gulvplads, 200m, true, 2), new Rabat(1.3m), new Lejer("1", new LejerBeskrivelse("Ingrid", "Snotgård", true, "Jydskebank", "oleHansen@gmail.com", "21762313"))));
            string søgestuff = "123";
            Reol reol1 = (Reol)reol.HentViaStregkode(søgestuff);
            Console.WriteLine("Reolen er blevet udlejet af: " + reol1.Lejer.LejerBeskrivelse.ForNavn + " " + reol1.Lejer.LejerBeskrivelse.EfterNavn + " i " + reol1.ReolBeskrivelse.AntalUdlejetUger.ToString() + " uger");
        }

        public void EtEllerAndetMedVarer()
        {
            nyvare.Tilføj(new Vare("32024379654", new Rabat(1.15m), new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32024379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32874379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32024379654", new Rabat(1.15m), new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32024387654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32784379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvare.Tilføj(new Vare("32024379678", new Rabat(1.15m), new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));




            string søgestuff = "32024379654";
            Vare nyvare1 = (Vare)nyvare.HentViaStregkode(søgestuff);

            Console.WriteLine(nyvare1.Stregkode.ToString());
            
        }
    }
}
