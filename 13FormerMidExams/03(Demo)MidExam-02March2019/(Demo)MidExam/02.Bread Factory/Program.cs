using System;
using System.Collections.Generic;
using System.Linq;

namespace _02DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            string[] events = Console.ReadLine().Split("|").ToArray();
            bool bankrupt = false;
            for (int i = 0; i < events.Length; i++)
            {
                string[] tokens = events[i].Split("-").ToArray();
                string action = tokens[0];
                int number = int.Parse(tokens[1]);

                if (action == "rest")
                {
                    int gainedEnergy = 0;
                    if (energy + number > 100)
                    {
                        gainedEnergy = 100 - energy;
                        energy = 100;
                    }
                    else
                    {
                        gainedEnergy = number;
                        energy += number;
                    }
                    Console.WriteLine($"You gained {gainedEnergy} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (action == "order")
                {
                    if (energy - 30 >= 0)
                    {
                        energy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    string ingredient = action;
                    if (coins - number > 0)
                    {
                        coins -= number;
                        Console.WriteLine($"You bought {ingredient}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                        bankrupt = true;
                        break;
                    }
                }
            }
            if (!bankrupt)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}