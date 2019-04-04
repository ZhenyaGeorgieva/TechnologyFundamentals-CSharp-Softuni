using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePriceOrder(product, quantity);
        }
        public static void CalculatePriceOrder(string product, int quantity)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.5;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else if (product == "snacks")
            {
                price = 2;
            }
            double total = price * quantity;
            Console.WriteLine($"{total:f2}");
        }
    }
}
