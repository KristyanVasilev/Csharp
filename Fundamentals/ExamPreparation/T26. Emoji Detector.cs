using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace T26._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([\::]{2}|[**]{2})[A-Z][a-z]{2,}(\1)";
            string numPattern = @"\d";
            int sum = 1;
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, numPattern);
            foreach (Match match in matches)
            {
                sum *= int.Parse(match.Value);
            }

            MatchCollection emojiMatches = Regex.Matches(input, emojiPattern);
            List<string> coolEmojis = new List<string>();
            foreach (Match item in emojiMatches)
            {
                int coolIndex = item.Value
                    .Substring(2, item.Value.Length - 4)
                    .ToCharArray()
                    .Sum(x => (int)x);

                if (coolIndex > sum )
                {
                    coolEmojis.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");           
            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
