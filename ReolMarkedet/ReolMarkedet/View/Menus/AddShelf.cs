using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View.Menus
{
    public class AddShelf
    {
        Banner banner = new Banner();

        public void DisplayAddShelfMenu()
        {
            banner.DisplayBanner();

            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = ">  \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            Console.WriteLine("\nVælg en reol");

            while (!isSelected)
            {
                //Her skal der være et loop der viser all ledige reoler og gøre det muligt at vælge én
                //Derefter skrive et navn på og dermed er lejer tilknyttet en 
                
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Admin Stuff (WIP)\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Gå tilbage\u001b[0m ");


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
            switch (option)
            {
                case 1:
                    //Console.Clear();
                    // Ny vindue

                    break;

                case 2:
                    Console.Clear();

                    MainMenu mainMenu = new MainMenu();
                    mainMenu.DisplayMainMenu();

                    break;

            }
        }
    }
}
