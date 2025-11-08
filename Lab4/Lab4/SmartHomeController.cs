using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class SmartHomeController
    {
        public List<ISwitchable> allDevices = new List<ISwitchable>();
        public List<IEnergyConsumer> consumeDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            allDevices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            consumeDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in allDevices)
                device.TurnOn();
        }

        public void TurnAllOff()
        {
            foreach (var device in allDevices)
                device.TurnOff();
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");

            double consumeTotal = 0;

            foreach (var device in consumeDevices)
            {
                double consumeHours = device.GetEnergyUsage(hours);
                consumeTotal += consumeHours;

                Console.WriteLine($"{device.DeviceName}: {consumeHours:F2} кВт·год (потужність: {device.PowerConsumption} Вт).");
            }

            Console.WriteLine($"Загальне споживання: {consumeTotal:F2} кВт·год.");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {consumeTotal * 4:F2} грн.\n");
        }
    }
}
