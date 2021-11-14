using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ");

            foreach (var user in usernames)
            {
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool isValid = true;
                    foreach (var letter in user)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '_' || letter == '-'))
                        {
                            isValid = false;
                            break;
                        }                     
                    }
                    if (isValid)
                    {
                        Console.WriteLine(user);
                    }
                }
            }
        }
    }
}
