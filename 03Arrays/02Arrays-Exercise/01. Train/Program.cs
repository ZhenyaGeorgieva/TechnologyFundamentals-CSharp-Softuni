using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] train = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}