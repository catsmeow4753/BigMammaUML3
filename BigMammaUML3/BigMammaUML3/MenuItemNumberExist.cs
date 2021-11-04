using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist()
        {
            Console.WriteLine("Menu item number exist");
        }
    }
}