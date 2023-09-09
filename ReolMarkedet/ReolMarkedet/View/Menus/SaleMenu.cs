using Microsoft.VisualBasic.FileIO;
using ReolMarkedet.Model;
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

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Alle Salg\u001b[0m ");
                Console.WriteLine($"{(option == 2 ? decorator : "   ")}Se alle Lejere\u001b[0m ");
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

                    ShowAllSales();

                    break;

                case 2:
                    Console.Clear();
                    SelectDistinctTenant();
                    // Add your submenu logic here.
                    break;

                case 3:
                    Console.Clear();

                    MainMenu mainMenu = new MainMenu();
                    mainMenu.DisplayMainMenu();

                    break;
            }
            
            
        }

        public void ShowAllSales()
        {
            ItemRepository itemRepository = new ItemRepository();
            itemRepository.RetrieveAll();
            foreach (Item item in itemRepository.Items)
            {
                Console.WriteLine($"ID: {item.Id} Lejer: {item.Tenant} Stregkode: {item.Barcode} Navn: {item.Name} Pris: {item.Price} Stand: {item.Place} Type: {item.Type} Rabat: {item.Discount}");
            }
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = ">  \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {

                //Her skal der være en kode der viser en liste over de slag der er blevet foretaget i butikken
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Gå tilbage\u001b[0m ");


                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            switch (option)
            {
                case 1:
                    Console.Clear();
                    //Vis nyeste salg
                    DisplaySaleMenu();
                    // Add your submenu logic here.
                    break;

            }

        }

        public void SelectDistinctTenant()
        {
            ItemRepository itemRepository = new ItemRepository();
            itemRepository.SelectDistinctTenant();

            var uniqueTenants = itemRepository.Items.Select(item => item.Tenant).Distinct();

            foreach (string tenant in uniqueTenants)
            {
                Console.WriteLine($"Lejer: {tenant}");
            }
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = ">  \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;


            while (!isSelected)
            {

                //Her skal der være en kode der viser en liste over de slag der er blevet foretaget i butikken
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? decorator : "   ")}Gå tilbage\u001b[0m ");


                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        isSelected = true;

                        break;
                }
            }
            switch (option)
            {
                case 1:
                    Console.Clear();
                    //Vis nyeste salg
                    DisplaySaleMenu();
                    // Add your submenu logic here.
                    break;

            }
        }
    }
}
