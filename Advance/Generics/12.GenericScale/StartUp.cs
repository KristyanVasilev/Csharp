using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var equalElemnts = new EqualityScale<int>(6, 6);
            Console.WriteLine(equalElemnts.AreEqual());
        }
    }
}
