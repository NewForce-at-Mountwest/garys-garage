using System;
using System.Collections.Generic;

namespace garys_garage {

    public class ElectricGarage : IGarage<IElectric>
    {
        public int NumberOfParkingSpots { get; set; }
        public List<IElectric> vehicles { get; set; }

        public void AddToGarage(IElectric vehicleToAdd)
        {
            vehicles.Add(vehicleToAdd);
        }
    }
}