using System;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numOfPeople / capacity);

            Console.WriteLine(courses);
         
        }
    }
}
