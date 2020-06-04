using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. MMmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle leans to turn {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The vehicle suddenly stops!");
            Console.WriteLine();
        }
    }
}