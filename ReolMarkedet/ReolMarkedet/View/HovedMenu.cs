using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolMarkedet.View;


namespace Reolmarkedet.View
{
    public class HovedMenu
    {
        public void DisplayHovedMenu()
        {
            Decorator decorate = new Decorator();
            decorate.banner();

            Console.WriteLine("\nMedarbjeder: RM001");
            Console.WriteLine();




            int optionMin = 1; 
            int optionMax = 3;
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorate.Decorating() : "   ")}Start Salg\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Opret Reol\u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorate.Decorating() : "   ")}Opret Vare\u001b[0m ");



                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == optionMin ? optionMax : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == optionMax ? optionMin : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            SalgMenu salgMenu = new SalgMenu();
            OpretReol opretReol = new OpretReol();
            OpretVare opretVare = new OpretVare();
            switch (option)
            {
                case 1:
                    Console.Clear();
                    salgMenu.DisplaySalgMenu();

                    break;

                case 2:
                    Console.Clear();
                    opretReol.DisplayOpretReolMenu();

                    break;
                case 3:
                    Console.Clear();
                    opretVare.DisplayOpretVareMenu();
                    break;


            }
        }

    }
}


