using System;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string book = Console.ReadLine();
            int counter = 0;

            while (book != searchedBook)
            {
                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
                book = Console.ReadLine();
            }
            if (book == searchedBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }

        }

    }
}
