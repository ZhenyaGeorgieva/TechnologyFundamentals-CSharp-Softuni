using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int borderIndex = array.Length;
            int i = 0;
            bool noSuchNumber = true;

            for (i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int z = i + 1; z < array.Length; z++)
                {
                    rightSum += array[z];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    noSuchNumber = false;
                    break;
                }
            }
            if (noSuchNumber)
            {
                Console.WriteLine("no");
            }

        }
    }
}