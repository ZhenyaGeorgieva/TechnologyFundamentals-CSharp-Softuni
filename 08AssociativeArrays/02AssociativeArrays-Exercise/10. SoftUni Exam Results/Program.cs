using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string command = Console.ReadLine();
        Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
        Dictionary<string, int> userPoints = new Dictionary<string, int>();
        while (command != "exam finished")
        {
            if (!command.Contains("banned"))
            {
                string[] tokens = command.Split("-");
                string user = tokens[0];
                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions[language] = 0;
                }
                languageSubmissions[language] += 1;

                if (!userPoints.ContainsKey(user))
                {
                    userPoints[user] = points;
                }
                else
                {
                    if (points > userPoints[user])
                    {
                        userPoints[user] = points;
                    }
                }
            }
            else
            {
                string[] tokens = command.Split("-");
                string name = tokens[0];
                if (userPoints.ContainsKey(name))
                {
                    userPoints.Remove(name);
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("Results:");
        foreach (var kvp in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key} | {kvp.Value}");
        }
        Console.WriteLine("Submissions:");
        foreach (var kvp in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}