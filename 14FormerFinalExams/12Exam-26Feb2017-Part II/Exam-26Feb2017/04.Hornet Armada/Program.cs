using System;
using System.Collections.Generic;
using System.Linq;

namespace _24HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> legionSoldiersCount = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> legionLastActivity = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(tokens[0]);
                string legion = tokens[1].Trim();
                string soldierType = tokens[2].Trim();
                long soldiersCount = long.Parse(tokens[3]);
                if (!legionSoldiersCount.ContainsKey(legion))
                {
                    legionSoldiersCount[legion] = new Dictionary<string, long>();
                    legionSoldiersCount[legion][soldierType] = soldiersCount;
                }
                else
                {
                    if (!legionSoldiersCount[legion].ContainsKey(soldierType))
                    {
                        legionSoldiersCount[legion][soldierType] = soldiersCount;
                    }
                    else
                    {
                        legionSoldiersCount[legion][soldierType] += soldiersCount;
                    }
                }
                if (!legionLastActivity.ContainsKey(legion))
                {
                    legionLastActivity[legion] = lastActivity;
                }
                else
                {
                    if (lastActivity > legionLastActivity[legion])
                    {
                        legionLastActivity[legion] = lastActivity;
                    }
                }
            }
            string command = Console.ReadLine();
            if (command.Contains('\\'))
            {
                string[] tokens = command.Split(new char[] { '\\' });
                int activity = int.Parse(tokens[0]);
                string soldierType = tokens[1];
                Dictionary<string, long> finalToPrint = new Dictionary<string, long>();
                foreach (var kvp in legionLastActivity)
                {
                    string legion = kvp.Key;
                    int lastActivity = kvp.Value;
                    if (lastActivity < activity)
                    {
                        var collectionToPrint = legionSoldiersCount[legion];
                        foreach (var kvp1 in collectionToPrint)
                        {
                            if (kvp1.Key == soldierType)
                            {
                                finalToPrint[legion] = kvp1.Value;
                            }
                        }

                    }
                }
                foreach (var kvp2 in finalToPrint.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp2.Key} -> {kvp2.Value}");
                }
            }
            else
            {
                string soldierType = command;
                foreach (var kvp in legionLastActivity.OrderByDescending(x => x.Value))
                {
                    string legion = kvp.Key;
                    int lastActivity = kvp.Value;
                    foreach (var kvp1 in legionSoldiersCount[legion])
                    {
                        string currentSoldierType = kvp1.Key;
                        long currentSoldierCount = kvp1.Value;
                        if (currentSoldierType == soldierType)
                        {
                            Console.WriteLine($"{lastActivity} : {legion}");
                        }

                    }
                }
            }
        }
    }
}