using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];

                Car car = new Car();
                car.Name = name;
                car.Engine = new Engine();
                car.Engine.EngineSpeed = engineSpeed;
                car.Engine.EnginePower = enginePower;
                car.Cargo = new Cargo();
                car.Cargo.CargoWeight = cargoWeight;
                car.Cargo.CargoType = cargoType;

                listOfCars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "flamable")
            {
                List<Car> listToPrint = listOfCars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
                foreach (var x in listToPrint)
                {
                    Console.WriteLine(x.Name);
                }
            }
            if (command == "fragile")
            {
                List<Car> listToPrint = listOfCars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();
                foreach (var x in listToPrint)
                {
                    Console.WriteLine(x.Name);
                }
            }
        }
    }
    class Car
    {
        public string Name { get; set; }
        public Engine Engine;
        public Cargo Cargo;
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
