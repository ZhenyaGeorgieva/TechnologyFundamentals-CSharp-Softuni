using System;
using System.Collections.Generic;
using System.Linq;

namespace _03QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int bestQuality = int.MinValue;
            double bestAverage = double.MinValue;
            int bestLength = int.MaxValue;
            List<int> bestBatch = new List<int>();
            while (command != "Bake It!")
            {
                List<int> batch = command.Split("#").Select(int.Parse).ToList();
                int currentQuality = batch.Sum();
                double currentAvetage = batch.Average();
                int currentLength = batch.Count;

                if (currentQuality > bestQuality)
                {
                    bestQuality = currentQuality;
                    bestAverage = currentAvetage;
                    bestLength = currentLength;
                    bestBatch = batch;
                }
                else if (currentQuality == bestQuality && currentAvetage > bestAverage)
                {
                    bestQuality = currentQuality;
                    bestAverage = currentAvetage;
                    bestLength = currentLength;
                    bestBatch = batch;
                }
                else if (currentQuality == bestQuality && currentAvetage == bestAverage && currentLength < bestLength)
                {
                    bestQuality = currentQuality;
                    bestAverage = currentAvetage;
                    bestLength = currentLength;
                    bestBatch = batch;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
