using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceOne = FindDistanceToCenter(x1, y1);
            double distanceTwo = FindDistanceToCenter(x2, y2);
            CompareDistnace(distanceOne, distanceTwo, x1, y1, x2, y2);
        }

        static double FindDistanceToCenter(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return distance;

        }
        static void CompareDistnace(double distanceOne, double distanceTwo, double x1, double y1, double x2, double y2)
        {
            if (distanceOne > distanceTwo)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (distanceOne < distanceTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (distanceOne == distanceTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
