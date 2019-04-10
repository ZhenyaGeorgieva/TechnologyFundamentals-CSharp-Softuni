using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionPerKm = double.Parse(tokens[2]);
                double travelledDistance = 0;

                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKm = fuelConsumptionPerKm;
                car.TravelledDistance = travelledDistance;

                listOfCars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split();
                string model = tokens[1];
                double kilometers = double.Parse(tokens[2]);

                Car carToManipulate = listOfCars.FirstOrDefault(x => x.Model == model);
                carToManipulate.EditCarDetails(carToManipulate, kilometers);
                command = Console.ReadLine();
            }
            foreach (var car in listOfCars)
            {
                Console.Write(car.Model + " ");
                Console.Write($"{ car.FuelAmount:f2} ");
                Console.Write(car.TravelledDistance);
                Console.WriteLine();
            }
        }
    }
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelledDistance { get; set; }

        public void EditCarDetails(Car car, double kilometers)
        {
            if (car.FuelAmount >= car.FuelConsumptionPerKm * kilometers)
            {
                car.TravelledDistance += kilometers;
                car.FuelAmount -= FuelConsumptionPerKm * kilometers;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}