using System;
using System.Linq;
using System.Collections.Generic;

namespace _16._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPass = new Dictionary<string, string>();
            var usernamePoints = new Dictionary<string, Dictionary<string, int>>();
            var contestPoints = new Dictionary<string, int>();
            var totalPoints = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                var cmd = input.Split(":");
                string contest = cmd[0];
                string password = cmd[1];

                contestPass.Add(contest, password);
                input = Console.ReadLine();
            }

            string currInput = Console.ReadLine();
            while (currInput != "end of submissions")
            {
                var cmd = currInput.Split("=>");
                string contest = cmd[0];
                string password = cmd[1];
                string username = cmd[2];
                int points = int.Parse(cmd[3]);

                if (contestPass.ContainsKey(contest) && contestPass[contest].Contains(password))
                {
                    if (!usernamePoints.ContainsKey(username))
                    {
                        usernamePoints.Add(username, new Dictionary<string, int>());
                        usernamePoints[username].Add(contest, points);
                        totalPoints.Add(username,points);
                    }
                    else
                    {
                        if (usernamePoints[username].ContainsKey(contest))
                        {
                            if (usernamePoints[username][contest] < points)
                            {
                                usernamePoints[username][contest] = points;
                                totalPoints[username] += points;
                            }
                        }
                        else
                        {
                            usernamePoints[username].Add(contest, points);
                            totalPoints[username] += points;
                        }
                    }
                }

                currInput = Console.ReadLine();
            }

            foreach (var point in totalPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {point.Key} with total {point.Value} points.");
                break;
            }
            Console.WriteLine("Ranking: ");
            foreach (var user in usernamePoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
