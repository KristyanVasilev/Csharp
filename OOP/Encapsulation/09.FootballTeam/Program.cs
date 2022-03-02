using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
           
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandInfo = command.Split(';');
                try
                {
                    if (commandInfo[0] == "Team")
                    {
                        string teamName = commandInfo[1];
                        var team = new Team(teamName);
                        teams.Add(teamName, team);
                    }
                    else if (commandInfo[0] == "Add")
                    {
                        string teamName = commandInfo[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine(($"Team {teamName} does not exist."));
                            command = Console.ReadLine();
                            continue;
                        }
                        string playerName = commandInfo[2];
                        int endurance = int.Parse(commandInfo[3]);
                        int sprint = int.Parse(commandInfo[4]);
                        int dribble = int.Parse(commandInfo[5]);
                        int passing = int.Parse(commandInfo[6]);
                        int shooting = int.Parse(commandInfo[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[teamName].AddPlayer(player);
                    }
                    else if (commandInfo[0] == "Remove")
                    {
                        string teamName = commandInfo[1];
                        string playerName = commandInfo[2];

                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (commandInfo[0] == "Rating")
                    {
                        string teamName = commandInfo[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine(($"Team {teamName} does not exist."));
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}
