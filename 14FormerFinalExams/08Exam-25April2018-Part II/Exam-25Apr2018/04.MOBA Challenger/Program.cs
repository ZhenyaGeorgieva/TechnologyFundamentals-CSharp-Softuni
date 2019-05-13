using System;
using System.Collections.Generic;
using System.Linq;

namespace _10MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playerTotalSkill = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] tokens = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player = tokens[0].Trim();
                    string position = tokens[1].Trim();
                    int skill = int.Parse(tokens[2]);
                    int skillToAdd = 0;
                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        playerPositionSkill[player] = new Dictionary<string, int>();
                        playerPositionSkill[player][position] = skill;
                    }
                    else
                    {
                        if (!playerPositionSkill[player].ContainsKey(position))
                        {
                            playerPositionSkill[player][position] = skill;
                            skillToAdd = skill;

                        }
                        else
                        {
                            if (skill > playerPositionSkill[player][position])
                            {
                                playerPositionSkill[player][position] = skill;
                                skillToAdd = skill - playerPositionSkill[player][position];
                            }
                        }
                    }
                    if (!playerTotalSkill.ContainsKey(player))
                    {
                        playerTotalSkill[player] = skill;

                    }
                    else
                    {
                        playerTotalSkill[player] += skillToAdd;
                    }
                }
                else
                {
                    string[] tokens = command.Split(new string[] { "vs" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player1 = tokens[0].Trim();
                    string player2 = tokens[1].Trim();
                    bool isTherePositionInCommon = false;
                    string playerToRemove = string.Empty;
                    if (playerPositionSkill.ContainsKey(player1) && playerPositionSkill.ContainsKey(player2))
                    {
                        foreach (var kvp in playerPositionSkill[player1])
                        {
                            string positionPlayer1 = kvp.Key;
                            foreach (var kvp1 in playerPositionSkill[player2])
                            {
                                string positionPlayer2 = kvp1.Key;
                                if (positionPlayer1 == positionPlayer2)
                                {
                                    isTherePositionInCommon = true;
                                    break;
                                }
                            }
                            if (isTherePositionInCommon)
                            {
                                break;
                            }
                        }
                        if (isTherePositionInCommon)
                        {
                            int totalSkillPlayer1 = playerTotalSkill[player1];
                            int totalSkillPlayer2 = playerTotalSkill[player2];
                            if (totalSkillPlayer1 > totalSkillPlayer2)
                            {
                                playerToRemove = player2;
                            }
                            else if (totalSkillPlayer2 > totalSkillPlayer1)
                            {
                                playerToRemove = player1;
                            }
                        }
                    }
                    if (playerToRemove != string.Empty)
                    {
                        playerPositionSkill.Remove(playerToRemove);
                        playerTotalSkill.Remove(playerToRemove);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var kvp in playerTotalSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = kvp.Key;
                int total = kvp.Value;
                Console.WriteLine($"{name}: {total} skill");
                foreach (var kvp1 in playerPositionSkill[name].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string position = kvp1.Key;
                    int skill = kvp1.Value;
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }
    }
}