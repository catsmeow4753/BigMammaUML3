using System;

namespace BigMammaUML3
{
    class Program
    {
        static void Main()
        {
            IMenuCatalog iMenuCatalog = new MenuCatalog();

            try
            {
                iMenuCatalog.Add(new Pizza(1, "Pizza", "A pizza", 19.99, MenuType.Pizza, false, true, true));
                iMenuCatalog.Add(new Pizza(1, "Pizza 2", "A pizza 2", 9.99, MenuType.Pizza, false, true, true));
                iMenuCatalog.Add(new Pizza(2, "name", "description", 20, MenuType.Pizza, false, false, false));
            }
            catch (MenuItemNumberExist mex)
            {
                Console.WriteLine(mex.Message);
            }
            
            iMenuCatalog.PrintPizzasMenu();

            Console.ReadLine();
        }
    }
}