using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public string CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = "100%";
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram shakes by you. RRrruuuuumbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
    }

}