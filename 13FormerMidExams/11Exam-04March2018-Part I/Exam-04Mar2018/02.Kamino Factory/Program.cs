using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArray = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int bestDNAnumber = int.MaxValue;
            int bestDNAsum = int.MinValue;
            int bestDNASequence = int.MinValue;
            int[] bestDNA = new int[lengthOfArray];
            int smallestStartingIndex = int.MaxValue;
            int currentDNAnumber = 0;
            while (command != "Clone them!")
            {
                int[] currentDNA = command
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentDNASequence = 0;
                int currentDNAsum = 0;
                currentDNAnumber++; ;
                int currentBest = int.MinValue;
                int startingIndex = -1;
                for (int i = 0; i < currentDNA.Length - 1; i++)
                {
                    if (currentDNA[i] == currentDNA[i + 1] && currentDNA[i] == 1)
                    {
                        currentDNASequence++;
                    }
                    else
                    {
                        currentDNASequence = 0;
                    }
                    currentDNAsum += currentDNA[i];

                    if (currentDNASequence > currentBest)
                    {
                        currentBest = currentDNASequence;
                        startingIndex = i;
                    }
                }
                currentDNAsum += currentDNA[lengthOfArray - 1];
                if (currentBest > bestDNASequence)
                {
                    bestDNASequence = currentBest;
                    bestDNAsum = currentDNAsum;
                    bestDNAnumber = currentDNAnumber;
                    smallestStartingIndex = startingIndex;
                    bestDNA = currentDNA;
                }
                else if (currentBest == bestDNASequence
                    && startingIndex < smallestStartingIndex)
                {
                    bestDNASequence = currentBest;
                    bestDNAsum = currentDNAsum;
                    bestDNAnumber = currentDNAnumber;
                    smallestStartingIndex = startingIndex;
                    bestDNA = currentDNA;
                }
                else if (currentBest == bestDNASequence
                    && startingIndex == smallestStartingIndex
                    && currentDNAsum > bestDNAsum)
                {
                    bestDNASequence = currentBest;
                    bestDNAsum = currentDNAsum;
                    bestDNAnumber = currentDNAnumber;
                    smallestStartingIndex = startingIndex;
                    bestDNA = currentDNA;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestDNAnumber} with sum: {bestDNAsum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}