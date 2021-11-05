using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 0);
                }

                counts[wordInLowerCase]++;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
