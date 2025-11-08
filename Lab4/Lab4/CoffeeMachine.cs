using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public string DeviceName { get { return Name; } }
        public int PowerConsumption { get { return 1000; } }
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }
        public double GetEnergyUsage(int hours)
        {
            if (IsOn)
            {
                return PowerConsumption * hours / 1000.0;
            }
            else
            {
                return 0;
            }
        }
    }
}
