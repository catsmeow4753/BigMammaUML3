using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pasta : MenuItem
    {
        public bool Sauce { get; set; }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $" | Sauce: {(Sauce ? "Yes" : "No")}";
        }

        public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool sauce) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            Sauce = sauce;
        }
    }
}