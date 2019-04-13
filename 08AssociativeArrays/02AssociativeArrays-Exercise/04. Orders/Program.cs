using System;
using System.Collections.Generic;

namespace _01test
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemsPrices = new Dictionary<string, double>();
            var itemsQuantity = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split();
                    string nameItem = tokens[0];
                    double priceItem = double.Parse(tokens[1]);
                    int quantityItem = int.Parse(tokens[2]);

                    if (!itemsPrices.ContainsKey(nameItem))
                    {
                        itemsPrices[nameItem] = priceItem;
                    }
                    else if (itemsPrices.ContainsKey(nameItem) && priceItem != itemsPrices[nameItem])
                    {
                        itemsPrices[nameItem] = priceItem;
                    }
                    if (!itemsQuantity.ContainsKey(nameItem))
                    {
                        itemsQuantity[nameItem] = 0;
                    }
                    itemsQuantity[nameItem] += quantityItem;
                }
            }
            foreach (var kvp in itemsPrices)
            {
                string itemName = kvp.Key;
                double price = kvp.Value;

                foreach (var kvp1 in itemsQuantity)
                {
                    if (itemName == kvp1.Key)
                    {
                        int quantity = kvp1.Value;
                        double total = price * quantity;
                        Console.WriteLine($"{itemName} -> {total:f2}");
                    }
                }
            }
        }
    }
}