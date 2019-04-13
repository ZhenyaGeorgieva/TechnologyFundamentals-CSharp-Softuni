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
            string command = Console.ReadLine();
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            while (command != "no more time")
            {
                string[] tokens = command.Split(" -> ");
                string user = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                int pointsToAdd = 0;
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                    contests[contest][user] = points;
                    pointsToAdd = points;
                }
                else
                {
                    if (!contests[contest].ContainsKey(user))
                    {
                        contests[contest][user] = points;
                        pointsToAdd = points;
                    }
                    else
                    {
                        if (points > contests[contest][user])
                        {
                            int smallerPoints = contests[contest][user];
                            pointsToAdd = points - smallerPoints;
                            contests[contest][user] = points;
                        }
                    }

                }
                if (!users.ContainsKey(user))
                {
                    users[user] = points;
                }
                else
                {
                    users[user] += pointsToAdd;
                }
                command = Console.ReadLine();

            }
            foreach (var kvp in contests)
            {
                string contest = kvp.Key;
                int countOfUsers = 0;

                var usersPoints = kvp.Value;
                foreach (var count in usersPoints)
                {
                    countOfUsers++;
                }
                Console.WriteLine($"{contest}: {countOfUsers} participants");

                int counter = 0;
                foreach (var kvp1 in usersPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    string name = kvp1.Key;
                    int points = kvp1.Value;
                    Console.WriteLine($"{counter}. {name} <::> {points}");
                }
            }
            Console.WriteLine("Individual standings:");
            int counterNames = 0;
            foreach (var kvp in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counterNames++;
                string name = kvp.Key;
                int points = kvp.Value;
                Console.WriteLine($"{counterNames}. {name} -> {points}");
            }
        }
    }
}