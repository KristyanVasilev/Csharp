using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            var results = new Dictionary<string, int>();
            int totalKm = 0;

            while (input != "end of race")
            {
                MatchCollection matchesForNames = Regex.Matches(input, @"([A-Z]|[a-z]+)");
                MatchCollection matchesForKm = Regex.Matches(input, @"([0-9])");
                var currName = string.Join("",matchesForNames);
                var currKm = string.Join("", matchesForKm);
                totalKm = 0;

                for (int i = 0; i < currKm.Length; i++)
                {
                    totalKm += int.Parse(currKm[i].ToString());
                }

                if (names.Contains(currName))
                {
                    if (!results.ContainsKey(currName))
                    {
                        results.Add(currName, totalKm);
                    }
                    else
                    {
                        results[currName] += totalKm;
                    }
                }
                input = Console.ReadLine();
            }

            var winners = results.OrderByDescending(x => x.Value).Take(3);
            var firstPlace = winners.OrderByDescending(x => x.Value).Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);
            foreach (var first in firstPlace)
            {              
                Console.WriteLine($"1st place: {first.Key}");
            }
            foreach (var second in secondPlace)
            {
                Console.WriteLine($"2nd place: {second.Key}");
            }
            foreach (var third in thirdPlace)
            {
                Console.WriteLine($"3rd place: {third.Key}");
            }
        }
    }
}
