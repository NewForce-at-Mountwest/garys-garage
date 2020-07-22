using System;

namespace garys_garage
{
    public class Prius : IVehicle, IGasPowered, IElectric // YAAAAASS
    {

        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public double FuelCapacity { get; set; }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("The battery is charging!");
        }

        public void Drive()
        {
            throw new System.NotImplementedException();
        }

        public void RefuelTank()
        {
            throw new System.NotImplementedException();
        }
    }
}