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
        }
    }
}