using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            for (int numberToCheck = 2; numberToCheck <= upperLimit; numberToCheck++)
            {
                string isNumberPrime = "true";
                for (int divider = 2; divider < numberToCheck; divider++)
                {
                    if (numberToCheck % divider == 0)
                    {
                        isNumberPrime = "false";
                        break;
                    }
                }
                Console.WriteLine($"{numberToCheck} -> {isNumberPrime}");
            }
        }
    }
}