using System;
using System.Collections.Generic;
using System.Linq;

namespace _06VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> listOfVehicles = new List<Vehicles>();
            int trucksCount = 0;
            int carsCount = 0;
            double totalPowerTrucks = 0;
            double totalPowerCars = 0;

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command
                   .Split()
                   .ToArray();
                string type = tokens[0].First().ToString().ToUpper() + tokens[0].Substring(1);
                string model = tokens[1];
                string colour = tokens[2];
                double horsePower = double.Parse(tokens[3]);

                Vehicles vehicle = new Vehicles();
                vehicle.Type = type;
                vehicle.Model = model;
                vehicle.Colour = colour;
                vehicle.HorsePower = horsePower;

                listOfVehicles.Add(vehicle);
                command = Console.ReadLine();
            }

            string modelCommand = Console.ReadLine();
            while (modelCommand != "Close the Catalogue")
            {
                List<Vehicles> vehiclesToPrint = listOfVehicles
                    .Where(x => x.Model == modelCommand)
                    .Select(x => x)
                    .ToList();

                foreach (var x in vehiclesToPrint)
                {
                    Console.WriteLine($"Type: {x.Type}");
                    Console.WriteLine($"Model: { x.Model}");
                    Console.WriteLine($"Color: { x.Colour}");
                    Console.WriteLine($"Horsepower: {x.HorsePower}");

                }
                modelCommand = Console.ReadLine();
            }
            if (listOfVehicles.Where(x => x.Type == "Car").Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {listOfVehicles.Where(x => x.Type == "Car").Select(x => x.HorsePower).Average():F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (listOfVehicles.Where(x => x.Type == "Truck").Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {listOfVehicles.Where(x => x.Type == "Truck").Select(x => x.HorsePower).Average():F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
    class Vehicles
    {

        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double HorsePower { get; set; }

    }
}