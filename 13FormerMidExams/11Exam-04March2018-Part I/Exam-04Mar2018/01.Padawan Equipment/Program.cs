using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceLightSabres = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double quantityLightSabres = Math.Ceiling(1.1 * studentsCount);
            int freeBelts = studentsCount / 6;
            double totalPrice = quantityLightSabres * priceLightSabres + studentsCount * priceRobes + studentsCount * priceBelts - freeBelts * priceBelts;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - budget:f2}lv more.");
            }
        }
    }
}