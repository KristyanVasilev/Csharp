using System;

namespace VacBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookpages = int.Parse(Console.ReadLine());
            double readpagesperhour = double.Parse(Console.ReadLine());
            int daysforread = int.Parse(Console.ReadLine());

            double totaltime = bookpages / readpagesperhour;
            double hours = totaltime / daysforread;

            Console.WriteLine(hours);
        }
    }
}
