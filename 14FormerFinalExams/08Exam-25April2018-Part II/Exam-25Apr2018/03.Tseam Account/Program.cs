using System;
using System.Collections.Generic;
using System.Linq;

namespace _09TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gameList = Console.ReadLine().Split(new char[] { ' ' }).ToList();
            string command = Console.ReadLine();


            while (command != "Play!")
            {
                string[] tokens = command.Split(new char[] { ' ' }).ToArray();
                string action = tokens[0];
                if (action == "Install")
                {
                    string game = tokens[1];
                    if (!gameList.Contains(game))
                    {
                        gameList.Add(game);
                    }
                }
                else if (action == "Uninstall")
                {
                    gameList.Remove(tokens[1]);
                }
                else if (action == "Update")
                {
                    string game = tokens[1];
                    if (gameList.Contains(game))
                    {
                        gameList.Remove(game);
                        gameList.Add(game);
                    }
                }
                else if (action == "Expansion")
                {
                    string[] tokens1 = tokens[1].Split(new char[] { '-' }).ToArray();

                    string game = tokens1[0];
                    string expansion = tokens1[1];
                    if (gameList.Contains(game))
                    {
                        int indexOfGame = gameList.IndexOf(game);
                        if (indexOfGame != gameList.Count - 1)
                        {
                            gameList.Insert(indexOfGame + 1, $"{game}:{expansion}");
                        }
                        else
                        {
                            gameList.Add($"{game}:{expansion}");
                        }

                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", gameList));
        }
    }
}