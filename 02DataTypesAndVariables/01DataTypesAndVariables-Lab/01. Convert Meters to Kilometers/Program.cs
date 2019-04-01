using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double distanceInKm = distanceInMeters / 1000d;
            Console.WriteLine($"{distanceInKm:f2}");
        }
    }
}