using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                if (age > 30)
                {
                    var person = new Person(name,age);
                    persons.Add(person);
                }
            }

            var SortedPersons = persons.OrderBy(x => x.Name);
            foreach (var person in SortedPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
