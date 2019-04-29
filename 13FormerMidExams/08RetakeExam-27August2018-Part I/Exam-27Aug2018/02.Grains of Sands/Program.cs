using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grainsOfSand = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Mort")
            {
                List<string> tokens = command.Split().ToList();
                string action = tokens[0];
                if (action == "Add")
                {
                    int valueToAdd = int.Parse(tokens[1]);
                    grainsOfSand.Add(valueToAdd);
                }
                else if (action == "Remove")
                {
                    int value = int.Parse(tokens[1]);
                    if (grainsOfSand.Contains(value))
                    {
                        grainsOfSand.Remove(value);
                    }
                    else if (value >= 0 && value < grainsOfSand.Count)
                    {
                        grainsOfSand.RemoveAt(value);
                    }
                }
                else if (action == "Replace")
                {
                    int value = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);
                    if (grainsOfSand.Contains(value))
                    {
                        int indexOfValue = grainsOfSand.IndexOf(value);
                        grainsOfSand.RemoveAt(indexOfValue);
                        grainsOfSand.Insert(indexOfValue, replacement);
                    }
                }
                else if (action == "Increase")
                {
                    int value = int.Parse(tokens[1]);
                    int increaseValue = int.MinValue;
                    bool increaseValueFound = false;
                    for (int i = 0; i < grainsOfSand.Count; i++)
                    {
                        if (grainsOfSand[i] >= value)
                        {
                            increaseValue = grainsOfSand[i];
                            increaseValueFound = true;
                            break;
                        }
                    }
                    if (!increaseValueFound)
                    {
                        increaseValue = grainsOfSand[grainsOfSand.Count - 1];
                    }
                    for (int i = 0; i < grainsOfSand.Count; i++)
                    {
                        grainsOfSand[i] += increaseValue;
                    }
                }
                else if (action == "Collapse")
                {
                    int value = int.Parse(tokens[1]);
                    grainsOfSand = grainsOfSand.Where(x => x >= value).Select(x => x).ToList();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", grainsOfSand));
        }
    }
}
