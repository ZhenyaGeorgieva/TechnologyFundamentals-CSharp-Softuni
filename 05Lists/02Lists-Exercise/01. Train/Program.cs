using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacityOfwagon = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            while (line != "end")
            {
                List<string> directions = line.
                    Split()
                    .ToList();
                if (directions[0] == "Add")
                {
                    int wagonToAdd = int.Parse(directions[1]);
                    wagons.Add(wagonToAdd);
                }
                else
                {
                    int passangersToFit = int.Parse(directions[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangersToFit <= capacityOfwagon)
                        {
                            wagons[i] += passangersToFit;
                            break; ;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}