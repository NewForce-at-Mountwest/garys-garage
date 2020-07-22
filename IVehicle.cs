using System;

namespace garys_garage
{
    public interface IVehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void Drive();
    }
}