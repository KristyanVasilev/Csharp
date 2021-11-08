using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numOfUsers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfUsers; i++)
            {
                var commands = Console.ReadLine().Split();
                if (commands[0] == "register")
                {
                    string userName = commands[1];
                    string licensePlate = commands[2];
                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName,licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (commands[0] == "unregister")
                {
                    string userName = commands[1];
                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        users.Remove(userName);
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
