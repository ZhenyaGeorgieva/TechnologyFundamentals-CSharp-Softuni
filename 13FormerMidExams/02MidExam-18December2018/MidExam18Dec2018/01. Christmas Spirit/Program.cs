using System;

namespace trialMid
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityPerType = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            double cost = 0;
            int spirit = 0;
            double ornamentPrice = 2;
            double treeSkirtPrice = 5;
            double treeGarlandsPrice = 3;
            double treeLightsPrice = 15;

            for (int i = 1; i <= day; i++)
            {
                if (i % 11 == 0)
                {
                    quantityPerType += 2;
                }
                if (i % 2 == 0)
                {
                    cost += ornamentPrice * quantityPerType;
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    cost += (treeSkirtPrice + treeGarlandsPrice) * quantityPerType;
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    cost += treeLightsPrice * quantityPerType;
                    spirit += 17;
                    if (i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    cost += treeSkirtPrice + treeGarlandsPrice + treeLightsPrice;
                    if (i == day)
                    {
                        spirit -= 30;
                    }
                }
            }
            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
