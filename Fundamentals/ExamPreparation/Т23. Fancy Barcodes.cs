using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Т23._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"[@][#]+(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])[@][#]+";


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string compare = match.Value;
                    string group = string.Empty;

                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {
                            group += compare[j];
                        }
                    }

                    if (group == "")
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
