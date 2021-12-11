using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace examTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "Complete")
                {
                    break;
                }
                if (cmd[0] == "Make")
                {
                    int index = int.Parse(cmd[2]);
                    if (cmd[1] == "Lower")
                    {
                        string sb = password.Substring(index, 1);
                        password = password.Remove(index, 1);
                        password = password.Insert(index, sb.ToLower());
                        Console.WriteLine(password);
                    }
                    
                    if (cmd[1] == "Upper")
                    {
                        string sb = password.Substring(index, 1);
                        password = password.Remove(index, 1);
                        password = password.Insert(index, sb.ToUpper());
                        Console.WriteLine(password);
                    }
                    
                }
                if (cmd[0] == "Insert")
                {
                    int index = int.Parse(cmd[1]);
                    string sb = cmd[2];
                    if (index > -1 && index < password.Length)
                    {
                        password = password.Insert(index, sb);
                    }
                    Console.WriteLine(password);

                }
                if (cmd[0] == "Replace")
                {

                    char c = char.Parse(cmd[1]);
                    int value = int.Parse(cmd[2]);
                    if (password.Contains(c))
                    {
                        int n = (int)c;
                        int total = n + value;
                        char newC = (char)total;
                        password = password.Replace(c, newC);
                        Console.WriteLine(password);
                    }
                }
                if (cmd[0] == "Validation")
                {
                    Regex regexForLenght = new Regex(@"\w{8,}");
                    Match match4 = regexForLenght.Match(password);
                    if (!match4.Success)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    Regex regexForLetters = new Regex(@"\w");
                    Match match = regexForLetters.Match(password);
                    if (!match.Success)
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    Regex regerUpper = new Regex(@"[A-Z]");
                    Match match1 = regerUpper.Match(password);
                    if (!match1.Success)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    Regex regerForLowwer = new Regex(@"[a-z]");
                    Match match2 = regerForLowwer.Match(password);
                    if (!match2.Success)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    Regex regexForDigits = new Regex(@"[0-9]");
                    Match match3 = regexForDigits.Match(password);
                    if (!match3.Success)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
            }
        }
    }
}