using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int swapedPosition = random.Next(words.Length);
                string temp = words[i];
                words[i] = words[swapedPosition];
                words[swapedPosition] = temp;
            }
            Console.WriteLine(string.Join("\n", words));

        }
    }
}
