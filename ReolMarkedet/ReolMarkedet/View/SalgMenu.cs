using Reolmarkedet.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View
{
    public class SalgMenu
    {
        // Ikke implementerert ordenlig
        public void DisplaySalgMenu()
        {
            Decorator decorate = new Decorator();
            decorate.banner();
            Console.WriteLine("Scan Vare: ");

            (int left, int top) = Console.GetCursorPosition();
            var option = 1;

            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Start Salg\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Gå tilbage\u001b[0m ");


                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 2 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 2 ? 1 : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            SalgMenu salgMenu = new SalgMenu();
            
            HovedMenu hovedMenu = new HovedMenu();
            switch (option)
            {
                case 1:
                    Console.Clear();
                    salgMenu.DisplaySalgMenu();

                    break;

                case 2:
                    Console.Clear();
                    hovedMenu.DisplayHovedMenu();

                    break;


            }
        }
    }
}
