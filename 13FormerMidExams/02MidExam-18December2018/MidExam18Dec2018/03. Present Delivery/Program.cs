using System;
using System.Collections.Generic;
using System.Linq;

namespace _03QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();
            int index = 0;
            int happyHouses = 0;

            string commands = Console.ReadLine();
            while (commands != "Merry Xmas!")
            {
                string[] tokens = commands.Split().ToArray();
                int lengthOfJump = int.Parse(tokens[1]);

                if (index + lengthOfJump <= field.Length - 1)
                {
                    index += lengthOfJump;
                }
                else
                {
                    if ((index + lengthOfJump + 1) % field.Length == 0)
                    {
                        index = field.Length - 1;
                    }
                    else
                    {
                        index = ((index + lengthOfJump + 1) % field.Length) - 1;
                    }
                }
                if (field[index] == 0)
                {
                    Console.WriteLine($"House {index} will have a Merry Christmas.");
                }
                else if (field[index] - 2 == 0)
                {
                    field[index] -= 2;
                    happyHouses++;
                }
                else
                {
                    field[index] -= 2;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {index}.");

            if (happyHouses == field.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {field.Length - happyHouses} houses.");
            }
        }
    }
}