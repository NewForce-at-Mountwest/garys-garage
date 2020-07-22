using System;

namespace garys_garage
{
    public class Zero : IElectric, IVehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging");
        }

        public void doSpecificMotorcycleStuff(){
            Console.WriteLine("I am absolutely a motorcylce");
        }

        public void Drive()
        {
            Console.WriteLine("zoom");
        }
    }
}