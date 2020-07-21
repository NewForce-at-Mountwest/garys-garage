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

            personalJet.Drive();
            fancyCar.Drive();

            Console.WriteLine();

        }
    }
}
