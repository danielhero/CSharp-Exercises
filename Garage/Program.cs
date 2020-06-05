using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            /* INHERITANCE */

            Zero fxs = new Zero()
            {
                MainColor = "Red"
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Black"
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "White"
            };

            Ram fifteenHundred = new Ram()
            {
                MainColor = "Blue"
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            fifteenHundred.Drive();
            fifteenHundred.Turn("right");
            fifteenHundred.Stop();

            /***********************************************/

            /* INTERFACE */

            Zero sr = new Zero()
            {
                CurrentChargePercentage = "67%"
            };
            Zero ds = new Zero()
            {
                CurrentChargePercentage = "42%"
            };
            Tesla modelX = new Tesla()
            {
                CurrentChargePercentage = "86%"
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                sr,
                ds,
                modelX
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();

            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram()
            {
                CurrentTankPercentage = "32%"
            };
            Cessna cessna150 = new Cessna()
            {
                CurrentTankPercentage = "50%"
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}