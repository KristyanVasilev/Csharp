using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Member { get; set; } = new List<Person>();

        public void AddMember(Person person)
        {
            Member.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = Member.OrderByDescending(x => x.Age).FirstOrDefault();
            return person;
        }
    }
}
