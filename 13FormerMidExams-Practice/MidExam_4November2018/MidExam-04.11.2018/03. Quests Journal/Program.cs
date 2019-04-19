using System;
using System.Collections.Generic;
using System.Linq;

namespace _03QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] tokens = command
                    .Split(" - ")
                    .ToArray();
                string action = tokens[0];
                if (action == "Start")
                {
                    string quest = tokens[1];
                    if (!quests.Contains(quest))
                    {
                        quests.Add(quest);
                    }
                }
                else if (action == "Complete")
                {
                    string quest = tokens[1];
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                    }
                }
                else if (action == "Side Quest")
                {
                    string[] sideQuests = tokens[1].Split(":").ToArray();
                    string quest = sideQuests[0];
                    string sideQuest = sideQuests[1];
                    if (quests.Contains(quest) && !quests.Contains(sideQuest))
                    {
                        int indexOfSideQuest = quests.IndexOf(quest);
                        if (indexOfSideQuest != quests.Count - 1)
                        {
                            quests.Insert(indexOfSideQuest + 1, sideQuest);
                        }
                        else
                        {
                            quests.Add(sideQuest);
                        }
                    }
                }
                else if (action == "Renew")
                {
                    string quest = tokens[1];
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                        quests.Add(quest);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", quests));
        }
    }
}