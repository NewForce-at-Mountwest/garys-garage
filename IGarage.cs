using System;
using System.Collections.Generic;

namespace garys_garage
{
    public interface IGarage<T>
    {
        public int NumberOfParkingSpots {get; set;}

        public List<T> vehicles {get; set;}

        public void AddToGarage(T vehicleToAdd);

    }
}