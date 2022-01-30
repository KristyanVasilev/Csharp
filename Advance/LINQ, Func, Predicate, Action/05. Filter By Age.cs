using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                Person currPerson = new Person();
                currPerson.Age = int.Parse(input[1]);
                currPerson.Name = input[0];
                people.Add(currPerson);
            }

            string olderOrYounger = Console.ReadLine().ToLower();
            int ageToCompare = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = p => true;
            if (olderOrYounger == "older")
            {
                filter = p => p.Age >= ageToCompare;
            }
            else if (olderOrYounger == "younger")
            {
                filter = p => p.Age < ageToCompare;
            }
            var filteredPeople = people.Where(filter);

            Func<Person, string> printFilter = p => p.Name + " - " + p.Age;
            string print = Console.ReadLine();
            if (print == "name age")
            {
                printFilter = p => p.Name + " - " + p.Age;
            }
            else if (print == "name")
            {
                printFilter = p => p.Name;
            }
            else if (print == "age")
            {
                printFilter = p => p.Age.ToString();
            }

            var personToString = filteredPeople.Select(printFilter);
            foreach (var item in personToString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
