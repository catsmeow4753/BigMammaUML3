using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    class Beverage : MenuItem
    {
        public bool Alcohol { get; set; }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $" | Alcohol: {(Alcohol ? "Yes" : "No")}";
        }

        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            Alcohol = alcohol;
        }
    }
}