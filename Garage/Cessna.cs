using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public string CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = "100%";
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys by you. Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle rolls {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The vehicle hits the runway and stops!");
            Console.WriteLine();
        }
    }

}