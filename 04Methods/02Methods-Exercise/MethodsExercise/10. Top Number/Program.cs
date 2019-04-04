using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimitNumber = int.Parse(Console.ReadLine());
            FindTopNumber(upperLimitNumber);
        }
        public static void FindTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sumOfDigits = 0;
                int counterOfOddDigits = 0;
                int numberToCheck = i;
                while (numberToCheck > 0)
                {
                    int lastDigit = numberToCheck % 10;
                    numberToCheck /= 10;
                    sumOfDigits += lastDigit;
                    if (lastDigit % 2 != 0)
                    {
                        counterOfOddDigits += 1;
                    }
                }
                if (sumOfDigits % 8 == 0 && counterOfOddDigits >= 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
