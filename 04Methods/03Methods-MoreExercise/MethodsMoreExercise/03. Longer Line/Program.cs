using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double firstLineLength = FindDistanceBetweenPoints(x1, y1, x2, y2);

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double secondLineLength = FindDistanceBetweenPoints(x3, y3, x4, y4);

            if (secondLineLength > firstLineLength)
            {
                double firstPointDistanceToCenter = FindDistanceBetweenPoints(x3, y3, 0, 0);
                double secondPointDistnaceToCenter = FindDistanceBetweenPoints(x4, y4, 0, 0);
                if (firstPointDistanceToCenter <= secondPointDistnaceToCenter)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            else
            {
                double firstPointDistanceToCenter = FindDistanceBetweenPoints(x1, y1, 0, 0);
                double secondPointDistnaceToCenter = FindDistanceBetweenPoints(x2, y2, 0, 0);
                if (firstPointDistanceToCenter <= secondPointDistnaceToCenter)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        }
        static double FindDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            return distance;
        }
    }
}