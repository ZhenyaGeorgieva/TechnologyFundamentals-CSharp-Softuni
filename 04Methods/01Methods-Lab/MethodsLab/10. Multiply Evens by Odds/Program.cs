using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MultiplyEvenAndOdda
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(Math.Abs(number));
            Console.WriteLine(result);
        }

        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        public static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        public static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
    }
}