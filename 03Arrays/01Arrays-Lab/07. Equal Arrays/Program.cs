using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] array2 =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int i = 0;

            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    sum += array1[i];

                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (i == array1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }


        }
    }
}
