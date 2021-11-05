using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms.Add(word, new List<string>());
                }

                wordsSynonyms[word].Add(synonym);
            }

            foreach (var word in wordsSynonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
