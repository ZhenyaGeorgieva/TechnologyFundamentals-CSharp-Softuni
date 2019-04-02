using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MagicSum
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

            int numberToCompare = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] + arrayOfNumbers[j] == numberToCompare)
                    {
                        Console.WriteLine($"{arrayOfNumbers[i]} {arrayOfNumbers[j]}");
                    }

                }
            }
        }
    }
}