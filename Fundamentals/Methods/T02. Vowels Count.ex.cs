using System;

namespace T02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(SearchForVowels(input));
        }

        static int SearchForVowels(string input)
        {
            int counter = 0;

            foreach (char vowels in input)
            {
                if ("aeiou".Contains(vowels))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
