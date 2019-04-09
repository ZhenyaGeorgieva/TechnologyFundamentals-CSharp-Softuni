using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GaussTrick
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

            int countOfList = listOfNumbers.Count;

            for (int i = 0; i < countOfList / 2; i++)
            {
                listOfNumbers[i] = listOfNumbers[i] + listOfNumbers[listOfNumbers.Count - 1];
                listOfNumbers.Remove(listOfNumbers[listOfNumbers.Count - 1]);
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
