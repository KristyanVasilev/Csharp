using System;
using System.Linq;
using System.Collections.Generic;

namespace wordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalwords = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < totalwords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                
                words[word].Add(synonym);
            }

            foreach (var kvp in words)
            {
                var word = kvp.Key;
                var synonym = kvp.Value;

                Console.WriteLine($"{kvp.Key} -> {string.Join(", ",synonym)}");

            }
       }
    }
}
