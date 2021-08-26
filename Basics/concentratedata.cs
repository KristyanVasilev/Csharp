using System;

namespace concentratedata
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string lastname = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastname}, a {age}-years old person from {town}.");
        }
    }
}
