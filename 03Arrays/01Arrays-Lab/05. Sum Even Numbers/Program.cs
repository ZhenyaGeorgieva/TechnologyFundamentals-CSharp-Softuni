using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SumOfEvenNumbers
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
            int sum = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sum += arrayOfNumbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}