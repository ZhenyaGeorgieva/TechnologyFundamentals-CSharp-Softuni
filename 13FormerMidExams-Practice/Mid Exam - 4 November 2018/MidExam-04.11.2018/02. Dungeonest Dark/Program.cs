using System;
using System.Linq;

namespace _02DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                   .Split("|")
                   .ToArray();

            int health = 100;
            int coins = 0;
            bool died = false;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split().ToArray();
                string command = tokens[0];
                int points = int.Parse(tokens[1]);
                int healedPoints = 0;
                if (command == "potion")
                {
                    if (health + points > 100)
                    {
                        healedPoints = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        healedPoints = points;
                        health += healedPoints;
                    }
                    Console.WriteLine($"You healed for {healedPoints} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    coins += points;
                    Console.WriteLine($"You found {points} coins.");
                }
                else
                {
                    if (health - points > 0)
                    {
                        health -= points;
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        died = true;
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }
            if (!died)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
