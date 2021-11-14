using System;

namespace _09._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedText = "";

            foreach (char symbol in input)
            {
                int currPosition = symbol;
                currPosition += 3;
                encryptedText += (char)currPosition;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
