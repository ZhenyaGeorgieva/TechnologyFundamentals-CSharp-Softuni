using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arrayToPrint = FindTribonacciSequence(num);
            Console.WriteLine(string.Join(" ", arrayToPrint));
        }
        static int[] FindTribonacciSequence(int num)
        {
            int[] array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = 1;
                }
                else if (i == 1)
                {
                    array[i] = 1;
                }
                else if (i == 2)
                {
                    array[i] = 2;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }
            return array;
        }
    }
}