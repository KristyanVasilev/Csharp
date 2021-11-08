using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceSide = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    var data = input.Split(" | ");
                    string side = data[0];
                    string user = data[1];
                    if (!forceSide.ContainsKey(side))
                    {
                        forceSide.Add(side, new List<string>());
                        forceSide[side].Add(user);
                    }
                    else if (!forceSide.Values.Any(users => users.Contains(user)))
                    {
                        forceSide[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    var data = input.Split(" -> ");
                    string user = data[0];
                    string side = data[1];
                    if (!forceSide.Values.Any(users => users.Contains(user)))
                    {
                        if (!forceSide.ContainsKey(side))
                        {
                            forceSide.Add(side, new List<string>());
                        }
                        forceSide[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var sides in forceSide.Where(sides => sides.Value.Contains(user)))
                        {
                            sides.Value.Remove(user);
                        }
                        if (!forceSide.ContainsKey(side))
                        {
                            forceSide.Add(side, new List<string>());
                        }
                        forceSide[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }

            forceSide = forceSide.OrderByDescending(key => key.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, u => u.Value);
            foreach (var side in forceSide)
            {
                side.Value.Sort();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join($"\n! ", side.Value));
                }
            }
        }
    }
}
