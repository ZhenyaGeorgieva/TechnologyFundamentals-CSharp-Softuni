using System;
using System.Collections.Generic;
using System.Linq;

namespace _28RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> idName = new Dictionary<string, string>();
            Dictionary<string, List<string>> nameParticipants = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Time for Code")
                {
                    break;
                }
                else
                {
                    if (command.Contains("#"))
                    {
                        string[] tokens = command.Split(new char[] { '#', '\t', '\n', '\r' });
                        string id = tokens[0].Trim();

                        if (tokens[1].Contains("@"))
                        {
                            string[] nameAndParticipants = tokens[1].Split(new char[] { '@', '\t', '\n', '\r' });
                            string name = nameAndParticipants[0].Trim();
                            if (!idName.ContainsKey(id))
                            {
                                idName[id] = name;
                                if (!nameParticipants.ContainsKey(name))
                                {
                                    nameParticipants[name] = new List<string>();
                                }
                            }
                            else
                            {
                                if (name != idName[id])
                                {
                                    continue;
                                }
                            }
                            for (int i = 1; i < nameAndParticipants.Length; i++)
                            {
                                string participant = nameAndParticipants[i].Trim();
                                if (!nameParticipants.ContainsKey(name))
                                {
                                    nameParticipants[name] = new List<string>();
                                    nameParticipants[name].Add(participant);
                                }
                                else
                                {
                                    if (!nameParticipants[name].Contains(participant))
                                    {
                                        nameParticipants[name].Add(participant);
                                    }
                                }
                            }
                        }
                        else
                        {
                            string name = tokens[1].Trim();
                            if (!idName.ContainsKey(id))
                            {
                                idName[id] = name;
                                if (!nameParticipants.ContainsKey(name))
                                {
                                    nameParticipants[name] = new List<string>();
                                }
                            }
                        }
                    }
                }
            }
            foreach (var kvp in nameParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string name = kvp.Key;
                var participants = kvp.Value;
                Console.WriteLine($"{name} - {participants.Count}");
                foreach (var x in participants.OrderBy(x => x))
                {
                    Console.WriteLine($"@{x}");
                }
            }
        }
    }
}