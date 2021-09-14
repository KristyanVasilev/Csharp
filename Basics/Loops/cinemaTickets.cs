using System;

namespace cinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double totalTickets = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;

            while (movieName != "Finish")
            {
                double capacity = double.Parse(Console.ReadLine());
                double freeSeats = 0;

                while (capacity > freeSeats)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                    freeSeats++;
                }
                totalTickets += freeSeats;

                Console.WriteLine($"{movieName} - {freeSeats / capacity * 100:f2}% full.");

                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standard / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kid / totalTickets * 100:f2}% kids tickets.");

        }
    }
}
