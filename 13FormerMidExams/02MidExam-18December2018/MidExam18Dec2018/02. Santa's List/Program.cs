using System;
using System.Collections.Generic;
using System.Linq;

namespace _02DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split("&").ToList();
            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] tokens = command.Split().ToArray();
                string action = tokens[0];
                if (action == "Bad")
                {
                    string badKid = tokens[1];
                    if (!kids.Contains(badKid))
                    {
                        kids.Insert(0, badKid);
                    }
                }
                if (action == "Good")
                {
                    string goodKid = tokens[1];
                    if (kids.Contains(goodKid))
                    {
                        kids.Remove(goodKid);
                    }
                }
                if (action == "Rename")
                {
                    string oldName = tokens[1];
                    string newName = tokens[2];
                    if (kids.Contains(oldName))
                    {
                        int indexOfOldName = kids.IndexOf(oldName);
                        kids.RemoveAt(indexOfOldName);
                        kids.Insert(indexOfOldName, newName);
                    }
                }
                if (action == "Rearrange")
                {
                    string kidsName = tokens[1];
                    if (kids.Contains(kidsName))
                    {
                        kids.Remove(kidsName);
                        kids.Add(kidsName);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
