﻿using Reolmarkedet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View
{
    public class OpretVare
    {
        public void DisplayOpretVareMenu()
        {
            Decorator decorate = new Decorator();
            decorate.banner();
            //Opret vare på reol
            //Hvis reol er udlejet
            //Opret ny vare med alle informationer
            // bekræft er det denne vare du ønsker oprettet?
            // userconfirm
            //ny mulighed for at oprette




            int optionMin = 1;
            int optionMax = 1;
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

               
                Console.WriteLine($"{(option == 2 ? decorate.Decorating() : "   ")}Gå tilbage\u001b[0m ");
                



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
            HovedMenu hovedMenu = new HovedMenu();  
            switch (option)
            {
                case 1:
                    Console.Clear();
                    hovedMenu.DisplayHovedMenu();

                    break;


            }
        }
    }
}
