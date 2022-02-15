using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var bookThree = new Book("CatBook", 2003, "Peter Petrov");
            var bookOne = new Book("Animal Farm", 2003, "George Owel");
            var bookTwo = new Book("The Document", 2010, "George Owel", "Jack F");

            var library = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
