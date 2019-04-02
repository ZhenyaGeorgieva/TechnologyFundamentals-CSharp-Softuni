using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                bool isIntegerBigger = true;

                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] <= arrayOfNumbers[j])
                    {
                        isIntegerBigger = false;
                        break;
                    }
                }
                if (isIntegerBigger)
                {
                    Console.Write(arrayOfNumbers[i] + " ");
                }
            }
        }
    }
}