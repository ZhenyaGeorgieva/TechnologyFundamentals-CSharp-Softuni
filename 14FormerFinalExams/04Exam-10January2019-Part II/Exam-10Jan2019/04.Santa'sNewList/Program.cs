using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> toysCount = new Dictionary<string, int>();
            Dictionary<string, int> childrenTotal = new Dictionary<string, int>();

            while (command != "END")
            {
                string[] tokens = command.Split("->");
                if (tokens[0] != "Remove")
                {
                    string name = tokens[0];
                    string toy = tokens[1];
                    int amount = int.Parse(tokens[2]);
                    if (!toysCount.ContainsKey(toy))
                    {
                        toysCount[toy] = amount;
                    }
                    else
                    {
                        toysCount[toy] += amount;
                    }
                    if (!childrenTotal.ContainsKey(name))
                    {
                        childrenTotal[name] = amount;
                    }
                    else
                    {
                        childrenTotal[name] += amount;
                    }
                }
                else
                {
                    string nameToRemove = tokens[1];
                    childrenTotal.Remove(nameToRemove);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Children:");
            foreach (var kvp in childrenTotal.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = kvp.Key;
                int count = kvp.Value;
                Console.WriteLine($"{name} -> {count}");
            }
            Console.WriteLine("Presents:");
            foreach (var kvp in toysCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}