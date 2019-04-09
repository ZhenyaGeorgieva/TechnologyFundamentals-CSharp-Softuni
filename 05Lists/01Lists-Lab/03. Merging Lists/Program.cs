using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> resultList = new List<int>();

            int biggerLength = 0;
            int smallerLength = 0;
            List<int> longerList = new List<int>();
            if (firstList.Count >= secondList.Count)
            {
                biggerLength = firstList.Count;
                smallerLength = secondList.Count;
                longerList = firstList;
            }
            else
            {
                biggerLength = secondList.Count;
                smallerLength = firstList.Count;
                longerList = secondList;
            }

            for (int i = 0; i < smallerLength; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }
            for (int i = smallerLength; i < biggerLength; i++)
            {
                resultList.Add(longerList[i]);
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}