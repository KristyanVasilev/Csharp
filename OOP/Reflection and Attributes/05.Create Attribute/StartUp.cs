using System;

namespace AuthorProblem
{
    [Author("Goshe")]
    public class StartUp
    {
        [Author("Pesho")]
        [Author("Ivan")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
