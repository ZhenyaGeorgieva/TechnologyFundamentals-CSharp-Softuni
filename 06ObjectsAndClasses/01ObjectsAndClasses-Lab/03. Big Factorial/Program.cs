using System;
using System.Numerics;

namespace _03BigFactoriel_my
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger resultFactoriel = 1;
            for (int i = 2; i <= number; i++)
            {
                resultFactoriel *= i;
            }
            Console.WriteLine(resultFactoriel);
        }
    }
}