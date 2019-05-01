using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            int brokenKeyboards = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalPrice += headSetPrice;
                }
                if (i % 3 == 0)
                {
                    totalPrice += mousePrice;
                }
                if (i % 6 == 0)
                {
                    totalPrice += keyboardPrice;
                    brokenKeyboards++;
                    if (brokenKeyboards % 2 == 0)
                    {
                        totalPrice += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}