using System;
using System.Text;

namespace T16._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] splittedCommand = command.Split("|");
                if (splittedCommand[0] == "Insert")
                {
                    int index = int.Parse(splittedCommand[1]);
                    string value = splittedCommand[2];
                    result.Insert(index, value);
                }
                else if (splittedCommand[0] == "Move")
                {
                    int numberOfLetters = int.Parse(splittedCommand[1]);
                    string substring = result.ToString().Substring(0, numberOfLetters);
                    result.Remove(0,numberOfLetters);
                    result.Append(substring);
                }
                else if (splittedCommand[0] == "ChangeAll")
                {
                    result.Replace(splittedCommand[1], splittedCommand[2]);
                }
                command = Console.ReadLine();
            }
                Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}
