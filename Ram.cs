using System;

namespace garys_garage
{
    public class Ram : IGasPowered, IVehicle
    {  // Gas powered truck

        public int numberOfWheels {get; set;}
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void Drive()
        {
            Console.WriteLine("Wheee");
        }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling!");
        }
    }
}
