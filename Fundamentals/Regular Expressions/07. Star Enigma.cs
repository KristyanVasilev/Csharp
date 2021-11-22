using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _07._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attack = new List<string>();
            List<string> destroyed = new List<string>();
            string regexPattern = @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[\d+]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<soldiers>[\d+]+)";

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string descryptedMessage = "";

                foreach (char letter in message)
                {
                    descryptedMessage += (char)(letter - sum);
                }
                Match matches = Regex.Match(descryptedMessage, regexPattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string planetName = matches.Groups["name"].Value;
                    int population = int.Parse(matches.Groups["population"].Value);
                    char type = char.Parse(matches.Groups["type"].Value);
                    int soldiers = int.Parse(matches.Groups["soldiers"].Value);
                    switch (type)
                    {
                        case 'A':
                            attack.Add(planetName);
                            break;
                        case 'D':
                            destroyed.Add(planetName);
                            break;
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attack.Count}");
            attack.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
