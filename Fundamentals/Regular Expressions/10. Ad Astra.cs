using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _10._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\||#)(?<food>([A-za-z ?])+)(\1)(?<date>(0[1-9]|[1-2][0-9]|3[0-1])\/(0[1-9]|1[0-2])\/([0-9]{2}))(\1)(?<kcal>([0-9]{1,5}))(\1)";
            int totalkcals = 0;
            bool isValid = false;

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                int kcal = int.Parse(match.Groups["kcal"].Value);
                totalkcals += kcal;
                isValid = true;
            }
            if (isValid)
            {
                if (totalkcals >= 2000)
                {
                    int days = totalkcals / 2000;
                    Console.WriteLine($"You have food to last you for: {days} days!");
                    foreach (Match match in matches)
                    {
                        string product = match.Groups["food"].Value;
                        string date = match.Groups["date"].Value;
                        int kcal = int.Parse(match.Groups["kcal"].Value);
                        Console.WriteLine($"Item: {product}, Best before: {date}, Nutrition: {kcal}");
                    }
                }
                else
                {
                    Console.WriteLine("You have food to last you for: 0 days!");
                }
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
        }
    }
}