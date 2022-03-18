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
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }

        [Author("Ivan")]
        public void Test()
        {

        }
    }
}
