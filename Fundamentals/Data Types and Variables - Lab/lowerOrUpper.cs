using System;

namespace lowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            char ch1 = Console.ReadLine()[0]; 
            result = Char.IsUpper(ch1);
            if (result == true)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
