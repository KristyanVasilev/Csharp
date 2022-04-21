using System;

namespace CopyThroughSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Mitko", Age = 42 };

            Person person2 = person.DeepCopy(); // crashes without [Serializable]

            person2.Name = "Gosho";
            Console.WriteLine(person);
            Console.WriteLine(person2);
        }
    }
}
