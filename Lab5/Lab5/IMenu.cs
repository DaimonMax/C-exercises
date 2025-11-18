using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IMenu
    {
        string Name { get; }
        decimal Price { get; }
        string GetInfo();
    }
}
