using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArrayRotation
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
            int rotationCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < rotationCount; i++)
            {
                int[] rotatedArray = new int[array.Length];
                rotatedArray[rotatedArray.Length - 1] = array[0];
                for (int z = 0; z < rotatedArray.Length - 1; z++)
                {
                    rotatedArray[z] = array[z + 1];
                }

                array = rotatedArray;

            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}