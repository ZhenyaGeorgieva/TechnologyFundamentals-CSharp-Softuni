using System;
using System.Collections.Generic;
using System.Linq;

namespace _12ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> sideUsers = new Dictionary<string, List<string>>();
            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] tokens = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = tokens[0].Trim();
                    string user = tokens[1].Trim();
                    if (!sideUsers.ContainsKey(side))
                    {
                        sideUsers[side] = new List<string>();
                    }
                    if (!sideUsers[side].Contains(user)
                            && sideUsers.Values.Any(x => x.Contains(user)) == false)
                    {
                        sideUsers[side].Add(user);
                    }
                }
                if (command.Contains("->"))
                {
                    string[] tokens = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = tokens[1].Trim();
                    string user = tokens[0].Trim();
                    bool userFound = false;
                    foreach (var kvp in sideUsers)
                    {
                        string side1 = kvp.Key;
                        var listOfUsersSide1 = kvp.Value;
                        foreach (var users in listOfUsersSide1)
                        {
                            if (users == user)
                            {
                                listOfUsersSide1.Remove(user);
                                userFound = true;
                                if (sideUsers.ContainsKey(side))
                                {
                                    sideUsers[side].Add(user);
                                    Console.WriteLine($"{user} joins the {side} side!");
                                    break;
                                }
                                else
                                {
                                    sideUsers[side] = new List<string>();
                                    sideUsers[side].Add(user);
                                    Console.WriteLine($"{user} joins the {side} side!");
                                    break;
                                }

                            }
                        }
                        if (userFound)
                        {
                            break;
                        }
                    }
                    if (!userFound)
                    {
                        if (sideUsers.ContainsKey(side))
                        {
                            sideUsers[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                        else
                        {
                            sideUsers[side] = new List<string>();
                            sideUsers[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var x in sideUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string side = x.Key;
                int count = x.Value.Count;
                if (count != 0)
                {
                    Console.WriteLine($"Side: {side}, Members: { count}");
                    foreach (var names in x.Value.OrderBy(y => y))
                    {
                        Console.WriteLine($"! {names}");
                    }
                }
            }
        }
    }
}

