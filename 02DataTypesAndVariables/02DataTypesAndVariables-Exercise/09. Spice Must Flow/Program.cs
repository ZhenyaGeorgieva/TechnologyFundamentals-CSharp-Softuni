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

            int startingYield = int.Parse(Console.ReadLine());
            int yield = 0;
            int totalAmount = 0;
            int days = 0;
            while (startingYield >= 100)
            {
                days++;
                yield = startingYield;
                totalAmount += yield;
                if (totalAmount >= 26)
                {
                    totalAmount -= 26;
                }
                else
                {
                    totalAmount -= totalAmount;
                }


                startingYield -= 10;
            }
            Console.WriteLine(days);
            if (totalAmount >= 26)
            {
                Console.WriteLine($"{totalAmount - 26}");
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}