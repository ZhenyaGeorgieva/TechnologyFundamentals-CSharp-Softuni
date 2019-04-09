using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOfNumbers =
                 Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToList();

            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                if (listOfNumbers[i] == listOfNumbers[i + 1])
                {
                    listOfNumbers[i] += listOfNumbers[i + 1];
                    listOfNumbers.Remove(listOfNumbers[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}