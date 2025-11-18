using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Menu : IMenu
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public Menu(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetInfo();
    }
}
