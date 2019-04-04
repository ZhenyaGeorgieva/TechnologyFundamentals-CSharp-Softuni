using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            CountOfNegative(a, b, c);

        }
        static void CountOfNegative(double a, double b, double c)
        {
            int negativeCount = 0;
            if (a < 0)
            {
                negativeCount++;
            }
            if (b < 0)
            {
                negativeCount++;
            }
            if (c < 0)
            {
                negativeCount++;
            }

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCount == 0 || negativeCount == 2)
            {
                Console.WriteLine("positive");
            }
            else if (negativeCount == 1 || negativeCount == 3)
            {
                Console.WriteLine("negative");
            }
        }
    }
}

