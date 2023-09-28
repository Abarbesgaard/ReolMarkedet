
using ReolMarkedet.CTRL;
using Microsoft.Identity.Client;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ReolMarkedet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            
            controller.run();

           
        }
       
    }
    
}