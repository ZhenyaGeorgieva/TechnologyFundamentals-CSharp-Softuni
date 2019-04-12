using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fireCells = Console.ReadLine().Split("#").ToArray();
            int waterAmount = int.Parse(Console.ReadLine());
            List<int> listOfCells = new List<int>();
            double effort = 0;

            for (int i = 0; i < fireCells.Length; i++)
            {
                string[] tokens = fireCells[i].Split(" = ").ToArray();
                string typeOfFire = tokens[0];
                int value = int.Parse(tokens[1]);
                if ((typeOfFire == "High"
                   && value >= 81 && value <= 125)
                   || (typeOfFire == "Medium"
                   && value >= 51 && value <= 80)
                   || (typeOfFire == "Low"
                   && value >= 1 && value <= 50))
                {
                    if (waterAmount >= value)
                    {
                        waterAmount -= value;
                        listOfCells.Add(value);
                        effort += 0.25 * (double)value;
                    }
                }
            }
            Console.WriteLine("Cells:");
            foreach (var x in listOfCells)
            {
                Console.WriteLine($"- {x}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {listOfCells.Sum()}");
        }
    }
}