using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstdate = Console.ReadLine();
            string seconddate = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDayDifference(firstdate, seconddate));
        }
    }
}
