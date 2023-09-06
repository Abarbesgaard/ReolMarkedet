using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View.Menus
{
    public class SaleMenu
    {
        public void DisplaySaleMenu()
        {
            Banner banner = new Banner();
            banner.DisplayBanner();


            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = ">  \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {

                //Her skal der være en kode der viser en liste over de slag der er blevet foretaget i butikken
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Sorter efter nyeste salg\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Sorter efter specifik reol\u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorator : "   ")}Gå tilbage\u001b[0m ");

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 3 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 3 ? 1 : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            switch (option)
            {
                case 1:
                    Console.Clear();
                    OpretReol opretReol = new OpretReol();
                    opretReol.DisplayOpretReol();
                    // Add your submenu logic here.
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Submenu for Option 2");
                    // Add your submenu logic here.
                    break;

                case 3:
                    Console.Clear();

                    MainMenu mainMenu = new MainMenu();
                    mainMenu.DisplayMainMenu();

                    break;
            }
        }
    }
}
