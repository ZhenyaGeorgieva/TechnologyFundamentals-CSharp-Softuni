using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> initialQuality = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> currentQuality = initialQuality.ToList();

            string line = Console.ReadLine();
            while (line != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(line);
                for (int i = 0; i < currentQuality.Count; i++)
                {
                    currentQuality[i] -= hitPower;
                    if (currentQuality[i] <= 0)
                    {
                        double price = initialQuality[i] * 3;
                        if (price <= budget && budget > 0)
                        {
                            budget -= price;
                            currentQuality[i] = initialQuality[i];
                        }
                        else
                        {
                            currentQuality.Remove(currentQuality[i]);
                            initialQuality.Remove(initialQuality[i]);
                            i = i - 1;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", currentQuality));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
