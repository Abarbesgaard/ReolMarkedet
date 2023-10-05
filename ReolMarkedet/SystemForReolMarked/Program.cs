using ReolMarkedet.Model;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace ReolMarkedet
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Tilføj();

        }
        
        public static void Tilføj()
        {
            //LejerRepository lejerRepo = new LejerRepository();  
            //Lejer lejer1 = lejerRepo.OpretLejerFraBrugerInput("miav", "hansen", "true", "444", "email", "34");
            //lejerRepo.Tilføj(lejer1);
            //lejerRepo.HentObject(4);

            //ReolRepository reolRepo = new ReolRepository();
            //Reol reol1 = reolRepo.OpretReolFraBrugerInput(34, ETypeAfReol.AlmindeligReol, "aktiv", 200.0m, 3);
            //reolRepo.Tilføj(reol1);
            //reolRepo.HentObject(2);
            //reolRepo.HentObject(3);

            VareRepository vareRepo = new VareRepository();
            Vare vare1 = new Vare("556", "Stol", EVareType.Ting, 50.0m);
            //vareRepo.Tilføj(vare1);

            
            LejerRepository lejerRepo = new LejerRepository();
            Lejer lejer = new Lejer("Nanar", "Nielsen", "email@email", "2288888", "financeinfo", "aktiv");
            Object obj = lejer;

            lejerRepo.Tilføj(obj);
        }



        
    }
}







