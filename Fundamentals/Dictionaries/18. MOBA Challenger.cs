using System;
using System.Collections.Generic;
using System.Linq;

namespace _18._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var players = new Dictionary<string, Dictionary<string, int>>();
            var playerSkillPoints = new Dictionary<string, int>();

            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    var currInput = input.Split(" -> ");
                    string nickname = currInput[0];
                    string role = currInput[1];
                    int skillPoints = int.Parse(currInput[2]);

                    if (!players.ContainsKey(nickname))
                    {
                        players.Add(nickname, new Dictionary<string, int>());
                    }
                    if (players[nickname].ContainsKey(role) && players[nickname][role] < skillPoints)
                    {
                        players[nickname][role] = skillPoints;
                        playerSkillPoints[nickname] = skillPoints;
                    }
                    else
                    {
                        players[nickname].Add(role, skillPoints);
                        if (!playerSkillPoints.ContainsKey(nickname))
                        {
                            playerSkillPoints.Add(nickname, skillPoints);
                        }
                        else
                        {
                            playerSkillPoints[nickname] += skillPoints;
                        }
                    }

                }
                else if (input.Contains("vs"))
                {
                    var currInput = input.Split(" vs ");
                    string firstPlayer = currInput[0];
                    string secondPlayer = currInput[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        foreach (var role in players[firstPlayer])
                        {
                            if (!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer))
                                break;
                            foreach (var secondRole in players[secondPlayer])
                            {
                                if (role.Key == secondRole.Key)
                                {
                                    if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                                    {
                                        players.Remove(secondPlayer);
                                        break;
                                    }
                                    else if (players[firstPlayer].Values.Sum() < players[secondPlayer].Values.Sum())
                                    {
                                        players.Remove(firstPlayer);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var points in playerSkillPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                foreach (var player in players)
                {
                    if (points.Key == player.Key)
                    {
                        Console.WriteLine($"{player.Key}: {points.Value} skill");
                        foreach (var item in player.Value.OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"- {item.Key} <::> {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
