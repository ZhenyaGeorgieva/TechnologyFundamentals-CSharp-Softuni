using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Sum(a, b);
            int subtractedResult = Subtract(result, c);
            Console.WriteLine(subtractedResult);
        }
        public static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}