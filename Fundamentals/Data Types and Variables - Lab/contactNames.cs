using System;

namespace contactNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string fisrtName = Console.ReadLine();
            string secondName = Console.ReadLine();
            var delimeter = Console.ReadLine();

            Console.WriteLine($"{fisrtName}{delimeter}{secondName}");
        }
    }
}
