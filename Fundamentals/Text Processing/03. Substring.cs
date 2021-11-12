using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(wordToRemove);

            while (index >= 0)
            {
                text = text.Remove(index,wordToRemove.Length);
                index = text.IndexOf(wordToRemove);
            }

            Console.WriteLine(text);
        }
    }
}
