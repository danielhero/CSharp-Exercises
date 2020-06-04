using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram shakes by you. RRrruuuuumbbble!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The vehicle carefully turns right");
        }
    }

}