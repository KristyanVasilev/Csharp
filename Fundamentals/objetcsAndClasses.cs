using System;
using System.Globalization;

namespace objetcsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsText, "d/M/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
