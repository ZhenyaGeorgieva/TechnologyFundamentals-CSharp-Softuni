using System;
using System.Collections.Generic;
using System.Linq;

namespace _25EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                int fuel1 = (int)currentName[0];
                double fuel = fuel1;
                for (int y = 0; y < track.Length; y++)
                {
                    if (indexes.Contains(y))
                    {
                        fuel += track[y];
                    }
                    else
                    {
                        fuel -= track[y];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{currentName} - reached {y}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{currentName} - fuel left {fuel:f2}");
                }
            }
        }
    }
}