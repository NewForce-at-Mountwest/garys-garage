using System;

namespace garys_garage
{
    public interface IGasPowered
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank();

    }
}