using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().ToCharArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().ToCharArray());

            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";

            while (consonants.Count > 0)
            {
                char vowel = vowels.Dequeue();
                char consonant = consonants.Pop();

                pear = pear.Replace(vowel, '$');
                pear = pear.Replace(consonant, '$');
                flour = flour.Replace(vowel, '$');
                flour = flour.Replace(consonant, '$');
                pork = pork.Replace(vowel, '$');
                pork = pork.Replace(consonant, '$');
                olive = olive.Replace(vowel, '$');
                olive = olive.Replace(consonant, '$');

                vowels.Enqueue(vowel);
            }

            var sb = new StringBuilder();
            int count = 0;
            if (pear == "$$$$")
            {
                count++;
                sb.AppendLine("pear");
            }
            if (flour == "$$$$$")
            {
                count++;
                sb.AppendLine("flour");
            }
            if (pork == "$$$$")
            {
                count++;
                sb.AppendLine("pork");
            }
            if (olive == "$$$$$")
            {
                count++;
                sb.AppendLine("olive");
            }

            Console.WriteLine($"Words found: {count}");
            Console.WriteLine(sb);
        }
    }
}

