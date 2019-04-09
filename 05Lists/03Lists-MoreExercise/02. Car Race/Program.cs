using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> timeNeeded = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double timeLeft = FindTiMeLeft(timeNeeded);
            double timeRight = FindTiMeTRigth(timeNeeded);

            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRight}");
            }
        }
        static double FindTiMeLeft(List<double> timeNeeded)
        {
            double totalTimeLeft = 0;
            for (int i = 0; i < timeNeeded.Count / 2; i++)
            {
                if (timeNeeded[i] == 0)
                {
                    totalTimeLeft *= 0.8;
                }
                else
                {
                    totalTimeLeft += timeNeeded[i];
                }
            }
            return totalTimeLeft;
        }
        static double FindTiMeTRigth(List<double> timeNeeded)
        {
            double totalTimeRight = 0;
            for (int i = timeNeeded.Count - 1; i > timeNeeded.Count / 2; i--)
            {
                if (timeNeeded[i] == 0)
                {
                    totalTimeRight *= 0.8;
                }
                else
                {
                    totalTimeRight += timeNeeded[i];
                }
            }
            return totalTimeRight;
        }
    }
}