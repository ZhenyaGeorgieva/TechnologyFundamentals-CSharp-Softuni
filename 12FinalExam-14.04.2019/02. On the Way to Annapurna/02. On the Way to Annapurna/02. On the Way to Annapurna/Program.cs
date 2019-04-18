using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> storeItems = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split("->");
                    string action = tokens[0];
                    if (action == "Add")
                    {
                        string store = tokens[1];

                        if (tokens[2].Contains(","))
                        {
                            string[] items = tokens[2].Split(",");
                            if (!storeItems.ContainsKey(store))
                            {
                                storeItems[store] = new List<string>();
                                for (int i = 0; i < items.Length; i++)
                                {
                                    string itemToAdd = items[i];
                                    storeItems[store].Add(itemToAdd);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < items.Length; i++)
                                {
                                    string itemToAdd = items[i];
                                    storeItems[store].Add(itemToAdd);
                                }
                            }
                        }
                        else
                        {
                            string itemToAdd = tokens[2];
                            if (!storeItems.ContainsKey(store))
                            {
                                storeItems[store] = new List<string>();
                                storeItems[store].Add(itemToAdd);
                            }
                            else
                            {
                                storeItems[store].Add(itemToAdd);
                            }
                        }
                    }
                    else if (action == "Remove")
                    {
                        string storeToRemove = tokens[1];
                        if (storeItems.ContainsKey(storeToRemove))
                        {
                            storeItems.Remove(storeToRemove);
                        }
                    }
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var kvp in storeItems.OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Key))
            {
                string store = kvp.Key;
                List<string> items = kvp.Value;

                Console.WriteLine($"{store}");
                foreach (var x in items)
                {
                    Console.WriteLine($"<<{x}>>");
                }
            }
        }
    }
}