using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _08._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b");

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
