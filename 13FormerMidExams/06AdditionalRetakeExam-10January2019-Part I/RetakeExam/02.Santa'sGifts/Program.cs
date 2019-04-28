using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Santa_sGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<int> housesList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int currentIndex = 0;
            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Forward")
                {
                    int stepsAhead = int.Parse(command[1]);
                    if (currentIndex + stepsAhead < housesList.Count)
                    {
                        currentIndex += stepsAhead;
                        housesList.RemoveAt(currentIndex);
                    }
                }
                else if (command[0] == "Back")
                {
                    int stepsBack = int.Parse(command[1]);
                    if (currentIndex - stepsBack >= 0)
                    {
                        currentIndex -= stepsBack;
                        housesList.RemoveAt(currentIndex);
                    }
                }
                else if (command[0] == "Gift")
                {
                    int indexToInsertAt = int.Parse(command[1]);
                    int elementToInsert = int.Parse(command[2]);
                    if (indexToInsertAt >= 0 && indexToInsertAt < housesList.Count)
                    {
                        housesList.Insert(indexToInsertAt, elementToInsert);
                        currentIndex = indexToInsertAt;
                    }
                }
                else if (command[0] == "Swap")
                {
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);
                    if (housesList.Contains(first) && housesList.Contains(second))
                    {
                        int firstIndex = housesList.IndexOf(first);
                        int secondIndex = housesList.IndexOf(second);
                        housesList.RemoveAt(firstIndex);
                        housesList.Insert(firstIndex, second);
                        housesList.RemoveAt(secondIndex);
                        housesList.Insert(secondIndex, first);
                    }
                }
            }
            Console.WriteLine($"Position: {currentIndex}");
            Console.WriteLine(string.Join(", ", housesList));
        }
    }
}