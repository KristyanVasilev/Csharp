using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T17.Setination_mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=\/])(?<towns>[A-Z][A-Za-z]{2,})(\1)";
            int travelPoints = 0;
            List<string> destination = new List<string>();
            bool isValid = false;

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                string town = match.Groups["towns"].Value;
                destination.Add(town);
                travelPoints += town.Length;
                isValid = true;
            }
            if (isValid)
            {
                Console.Write("Destinations: ");
                Console.WriteLine(string.Join(", ", destination));
                Console.WriteLine($"Travel Points: {travelPoints}");
            }
            else
            {
                Console.WriteLine("Destinations: ");
                Console.WriteLine($"Travel Points: {travelPoints}");
            }
        }
    }
}
