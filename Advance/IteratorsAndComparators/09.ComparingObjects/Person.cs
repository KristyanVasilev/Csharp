using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Comparators
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var name = this.Name.CompareTo(other.Name);
            if (name != 0)
            {
                return name;
            }

            var age = this.Age.CompareTo(other.Age);
            if (age != 0)
            {
                return age;
            }

            var town = this.Town.CompareTo(other.Town);
            if (town != 0)
            {
                return town;
            }

            return 0;
        }
    }
}
