using System;

namespace cinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine(12);
                    break;
                case "tuesday":
                    Console.WriteLine(12);
                    break;
                case "wednesday":
                    Console.WriteLine(14);
                    break;
                case "thursday":
                    Console.WriteLine(14);
                    break;
                case "friday":
                    Console.WriteLine(12);
                    break;
                case "saturday":
                    Console.WriteLine(16);
                    break;
                case "sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
