using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < messagesCount; i++)
            {
                string message = Console.ReadLine();
                int specialCount = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    char symbol = message[j];
                    if (symbol == 's'
                        || symbol == 't'
                        || symbol == 'a'
                        || symbol == 'r'
                        || symbol == 'S'
                        || symbol == 'T'
                        || symbol == 'A'
                        || symbol == 'R')
                    {
                        specialCount++;
                    }
                }
                char[] messageToManipulate = message.ToCharArray();
                string messageManipulated = string.Empty;
                for (int y = 0; y < messageToManipulate.Length; y++)
                {
                    char symbol = messageToManipulate[y];
                    char newSymbol = (char)((int)symbol - specialCount);
                    messageManipulated += newSymbol;
                }

                string regex = @"@(?<planet>[A-Za-z]{1,})([^@\-!:>]{0,}):(?<population>[0-9]{1,})([^@\-!:>]{0,})!(?<attack>[A|D])!([^@\-!:>]{0,})->(?<soldiers>[0-9]{1,})";
                bool isMessageValid = Regex.IsMatch(messageManipulated, regex);
                if (isMessageValid)
                {
                    var messageData = Regex.Matches(messageManipulated, regex);
                    foreach (Match x in messageData)
                    {
                        string side = x.Groups["attack"].Value;
                        string planet = x.Groups["planet"].Value;
                        if (side == "A")
                        {
                            attacked.Add(planet);
                        }
                        else if (side == "D")
                        {
                            destroyed.Add(planet);
                        }
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count > 0)
            {
                var attacked1 = attacked.OrderBy(x => x);
                foreach (var x in attacked1)
                {
                    Console.WriteLine($"-> {x}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                var destroyed1 = destroyed.OrderBy(x => x);
                foreach (var x in destroyed1)
                {
                    Console.WriteLine($"-> {x}");
                }
            }
        }
    }
}
