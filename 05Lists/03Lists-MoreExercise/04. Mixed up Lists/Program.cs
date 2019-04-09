using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MixedUpLists_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> mixed = new List<int>();

            int minLength = 0;
            List<int> longerArray = new List<int>();
            List<int> shorterArray = new List<int>();

            int limit1 = 0;
            int limit2 = 0;
            if (first.Count > second.Count)
            {
                minLength = second.Count;
                limit1 = first[first.Count - 1];
                limit2 = first[first.Count - 2];
            }
            else
            {
                minLength = first.Count;
                limit1 = second[0];
                limit2 = second[1];
            }
            for (int i = 0; i < minLength; i++)
            {
                mixed.Add(first[i]);
                mixed.Add(second[second.Count - 1 - i]);

            }
            int upperLimit = 0;
            int lowerLimit = 0;
            if (limit1 >= limit2)
            {
                upperLimit = limit1;
                lowerLimit = limit2;
            }
            else
            {
                upperLimit = limit2;
                lowerLimit = limit1;
            }
            List<int> arrayToPrint = new List<int>();
            for (int i = 0; i < mixed.Count; i++)
            {
                if (mixed[i] > lowerLimit && mixed[i] < upperLimit)
                {
                    arrayToPrint.Add(mixed[i]);
                }
            }
            arrayToPrint.Sort();
            Console.WriteLine(string.Join(" ", arrayToPrint));
        }
    }
}