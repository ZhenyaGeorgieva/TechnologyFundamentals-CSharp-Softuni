using System;
using System.Linq;
using System.Numerics;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                string command = Console.ReadLine();
                BigInteger[] numbers = command
                    .Split()
                    .Select(BigInteger.Parse)
                    .ToArray();

                BigInteger number = 0;
                BigInteger digit = 0;
                BigInteger sum = 0;
                if (numbers[0] >= numbers[1])
                {
                    number = BigInteger.Abs(numbers[0]);
                }
                else
                {
                    number = BigInteger.Abs(numbers[1]);
                }
                while (BigInteger.Abs(number) > 0)
                {
                    digit = number % 10;
                    number /= 10;
                    sum += digit;
                }
                Console.WriteLine(sum);
            }
        }
    }
}