using System;

namespace Planner
{
    public class Building
    {

        private string _designer = "Daniel Hero";

        private DateTime _dateconstructed;

        private string _address;

        private string _owner;
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }
        public void Construct()
        {
            _dateconstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void BuildingInfo()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Constructed on {_dateconstructed}");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Owned by {_owner}");
        }
    }

}