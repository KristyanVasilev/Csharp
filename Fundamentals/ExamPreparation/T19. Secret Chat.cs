using System;
using System.Linq;
using System.Text;

namespace T19._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder result = new StringBuilder(message);
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] currCmd = command.Split(":|:");
                if (currCmd[0] == "ChangeAll")
                {
                    string substring = currCmd[1];
                    string replacement = currCmd[2];
                    result.Replace(substring, replacement);
                    Console.WriteLine(result);

                }
                else if (currCmd[0] == "InsertSpace")
                {
                    int index = int.Parse(currCmd[1]);
                    result.Insert(index, " ");
                    Console.WriteLine(result);
                }
                else if (currCmd[0] == "Reverse")
                {
                    string substring = currCmd[1];
                    if (result.ToString().Contains(substring))
                    {
                        int index = result.ToString().IndexOf(substring);
                        result.Remove(index, substring.Length);                        
                        result.Append(string.Join("", substring.Reverse()));
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("error");                       
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {result}");
        }
    }
}
