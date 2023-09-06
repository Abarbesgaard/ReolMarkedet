using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolMarkedet.View.Menus;

namespace ReolMarkedet.CTRL
{
    public class Controller
    {
        MainMenu mainMenu = new MainMenu();
        public void Run()
        {
            mainMenu.DisplayMainMenu();
        }
    }
}
