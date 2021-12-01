using System;
using System.Linq;
using System.Text;

namespace T22._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] currCmd = command.Split(" ");
                if (currCmd[0] == "TakeOdd")
                {
                    StringBuilder result = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            result.Append(password[i]);
                        }
                    }
                    password = result.ToString();
                    Console.WriteLine(password);

                }
                else if (currCmd[0] == "Cut")
                {
                    int index = int.Parse(currCmd[1]);
                    int lenght = int.Parse(currCmd[2]);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (currCmd[0] == "Substitute")
                {
                    string substring = currCmd[1];
                    string substitute = currCmd[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
