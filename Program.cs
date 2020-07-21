using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Zero myMotorcycle = new Zero();
            myMotorcycle.MainColor = "Red";
            myMotorcycle.BatteryKWh = 2.0;
            // myMotorcycle.taco = "Blue"; won't work!

            Ram superHugeTruck = new Ram();
            superHugeTruck.FuelCapacity = 3.4;

            Tesla fancyCar = new Tesla();
            fancyCar.BatteryKWh = 1;

            Cessna personalJet = new Cessna();
            personalJet.FuelCapacity = 2.5;

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(myMotorcycle);
            garage.Add(superHugeTruck);
            garage.Add(fancyCar);
            garage.Add(personalJet);

            // Now let's make individual garages for gas powered and electric vehicles! We shouldn't be able to put a electric vehicle in the gas garage, or vice versa

            List<Electric> electricVehicles = new List<Electric>();
            // We can add both of these because both Teslas and Zeros inherit from the Electric class
            electricVehicles.Add(fancyCar);
            electricVehicles.Add(myMotorcycle);

            // This next line won't compile! A Ram does not inherit from the Electric class
            // electricVehicles.Add(superHugeTruck);

            List<GasPowered> gasPoweredVehicles = new List<GasPowered>();
            gasPoweredVehicles.Add(superHugeTruck);
            gasPoweredVehicles.Add(personalJet);
            // Won't compile! A Tesla isnt' gas powered
            // gasPoweredVehicles.Add(fancyCar);


            personalJet.Drive();
            fancyCar.Drive();

            Console.WriteLine();

        }
    }
}
