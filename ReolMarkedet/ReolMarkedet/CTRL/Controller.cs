using Reolmarkedet.View;
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
        public void run()
        {
            
            HovedMenu hovedMenu = new HovedMenu();
            hovedMenu.DisplayHovedMenu();
        }
        IObjectInterface salg = new SalgRepository();

        public IObjectInterface nyvarerepo = new VareRepository();

        public void TilføjMangeReoler()
        {
            IObjectInterface reol = ReolRepository.GetInstance();
            reol.Tilføj(new Reol("1", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null)); 
            reol.Tilføj(new Reol("2", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("3", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("4", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("5", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("6", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("7", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("8", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("9", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));
            reol.Tilføj(new Reol("10", new ReolBeskrivelse(ETypeAfReol.Almindelig_Skab, 100m, false, 0), null, null));

        }

        public void LavKvitering()
        {
            nyvarerepo.Tilføj(new Vare("32024379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvarerepo.Tilføj(new Vare("32874379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvarerepo.Tilføj(new Vare("32024379654", new Rabat(0.15m), new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvarerepo.Tilføj(new Vare("32024387654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvarerepo.Tilføj(new Vare("32784379654", null, new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));
            nyvarerepo.Tilføj(new Vare("32024379678", new Rabat(0.15m), new VareBeskrivelse("Bamse", EVareType.ting, 30.95m)));


            Console.WriteLine("REOLMARKEDET");
            Console.WriteLine("Addresse Information");

            Console.WriteLine("\nbetjent af: Medarbejder ID");

            Console.WriteLine("Handlen udført: " + DateTime.Now);
            nyvarerepo.List();
            

            //foreach (Vare vare in nyvarerepo)
            //{
            //    Console.WriteLine($"{nyvarerepo.VareBeskrivelse.Name} {nyvarerepo.VareBeskrivelse.Pris.ToString()}");
            //}

            //Console.WriteLine(nyvare.VareBeskrivelse.Name + " " + nyvare.VareBeskrivelse.Pris






        }

        //Opret hylde
    }
}
