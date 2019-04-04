using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int print = FindTheSmallestOfThreeInts(a, b, c);
            Console.WriteLine(print);
        }
        public static int FindTheSmallestOfThreeInts(int number1, int number2, int number3)
        {
            int smallest = 0;
            if (number1 <= number2 && number1 <= number3)
            {
                smallest = number1;
            }
            else if (number2 <= number1 && number2 <= number3)
            {

                smallest = number2;
            }
            else
            {
                smallest = number3;
            }
            return smallest;
        }
    }
}
