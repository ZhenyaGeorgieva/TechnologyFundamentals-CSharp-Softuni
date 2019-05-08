using System;
using System.Collections.Generic;
using System.Linq;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Dictionary<string, double> gamePrice = new Dictionary<string, double>();
            Dictionary<string, string> gameDlc = new Dictionary<string, string>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i].Contains("-"))
                {
                    string[] gamePriceTokens = tokens[i].Split("-");
                    string game = gamePriceTokens[0];
                    double price = double.Parse(gamePriceTokens[1]);
                    if (!gamePrice.ContainsKey(game))
                    {
                        gamePrice[game] = price;
                    }
                }
                if (tokens[i].Contains(":"))
                {
                    string[] gameDlcTokens = tokens[i].Split(":");
                    string game = gameDlcTokens[0];
                    string dlc = gameDlcTokens[1];
                    if (gamePrice.ContainsKey(game))
                    {
                        gamePrice[game] *= 1.2;
                        if (!gameDlc.ContainsKey(game))
                        {
                            gameDlc[game] = dlc;
                        }
                    }
                }
            }
            Dictionary<string, double> gamesWithDlcPrice = new Dictionary<string, double>();
            Dictionary<string, double> gamesWithoutPrice = new Dictionary<string, double>();
            foreach (var kvp in gamePrice)
            {
                string game = kvp.Key;
                double price = kvp.Value;
                if (gameDlc.ContainsKey(game))
                {
                    gamesWithDlcPrice[game] = gamePrice[game] * 0.5;
                }
                else
                {

                    gamesWithoutPrice[game] = gamePrice[game] * 0.8;
                }
            }
            foreach (var kvp in gamesWithDlcPrice.OrderBy(x => x.Value))
            {
                string game = kvp.Key;
                double price = kvp.Value;
                string dlc = gameDlc[game];
                Console.WriteLine($"{game} - {dlc} - {price:f2}");
            }
            foreach (var kvp in gamesWithoutPrice.OrderByDescending(x => x.Value))
            {
                string game = kvp.Key;
                double price = kvp.Value;
                Console.WriteLine($"{game} - {price:f2}");
            }
        }
    }
}
