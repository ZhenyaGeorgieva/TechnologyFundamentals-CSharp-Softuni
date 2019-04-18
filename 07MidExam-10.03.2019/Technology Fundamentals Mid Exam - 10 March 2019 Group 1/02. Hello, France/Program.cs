using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            double budget = double.Parse(Console.ReadLine());
            double clothesMaxPrice = 50;
            double shoesMaxPrice = 35;
            double accessoriesMaxPrice = 20.5;

            List<double> boughtItemsPrices = new List<double>();

            for (int i = 0; i < items.Count; i++)
            {
                string[] tokens = items[i].Split("->").ToArray();
                string itemType = tokens[0];
                double itemPrice = double.Parse(tokens[1]);

                if (itemType == "Clothes")
                {
                    if (itemPrice <= clothesMaxPrice)
                    {
                        if (budget >= itemPrice)
                        {
                            budget -= itemPrice;
                            boughtItemsPrices.Add(itemPrice);
                        }
                    }
                }
                if (itemType == "Shoes")
                {
                    if (itemPrice <= shoesMaxPrice)
                    {
                        if (budget >= itemPrice)
                        {
                            budget -= itemPrice;
                            boughtItemsPrices.Add(itemPrice);
                        }
                    }
                }
                if (itemType == "Accessories")
                {
                    if (itemPrice <= accessoriesMaxPrice)
                    {
                        if (budget >= itemPrice)
                        {
                            budget -= itemPrice;
                            boughtItemsPrices.Add(itemPrice);
                        }
                    }
                }
            }
            double boughtPricesTotal = boughtItemsPrices.Sum();

            for (int i = 0; i < boughtItemsPrices.Count; i++)
            {
                boughtItemsPrices[i] *= 1.4;
                Console.Write($"{boughtItemsPrices[i]:f2} ");
            }
            Console.WriteLine();
            double afterIncreasePrices = boughtItemsPrices.Sum();
            double profit = afterIncreasePrices - boughtPricesTotal;
            Console.WriteLine($"Profit: {profit:f2}");

            double sumAfterSelling = boughtItemsPrices.Sum();
            double totalAvailableBudget = sumAfterSelling + budget;
            if (totalAvailableBudget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}