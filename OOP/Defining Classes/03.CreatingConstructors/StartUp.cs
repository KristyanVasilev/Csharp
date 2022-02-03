using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Stoyan";
            person.Age = 12;
            var secondPerson = new Person("Gosho",13);           
        }
    }
}
