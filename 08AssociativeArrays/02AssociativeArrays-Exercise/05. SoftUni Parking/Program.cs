using System;
using System.Collections.Generic;
using System.Linq;

namespace _01test
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                List<string> tokens = Console.ReadLine()
                    .Split()
                    .ToList();
                string action = tokens[0];
                string name = tokens[1];

                if (action == "register")
                {
                    string carNumber = tokens[2];

                    if (!parking.ContainsKey(name))
                    {
                        parking[name] = carNumber;
                        Console.WriteLine($"{ name} registered { carNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[name]}");
                    }
                }
                else if (action == "unregister")
                {
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        parking.Remove(name);
                    }
                }
            }
            foreach (var kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}