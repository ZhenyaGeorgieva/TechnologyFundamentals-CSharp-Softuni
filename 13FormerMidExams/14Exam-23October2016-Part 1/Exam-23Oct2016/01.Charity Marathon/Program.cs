using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double runnersCount = double.Parse(Console.ReadLine());
            double averageLapsPerRunner = double.Parse(Console.ReadLine());
            double lengthTrack = double.Parse(Console.ReadLine());
            double capacityOfTrack = double.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());
            double totalCapacity = capacityOfTrack * days;
            if (runnersCount > totalCapacity)
            {
                runnersCount = totalCapacity;
            }
            double metersTotal = runnersCount * averageLapsPerRunner * lengthTrack;
            double kmTotal = metersTotal / 1000.0;
            double totalMoney = kmTotal * moneyPerKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}