using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long result1 = FindFactoriel(a);
            long result2 = FindFactoriel(b);
            double finalToPrint = DivisionOfTwoFactoriels(result1, result2);
            Console.WriteLine($"{finalToPrint:f2}");
        }
        public static long FindFactoriel(int number)
        {
            long result = 1;

            if (number > 1)
            {

                for (int i = number; i >= 1; i--)
                {

                    result *= i;
                }
            }

            return result;
        }
        public static double DivisionOfTwoFactoriels(long firstFactoriel, long secondFactoriel)
        {
            double result = (double)firstFactoriel / (double)secondFactoriel;
            return result;
        }
    }
}