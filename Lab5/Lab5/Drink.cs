using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Drink : Menu
    {
        public int Volume { get; private set; }
        public bool Alcohol { get; private set; }
        public Drink(string name, decimal price, int volume, bool Alcohol) : base(name, price)
        {
            Volume = volume;
            this.Alcohol = Alcohol;
        }
        public override string GetInfo()
        {
            string alcohol = Alcohol ? "Алкогольний" : "Безалкогольний";
            return $"{Name} ({Volume} мл, {alcohol}) - {Price} грн";
        }
    }
}
