using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 =
                Console.ReadLine()
                .Split()
                .ToArray();

            string[] array2 =
                Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write(array2[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}