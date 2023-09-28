using Reolmarkedet.View;
using ReolMarkedet.Model;
using ReolMarkedet.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View
{
    public class OpretReol
    {
        IObjectInterface _reoler = ReolRepository.GetInstance();
        IObjectInterface _lejer = new LejerRepository();
        

        public void DisplayOpretReolMenu()
        {
            Decorator decorate = new Decorator();
            decorate.banner();

            Console.WriteLine("Opret Reol ");
            Console.WriteLine("hvilken reol vil du leje? ");
            _reoler.List();
            
            Console.WriteLine("Indtast nummer på reol");

            string userInput = Console.ReadLine();
            
            Console.WriteLine("Fornavn på lejer:");
            string Firstname = Console.ReadLine();
            
            Console.WriteLine("Efternavn på lejer:");
            string Lastname = Console.ReadLine();
           
            Console.WriteLine("Lejers Mail:");
            string Email = Console.ReadLine();
            
            Console.WriteLine("Lejers Telefon Nummer:");
            string Phone = Console.ReadLine();
            
            _lejer.Tilføj(new Lejer("1", new LejerBeskrivelse(Lastname, Firstname, true, "2123435", Email, Phone)));
            
            _reoler.Opdater(_lejer.RetunerSeneste(), userInput);
            Console.ReadLine();

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
