using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _cityName;

        private string _mayor;

        private int _established;

        private List<Building> _buildingList = new List<Building>();
        public void AddBuilding(Building newBuilding);
        {
            _buildingList.Add(newBuilding)
        }

    }

}