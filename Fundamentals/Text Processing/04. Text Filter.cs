using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannedword in word)
            {
                text = text.Replace(bannedword, new string('*', bannedword.Length));
            }

            Console.WriteLine(text);
        }
    }
}
