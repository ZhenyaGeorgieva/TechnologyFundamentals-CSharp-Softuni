using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number = number / 10;
                sum += lastDigit;
            }
            Console.WriteLine(sum);
        }
    }
}