using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string command1 = Console.ReadLine();
            Dictionary<string, string> contestPassList = new Dictionary<string, string>();
            while (command1 != "end of contests")
            {
                string[] contestPass = command1.Split(':').ToArray();
                string contestName = contestPass[0];
                string pass = contestPass[1];
                contestPassList[contestName] = pass;
                command1 = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> participantsList = new Dictionary<string, Dictionary<string, int>>();
            while (command2 != "end of submissions")
            {
                string[] tokens = command2.Split("=>").ToArray();
                string contest = tokens[0];
                string pass = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestPassList.ContainsKey(contest) && contestPassList[contest] == pass)
                {
                    if (!participantsList.ContainsKey(user))
                    {
                        participantsList[user] = new Dictionary<string, int>();
                        participantsList[user][contest] = points;
                    }
                    else
                    {
                        if (!participantsList[user].ContainsKey(contest))
                        {
                            participantsList[user][contest] = points;
                        }
                        else
                        {
                            if (points > participantsList[user][contest])
                            {
                                participantsList[user][contest] = points;
                            }
                        }
                    }
                }
                command2 = Console.ReadLine();
            }
            int bestScore = int.MinValue;
            string bestName = string.Empty;
            foreach (var kvp in participantsList)
            {
                string user = kvp.Key;
                int sum = 0;
                foreach (var kvp1 in kvp.Value)
                {
                    int numberToAdd = kvp1.Value;
                    sum += numberToAdd;
                }
                if (sum > bestScore)
                {
                    bestScore = sum;
                    bestName = user;
                }
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestScore} points.");
            Console.WriteLine("Ranking:");
            var participantsList1 = participantsList.OrderBy(x => x.Key);
            foreach (var kvp in participantsList1)
            {
                string name = kvp.Key;
                Console.WriteLine(name);
                foreach (var kvp1 in kvp.Value.OrderByDescending(x => x.Value))
                {
                    string contest = kvp1.Key;
                    int pointes = kvp1.Value;
                    Console.WriteLine($"#  {contest} -> {pointes}");
                }
            }
        }
    }
}
