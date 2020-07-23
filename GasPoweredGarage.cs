using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class GasPoweredGarage : IGarage<IGasPowered>
    {
        public int NumberOfParkingSpots { get; set; }
        public List<IGasPowered> vehicles { get; set; }

        public void AddToGarage(IGasPowered vehicleToAdd)
        {
            if (vehicles.Count < NumberOfParkingSpots)
            {
                vehicles.Add(vehicleToAdd);
            } else {
                Console.WriteLine("The garage is full!");
            }

        }
    }
}