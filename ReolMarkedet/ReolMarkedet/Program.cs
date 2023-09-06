using ReolMarkedet.Model;
using ReolMarkedet.Model.Enum;
using ReolMarkedet.CTRL;

namespace ReolMarkedet
{
    public class Program
    {
        static void Main(string[] args)
        {

            Controller controller = new Controller();

            controller.Run();
            Console.ReadLine();
        }
    }
}