using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View.Menus
{
    public class Banner
    {
        public void DisplayBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  _____            _                      _            _ ");
            Console.WriteLine(" |  __ \\          | |                    | |          | |");
            Console.WriteLine(" | |__) |___  ___ | |_ __ ___   __ _ _ __| | _____  __| |");
            Console.WriteLine(" |  _  // _ \\/ _ \\| | '_ ` _ \\ / _` | '__| |/ / _ \\/ _` |");
            Console.WriteLine(" | | \\ \\  __/ (_) | | | | | | | (_| | |  |   <  __/ (_| |");
            Console.WriteLine(" |_|  \\_\\___|\\___/|_|_| |_| |_|\\__,_|_|  |_|\\_\\___|\\__,_|");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Benyt dig af OP og NED til at navigere i menuen og tryk ss \u001b[32mEnter/Return\u001b[0m for at bekræfte dit valg");
        }
    }
}
