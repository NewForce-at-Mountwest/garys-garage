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
            superHugeTruck.MainColor = "Red";
            superHugeTruck.numberOfWheels = 18;

            Tesla fancyCar = new Tesla();
            fancyCar.BatteryKWh = 1;

            Cessna personalJet = new Cessna();
            personalJet.FuelCapacity = 2.5;
            personalJet.Fly();
            personalJet.MainColor = "White";

            Prius myPrius = new Prius();
            myPrius.FuelCapacity = 100000;
            myPrius.ChargeBattery();
            myPrius.MaximumOccupancy = "5";

            // Electric randomElectricCar = new Electric();
            // randomElectricCar.MaximumOccupancy = "2";

            List<IVehicle> garage = new List<IVehicle>();
            garage.Add(myMotorcycle);
            garage.Add(superHugeTruck);
            garage.Add(fancyCar);
            garage.Add(personalJet);
            garage.Add(myPrius);

            // Now let's make individual garages for gas powered and electric vehicles! We shouldn't be able to put a electric vehicle in the gas garage, or vice versa

            List<IElectric> electricVehicles = new List<IElectric>();
            // We can add both of these because both Teslas and Zeros inherit from the Electric class
            electricVehicles.Add(fancyCar);
            electricVehicles.Add(myMotorcycle);
            electricVehicles.Add(myPrius);

            // This next line won't compile! A Ram does not inherit from the Electric class
            // electricVehicles.Add(superHugeTruck);

            List<IGasPowered> gasPoweredVehicles = new List<IGasPowered>();
            gasPoweredVehicles.Add(superHugeTruck);
            gasPoweredVehicles.Add(personalJet);
            gasPoweredVehicles.Add(myPrius);
            // Won't compile! A Tesla isnt' gas powered
            // gasPoweredVehicles.Add(fancyCar);





            ElectricGarage newGarage = new ElectricGarage();
            newGarage.AddToGarage(fancyCar);
            // newGarage.AddToGarage(personalJet); // Won't work!

            personalJet.Drive();
            fancyCar.Drive();

            Console.WriteLine();

        }
    }
}
