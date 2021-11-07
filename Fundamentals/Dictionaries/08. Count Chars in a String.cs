using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 0);
                    }
                    letters[letter]++;
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
