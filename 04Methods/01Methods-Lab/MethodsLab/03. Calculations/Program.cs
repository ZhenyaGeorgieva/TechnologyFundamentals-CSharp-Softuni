using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(a, b);
            }
            else if (command == "multiply")
            {
                Multiply(a, b);
            }
            else if (command == "subtract")
            {
                Subtract(a, b);
            }
            else if (command == "divide")
            {
                Divide(a, b);
            }
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}