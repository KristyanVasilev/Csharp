using System;

namespace FactoryExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personf = new PersonFactory();
            Person person = personf.CreatPerson("Pesho");
            Person person2 = personf.CreatPerson("Pesho2");
            Console.WriteLine(person);
            Console.WriteLine(person2);
        }
    }
}
