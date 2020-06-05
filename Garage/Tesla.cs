using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public string CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = "100%";
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. RRroooooomm!");
        }
    }

}