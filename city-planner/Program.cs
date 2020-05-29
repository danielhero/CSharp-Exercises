using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Shea = new Building("100 Tom Seaver Way")
            {
                Stories = 10,
                Width = 1000.4,
                Depth = 1000.5,
            };
            Shea.Construct();
            Shea.Purchase("Fred Wilpon");

            Shea.BuildingInfo();
            Console.WriteLine($"{Shea.Volume} cubic meters of space");
            Console.WriteLine();

            Building QueensTower = new Building("321 Queens Boulevard")
            {
                Stories = 12,
                Width = 800.34,
                Depth = 1200.62,
            };
            QueensTower.Construct();
            QueensTower.Purchase("Melinda Katz");

            QueensTower.BuildingInfo();
            Console.WriteLine($"{QueensTower.Volume} cubic meters of space");
            Console.WriteLine();

            Building HillsHeights = new Building("32-61 Fleet Avenue")
            {
                Stories = 15,
                Width = 600.73,
                Depth = 1100.58,
            };
            HillsHeights.Construct();
            HillsHeights.Purchase("Jessica Hoopes");

            HillsHeights.BuildingInfo();
            Console.WriteLine($"{HillsHeights.Volume} cubic meters of space");
            Console.WriteLine();
        }

    }
}