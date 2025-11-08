using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public interface IEnergyConsumer
    {
        string DeviceName { get; }
        int PowerConsumption { get; }
        double GetEnergyUsage(int hours);
    }
}
