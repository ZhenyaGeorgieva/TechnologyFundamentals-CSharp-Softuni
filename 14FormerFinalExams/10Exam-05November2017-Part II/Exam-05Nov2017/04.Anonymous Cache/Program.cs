using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.AnonimousCashe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> setTotalSize = new Dictionary<string, long>();
            Dictionary<string, List<string>> setKeys = new Dictionary<string, List<string>>();
            Dictionary<string, Dictionary<string, long>> cashe = new Dictionary<string, Dictionary<string, long>>();

            string command = Console.ReadLine();
            while (command != "thetinggoesskrra")
            {
                if (!(command.Contains("|") && command.Contains("->")))
                {
                    string set = command;
                    if (!setTotalSize.ContainsKey(set))
                    {
                        setTotalSize[set] = 0;
                    }
                    if (!setKeys.ContainsKey(set))
                    {
                        setKeys[set] = new List<string>();
                    }
                    if (cashe.ContainsKey(set))
                    {
                        foreach (var kvp in cashe[set])
                        {
                            string key = kvp.Key;
                            long value = kvp.Value;
                            setTotalSize[set] += value;
                            if (!setKeys[set].Contains(key))
                            {
                                setKeys[set].Add(key);
                            }
                        }
                    }
                }
                else
                {
                    string[] tokens = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string key = tokens[0];
                    string[] sizeAndSet = tokens[1].Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    long size = long.Parse(sizeAndSet[0]);
                    string set = sizeAndSet[1];
                    if (setKeys.ContainsKey(set) && setTotalSize.ContainsKey(set))
                    {
                        setKeys[set].Add(key);
                        setTotalSize[set] += size;
                    }
                    else
                    {
                        if (!cashe.ContainsKey(set))
                        {
                            cashe[set] = new Dictionary<string, long>();
                            cashe[set][key] = size;
                        }
                        else
                        {
                            if (!cashe[set].ContainsKey(key))
                            {
                                cashe[set][key] = size;
                            }
                            else
                            {
                                cashe[set][key] += size;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            string bestSet = string.Empty;
            foreach (var kvp in setTotalSize.OrderByDescending(x => x.Value))
            {

                bestSet = kvp.Key;
                break;
            }
            if (bestSet != string.Empty)
            {
                Console.WriteLine($"Data Set: {bestSet}, Total Size: {setTotalSize[bestSet]}");

                foreach (var x in setKeys[bestSet])
                {
                    Console.WriteLine($"$.{x}");
                }
            }
        }
    }
}