using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> nameTime = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "start of concert")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split("; ").ToArray();
                    string action = tokens[0].Trim();
                    if (action == "Add")
                    {
                        string name = tokens[1].Trim();
                        if (!nameMembers.ContainsKey(name))
                        {
                            nameMembers[name] = new List<string>();
                        }
                        if (!nameTime.ContainsKey(name))
                        {
                            nameTime[name] = 0;
                        }
                        string[] members = tokens[2].Split(", ").ToArray();
                        for (int i = 0; i < members.Length; i++)
                        {
                            string member = members[i].Trim();
                            if (!nameMembers[name].Contains(member)
                                && nameMembers.Values.Any(x => x.Contains(member) == false))
                            {
                                nameMembers[name].Add(member);
                            }
                        }
                    }
                    if (action == "Play")
                    {
                        string name = tokens[1].Trim();
                        int time = int.Parse(tokens[2].Trim());

                        if (!nameTime.ContainsKey(name))
                        {
                            nameTime[name] = time;
                        }
                        else
                        {
                            nameTime[name] += time;
                        }
                        if (!nameMembers.ContainsKey(name))
                        {
                            nameMembers[name] = new List<string>();
                        }
                    }
                }
            }
            int totalTime = nameTime.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var kvp in nameTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = kvp.Key;
                int time = kvp.Value;
                Console.WriteLine($"{name} -> {time}");
            }
            string bandToPrint = Console.ReadLine();
            Console.WriteLine(bandToPrint);
            foreach (var x in nameMembers[bandToPrint])
            {
                Console.WriteLine($"=> {x}");
            }
        }
    }
}