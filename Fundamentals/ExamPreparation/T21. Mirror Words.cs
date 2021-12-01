using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace T21._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#])(?<wordOne>[A-Za-z]{3,})(\1)(\1)(?<wordTwo>[A-Za-z]{3,})(\1)";
            List<string> mirrorWords = new List<string>();
            int index = 0;

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string reverse = string.Join("", wordOne.Reverse());
                if (reverse == match.Groups["wordTwo"].Value)
                {
                    mirrorWords.Add($"{wordOne} <=> {match.Groups["wordTwo"].Value}");
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
