using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string message = Console.ReadLine();
                int specialLetters = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    char currentLetter = message[j];
                    if (currentLetter == 'S'
                        || currentLetter == 'T'
                        || currentLetter == 'A'
                        || currentLetter == 'R'
                        || currentLetter == 's'
                        || currentLetter == 't'
                        || currentLetter == 'a'
                        || currentLetter == 'r')
                    {
                        specialLetters++;
                    }
                }
                string decrypted = string.Empty;
                for (int y = 0; y < message.Length; y++)
                {
                    int currentLetter = (int)message[y];
                    char newLetter = (char)(currentLetter - specialLetters);
                    decrypted += newLetter;
                }
                string regex = @"@(?<planet>[A-Za-z]{1,})([^@\-\!\:>]{0,}):(?<population>[0-9]{1,})([^@\-\!\:>]{0,})!(?<attack>[A|D])!([^@\-\!\:>]{0,})->(?<soldiers>[0-9]{1,})";
                if (Regex.IsMatch(decrypted, regex))
                {
                    var matchCombination = Regex.Matches(decrypted, regex);
                    foreach (Match x in matchCombination)
                    {
                        string planet = x.Groups["planet"].Value.ToString();
                        string type = x.Groups["attack"].Value.ToString();
                        if (type == "A")
                        {
                            attackedPlanets.Add(planet);
                        }
                        else
                        {
                            destroyedPlanets.Add(planet);
                        }
                    }
                }
            }
            var attackedToPrint = attackedPlanets.OrderBy(x => x);
            var destroyedToPrint = destroyedPlanets.OrderBy(x => x);
            Console.WriteLine($"Attacked planets: { attackedPlanets.Count}");
            foreach (var x in attackedToPrint)
            {
                Console.WriteLine($"-> {x}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var x in destroyedToPrint)
            {
                Console.WriteLine($"-> {x}");
            }
        }
    }
}