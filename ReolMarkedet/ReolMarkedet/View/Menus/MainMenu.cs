﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View.Menus
{
    public class MainMenu
    {
        public void DisplayMainMenu()
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
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Opret Reol\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Salg\u001b[0m ");
                Console.WriteLine($"{(option == 3 ? decorator : "   ")}Overblik\u001b[0m ");
                Console.WriteLine($"{(option == 4 ? decorator : "   ")}Admin\u001b[0m ");

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 4 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 4 ? 1 : option + 1;
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
                    SaleMenu saleMenu = new SaleMenu();
                    saleMenu.DisplaySaleMenu();
                    break;
                case 3:
                    Console.Clear();
                    //Overblik 
                    break;

                case 4:
                    Console.Clear();
                    Admin admin = new Admin();
                    admin.DisplayAdminMenu();

                    break;
            }
        }

        
    }
}
