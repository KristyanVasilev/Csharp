using System;
using System.Collections.Generic;

namespace Comparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                string name = command[0];
                int age = int.Parse(command[1]);
                string town = command[2];

                var person = new Person(name, age, town);
                people.Add(person);

                command = Console.ReadLine().Split();
            }

            int equals = 0;
            int diff = 0;

            int n = int.Parse(Console.ReadLine());

            var personToCompare = people[n - 1];

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equals++;
                }
                else
                {
                    diff++;
                }
            }

            if (equals == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equals} {diff} {people.Count}");
            }
        }
    }
}
