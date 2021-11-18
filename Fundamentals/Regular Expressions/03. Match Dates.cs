using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection mathces = Regex.Matches(Console.ReadLine(), @"([0-9]{2})(.)([A-z]{3})(\2)([0-9]{4})");

            foreach  (Match match in mathces)
            {
                Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[5]}");
            }
        }
    }
}
