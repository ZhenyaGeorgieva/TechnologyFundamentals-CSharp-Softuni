using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zigZagOne = new int[n];
            int[] zigZagTwo = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] array =
                    Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    zigZagOne[i] = array[0];
                    zigZagTwo[i] = array[1];
                }
                else
                {
                    zigZagOne[i] = array[1];
                    zigZagTwo[i] = array[0];
                }
            }
            Console.WriteLine(string.Join(" ", zigZagOne));
            Console.WriteLine(string.Join(" ", zigZagTwo));
        }
    }
}
