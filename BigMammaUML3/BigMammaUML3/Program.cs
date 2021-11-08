using System;

namespace BigMammaUML3
{
    class Program
    {
        static void Main()
        {
            IMenuCatalog iMenuCatalog = new MenuCatalog();

            iMenuCatalog.Add(new Pizza(1, "Pizza", "A pizza", 19.99, MenuType.Pizza, false, true, true));

            iMenuCatalog.PrintPizzasMenu();
        }
    }
}