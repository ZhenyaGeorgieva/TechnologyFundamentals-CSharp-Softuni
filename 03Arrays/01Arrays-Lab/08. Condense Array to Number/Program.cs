using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int initialArrayLength = initialArray.Length;
            if (initialArrayLength > 1)
            {
                int[] condensed = new int[initialArray.Length - 1];
                int lengthOfCondensed = condensed.Length;


                while (lengthOfCondensed > 0)
                {
                    for (int i = 0; i < initialArray.Length - 1; i++)
                    {
                        condensed[i] = initialArray[i] + initialArray[i + 1];
                    }
                    initialArray = condensed;
                    lengthOfCondensed--;
                }
                Console.WriteLine(condensed[0]);

            }
            else
            {
                Console.WriteLine(initialArray[0]);
            }
        }
    }
}
