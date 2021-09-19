using System;
using System.Linq;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            var correctPassword = new string(username.ToCharArray().Reverse().ToArray());
            string password = Console.ReadLine();
            int counter = 1;

            while (password != correctPassword)
            {
                counter++;
                if (counter > 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");

        }
    }
}
