using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.View
{
    public class Decorator
    {
        public string Decorating()
        {
            var decorator = ">  \u001b[33m";
            return decorator;
        }

        public void banner()
        {
            Console.WriteLine(" ____  ____  __   __    _  _   __   ____  __ _  ____  ____  ____  ____ ");
            Console.WriteLine("(  _ \\(  __)/  \\ (  )  ( \\/ ) / _\\ (  _ \\(  / )(  __)(    \\(  __)(_  _)");         
            Console.WriteLine(" )   / ) _)(  O )/ (_/\\/ \\/ \\/    \\ )   / )  (  ) _)  ) D ( ) _)   )(  ");
            Console.WriteLine("(__\\_)(____)\\__/ \\____/\\_)(_/\\_/\\_/(__\\_)(__\\_)(____)(____/(____) (__)");
            
        }
    }
}
