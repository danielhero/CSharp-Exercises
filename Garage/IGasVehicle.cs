using System;

namespace Garage
{
    public interface IGasVehicle
    {
        string CurrentTankPercentage { get; set; }

        void RefuelTank()
        {
            CurrentTankPercentage = "100%";
        }

    }

}