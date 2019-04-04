using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int area = CalculateArea(sideA, sideB);
            Console.WriteLine(area);
        }
        public static int CalculateArea(int sideA, int sideB)
        {
            return sideA * sideB;
        }
    }
}