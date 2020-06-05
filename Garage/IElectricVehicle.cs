using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        string CurrentChargePercentage { get; set; }

        void ChargeBattery()
        {
            CurrentChargePercentage = "100%";
        }

    }
}