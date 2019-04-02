using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sumEven += arrayOfNumbers[i];
                }
                else
                {
                    sumOdd += arrayOfNumbers[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
