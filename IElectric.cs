using System;

namespace garys_garage
{
    public interface IElectric
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery();

    }
}