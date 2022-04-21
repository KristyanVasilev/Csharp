using System;
using static DeepCopyInterface.Program;

namespace DeepCopyInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("George", new Adress { Street = "Moskovska", HouseNumber = "123" });
            var copyP = p.DeepCopy();
            copyP.Name = "Mitko";

            Console.WriteLine(p);
            Console.WriteLine(copyP);
        }
    }
}
