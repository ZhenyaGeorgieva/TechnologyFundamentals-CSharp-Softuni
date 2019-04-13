using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            var junkMaterials = new SortedDictionary<string, int>();
            string bestMaterial = string.Empty;
            bool bestMaterialFound = false;
            while (true)
            {
                string[] items = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int i = 0; i < items.Length; i += 2)
                {
                    int itemQuantity = int.Parse(items[i]);
                    string itemName = items[i + 1].ToLower();

                    if (itemName == "shards" || itemName == "fragments" || itemName == "motes")
                    {
                        keyMaterials[itemName] += itemQuantity;

                        if (keyMaterials[itemName] >= 250)
                        {
                            bestMaterialFound = true;
                            bestMaterial = itemName;
                            keyMaterials[itemName] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(itemName))
                        {
                            junkMaterials[itemName] = 0;
                        }
                        junkMaterials[itemName] += itemQuantity;
                    }
                }
                if (bestMaterialFound)
                {
                    break;
                }
            }
            string itemWon = string.Empty;
            if (bestMaterial == "shards")
            {
                itemWon = "Shadowmourne";
            }
            else if (bestMaterial == "fragments")
            {
                itemWon = "Valanyr";
            }
            else if (bestMaterial == "motes")
            {
                itemWon = "Dragonwrath";
            }
            Console.WriteLine($"{itemWon} obtained!");

            var wonItemsToPrint = keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in wonItemsToPrint)
            {
                Console.WriteLine($"{ kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}