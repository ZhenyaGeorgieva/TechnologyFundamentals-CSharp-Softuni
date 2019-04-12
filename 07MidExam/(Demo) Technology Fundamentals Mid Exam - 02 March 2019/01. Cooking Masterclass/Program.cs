using System;

namespace trialMid
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double packageFlourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double apronsCount = Math.Ceiling(students * 1.2);
            int freePackagesOfFlour = students / 5;
            double totalPrice = students * packageFlourPrice - freePackagesOfFlour * packageFlourPrice + 10 * students * eggPrice + apronPrice * apronsCount;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalPrice - budget):f2}$ more needed.");
            }
        }
    }
}