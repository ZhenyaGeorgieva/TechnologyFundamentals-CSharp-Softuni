using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] formerArray = new int[length];

            for (int i = 1; i <= length; i++)
            {
                int[] array = new int[length];

                for (int j = 0; j < array.Length; j++)
                {
                    array[0] = 1;
                    if (j > 0)
                    {
                        array[j] = formerArray[j] + formerArray[j - 1];
                    }
                }
                for (int z = 0; z < array.Length; z++)
                {
                    if (array[z] != 0)
                    {
                        Console.Write(array[z] + " ");
                    }
                }
                Console.WriteLine();
                formerArray = array;
            }
        }
    }
}
