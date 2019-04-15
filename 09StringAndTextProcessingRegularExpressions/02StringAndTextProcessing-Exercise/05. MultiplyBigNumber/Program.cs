using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int digitForNextCalc = 0;
            int multiplier = int.Parse(Console.ReadLine());
            List<int> resultNumber = new List<int>();
            if (multiplier == 0 || number == "0")
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int lastDigitString = int.Parse(number[i].ToString());
                int result = multiplier * lastDigitString + digitForNextCalc;

                int lastDigitResult = (result % 10);
                digitForNextCalc = result / 10;
                resultNumber.Add(lastDigitResult);
                if (digitForNextCalc != 0 && i == 0)
                {
                    resultNumber.Add(digitForNextCalc);
                }
            }
            resultNumber.Reverse();
            Console.WriteLine(string.Join("", resultNumber));
        }
    }
}