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
            LejerRepository lejerRepo = new LejerRepository();  
            Lejer lejer1 = lejerRepo.OpretLejerFraBrugerInput("mææ", "hansen", "true", "444", "email", "34");
            lejerRepo.Tilføj(lejer1);
            lejerRepo.HentObject(4);
            

        }


    }
}







