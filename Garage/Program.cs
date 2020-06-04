using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
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
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            fifteenHundred.Drive();
            fifteenHundred.Turn();
            fifteenHundred.Stop();

        }
    }
}