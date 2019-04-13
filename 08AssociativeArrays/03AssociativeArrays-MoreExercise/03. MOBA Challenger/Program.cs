using System;
using System.Collections.Generic;
using System.Linq;

namespace _00test00
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersPool = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playerSkill = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] tokens = command.Split(" -> ").ToArray();
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);
                    int additionalSkill = 0;

                    if (!playersPool.ContainsKey(player))
                    {
                        playersPool[player] = new Dictionary<string, int>();
                        playersPool[player][position] = skill;
                        additionalSkill = skill;
                    }
                    else
                    {
                        if (!playersPool[player].ContainsKey(position))
                        {
                            playersPool[player][position] = skill;
                            additionalSkill = skill;
                        }
                        else
                        {
                            if (skill > playersPool[player][position])
                            {
                                int oldSkill = playersPool[player][position];
                                additionalSkill = skill - oldSkill;
                                playersPool[player][position] = skill;
                            }
                        }
                    }
                    if (!playerSkill.ContainsKey(player))
                    {
                        playerSkill[player] = skill;
                    }
                    else
                    {
                        playerSkill[player] += additionalSkill;
                    }
                }
                else
                {
                    string[] tokens = command.Split(" vs ").ToArray();
                    string player1 = tokens[0];
                    string player2 = tokens[1];
                    if (playersPool.ContainsKey(player1) && playersPool.ContainsKey(player2))
                    {
                        bool isThereCommonPosition = false;
                        foreach (var kvp in playersPool[player1])
                        {
                            string player1Position = kvp.Key;

                            foreach (var kvp1 in playersPool[player2])
                            {
                                string player2Position = kvp1.Key;
                                if (player1Position == player2Position)
                                {
                                    isThereCommonPosition = true;
                                    break;
                                }
                                if (isThereCommonPosition)
                                {
                                    break;
                                }
                            }
                        }
                        if (isThereCommonPosition)
                        {
                            int sumPlayer1 = playerSkill[player1];
                            int sumPlayer2 = playerSkill[player2];
                            string playerToRemove = string.Empty;
                            if (sumPlayer1 > sumPlayer2)
                            {
                                playerToRemove = player2;
                            }
                            else if (sumPlayer1 < sumPlayer2)
                            {
                                playerToRemove = player1;
                            }
                            if (playerToRemove != string.Empty)
                            {
                                playersPool.Remove(playerToRemove);
                                playerSkill.Remove(playerToRemove);
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var kvp in playerSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");
                foreach (var kvp1 in playersPool[kvp.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string position = kvp1.Key;
                    int skill = kvp1.Value;
                    Console.WriteLine($"- {position} <::> {skill}");
                }

            }
        }
    }
}
