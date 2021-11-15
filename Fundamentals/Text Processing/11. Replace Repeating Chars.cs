using System;

namespace _11._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char firstChar = input[0];
            Console.Write(firstChar);

            for (int i = 1; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar != firstChar)
                {
                    firstChar = currChar;
                    Console.Write(firstChar);
                }
            }
        }
    }
}
