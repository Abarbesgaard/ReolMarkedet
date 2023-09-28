using Reolmarkedet.View;
using ReolMarkedet.Model;
using ReolMarkedet.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReolMarkedet.CTRL
{
    public class Controller
    {
        public void run()
        {
            
            HovedMenu hovedMenu = new HovedMenu();
            hovedMenu.DisplayHovedMenu();
        }
        
    }
}
