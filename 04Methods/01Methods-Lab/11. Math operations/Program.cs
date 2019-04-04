using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string operatorSign = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            double result = GetResultFromOperation(numberOne, operatorSign, numberTwo);
            Console.WriteLine($"{result}");
        }
        public static double GetResultFromOperation(int numberOne, string operatorSign, int numberTwo)
        {
            double result = 0;
            switch (operatorSign)
            {
                case "+": result = numberOne + numberTwo; break;
                case "-": result = numberOne - numberTwo; break;
                case "/": result = (double)numberOne / (double)numberTwo; break;
                case "*": result = (double)numberOne * (double)numberTwo; break;
            }
            return result;
        }
    }
}