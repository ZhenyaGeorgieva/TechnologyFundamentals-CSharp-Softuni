using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequence = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int[] bestDNA = new int[lengthOfSequence];
            int currentSampleNumber = 0;
            int bestStartIndex = int.MaxValue;
            int bestSeq = int.MinValue;
            int bestSum = int.MinValue;
            int bestSampleNumber = int.MinValue;
            while (command != "Clone them!")
            {
                int[] currentDNA = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentSeq = 0;
                int currentBestSeq = int.MinValue;
                int currentSum = 0;
                int startIndexOfSeq = -1;
                currentSampleNumber++;

                for (int i = 0; i < currentDNA.Length - 1; i++)
                {
                    currentSum += currentDNA[i];
                    if (currentDNA[i] == currentDNA[i + 1] && currentDNA[i] == 1)
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 0;
                    }
                    if (currentSeq > currentBestSeq)
                    {
                        currentBestSeq = currentSeq;
                        startIndexOfSeq = i;
                    }
                }
                currentSum += currentDNA[currentDNA.Length - 1];
                if (currentBestSeq > bestSeq)
                {
                    bestSeq = currentBestSeq;
                    bestStartIndex = startIndexOfSeq;
                    bestSum = currentSum;
                    bestDNA = currentDNA;
                    bestSampleNumber = currentSampleNumber;
                }
                else if (currentBestSeq == bestSeq && startIndexOfSeq < bestStartIndex)
                {
                    bestSeq = currentBestSeq;
                    bestStartIndex = startIndexOfSeq;
                    bestSum = currentSum;
                    bestDNA = currentDNA;
                    bestSampleNumber = currentSampleNumber;
                }
                else if (currentBestSeq == bestSeq && startIndexOfSeq == bestStartIndex && currentSum > bestSum)
                {
                    bestSeq = currentSeq;
                    bestStartIndex = startIndexOfSeq;
                    bestSum = currentSum;
                    bestDNA = currentDNA;
                    bestSampleNumber = currentSampleNumber;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}