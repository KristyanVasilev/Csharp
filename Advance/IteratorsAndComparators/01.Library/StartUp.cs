using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var bookOne = new Book("Animal Farm", 2003, "George Owel");
            var bookTwo = new Book("The Document", 2000, "George Owel", "Jack F");
            var bookThree = new Book("CatBook", 2006, "Peter Petrov");

            var library = new Library();
            var secondLibrary = new Library(bookOne, bookTwo, bookThree);

            foreach (var item in secondLibrary)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
