using System;

namespace _01Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homes = int.Parse(Console.ReadLine());
            int presentsCount = int.Parse(Console.ReadLine());
            int initialPresents = presentsCount;
            int visitedHomes = 0;
            int additionalPresentsTaken = 0;
            int timesBack = 0;
            int totalAdditional = 0;
            for (int i = 0; i < homes; i++)
            {
                int presentsNeeded = int.Parse(Console.ReadLine());
                visitedHomes++;
                if (presentsCount >= presentsNeeded)
                {
                    presentsCount -= presentsNeeded;
                }
                else
                {
                    timesBack++;
                    additionalPresentsTaken = (initialPresents / visitedHomes) * (homes - visitedHomes) + (presentsNeeded - presentsCount);
                    totalAdditional += additionalPresentsTaken;
                    presentsCount += additionalPresentsTaken;
                    presentsCount -= presentsNeeded;
                }
            }
            if (timesBack == 0)
            {
                Console.WriteLine($"{presentsCount}");
            }
            else
            {
                Console.WriteLine($"{timesBack}");
                Console.WriteLine($"{totalAdditional}");
            }
        }
    }
}