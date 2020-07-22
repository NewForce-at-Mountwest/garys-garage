using System;

namespace garys_garage
{
    public class Cessna : IGasPowered, IVehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void Drive()
        {
            Console.WriteLine("we're drivin!");
        }

        public void Fly(){
            Console.WriteLine("WHEEEEE!");
        }

        public void RefuelTank()
        {
            Console.WriteLine("Refeuling");
        }
    }
}
