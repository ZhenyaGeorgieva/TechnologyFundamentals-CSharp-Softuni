using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            Dictionary<string, int> userMaxPoints = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exam finished")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split(new char[] { '-' });
                    if (tokens[1] != "banned")
                    {
                        string user = tokens[0];
                        string language = tokens[1];
                        int points = int.Parse(tokens[2]);
                        if (!languageSubmissions.ContainsKey(language))
                        {
                            languageSubmissions[language] = 1;
                        }
                        else
                        {
                            languageSubmissions[language] += 1;
                        }
                        if (!userMaxPoints.ContainsKey(user))
                        {
                            userMaxPoints[user] = points;
                        }
                        else
                        {
                            if (points > userMaxPoints[user])
                            {
                                userMaxPoints[user] = points;
                            }
                        }
                    }
                    else
                    {
                        string userToBan = tokens[0];
                        if (userMaxPoints.ContainsKey(userToBan))
                        {
                            userMaxPoints.Remove(userToBan);
                        }
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var kvp in userMaxPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = kvp.Key;
                int points = kvp.Value;
                Console.WriteLine($"{name} | {points}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string language = kvp.Key;
                int value = kvp.Value;
                Console.WriteLine($"{language} - {value}");
            }
        }
    }
}
