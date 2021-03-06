using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        public int Count => menuItems.Count;

        public Dictionary<int, IMenuItem> menuItems = new Dictionary<int, IMenuItem>();

        public void Add(IMenuItem aMenuItem)
        {
            if (Search(aMenuItem.Number) == null)
            {
                menuItems.Add(aMenuItem.Number, aMenuItem);
            }
            else
            {
                throw new MenuItemNumberExist("Menu item number exists");
            }
        }

        public IMenuItem Search(int number)
        {
            if (menuItems.ContainsKey(number))
            {
                return menuItems[number];
            }
            else
            {
                return null;
            }
        }

        public void Delete(int number)
        {
            menuItems.Remove(number);
        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem aMenuItem in menuItems.Values)
            {
                if (aMenuItem.Type == MenuType.Pizza)
                {
                    Console.WriteLine(aMenuItem.PrintInfo());
                }
            }
        }

        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem aMenuItem in menuItems.Values)
            {
                if (aMenuItem.Type == MenuType.SoftDrink)
                {
                    Console.WriteLine(aMenuItem.PrintInfo());
                }
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (IMenuItem aMenuItem in menuItems.Values)
            {
                if (aMenuItem.Type == MenuType.Topping)
                {
                    Console.WriteLine(aMenuItem.PrintInfo());
                }
            }
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            IMenuItem aMenuItem = Search(number);
            aMenuItem = theMenuItem;
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> aMenuItemList = new List<IMenuItem>();
            foreach (IMenuItem aMenuItem in menuItems.Values)
            {
                if (aMenuItem.Type == type && aMenuItem.IsVegan)
                {
                    aMenuItemList.Add(aMenuItem);
                }
            }

            return aMenuItemList;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> aMenuItemList = new List<IMenuItem>();
            foreach (IMenuItem aMenuItem in menuItems.Values)
            {
                if (aMenuItem.Type == type && aMenuItem.IsOrganic)
                {
                    aMenuItemList.Add(aMenuItem);
                }
            }

            return aMenuItemList;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem mostExpensiveMenuItem = menuItems[0];
            for (int i = 1; i < menuItems.Count; i++)
            {
                if (menuItems[i].Price > mostExpensiveMenuItem.Price)
                {
                    mostExpensiveMenuItem = menuItems[i];
                }
            }

            return mostExpensiveMenuItem;
        }
    }
}