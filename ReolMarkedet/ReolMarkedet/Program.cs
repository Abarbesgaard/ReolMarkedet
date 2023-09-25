
using ReolMarkedet.CTRL;
using Microsoft.Identity.Client;

namespace ReolMarkedet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            //controller.EtEllerAndetMedVarer();
            controller.TilføjMangeReoler();
            controller.run();

           
        }       
    }
}