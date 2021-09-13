using System;

namespace agencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {

            string companyName = Console.ReadLine();
            int numOfAdultsTickets = int.Parse(Console.ReadLine());
            int numOfKidTickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double taxes = double.Parse(Console.ReadLine());

            double kidTicket = ticketPrice - ticketPrice * 0.7;          

            double adultTickets = (ticketPrice + taxes) * numOfAdultsTickets;
           
            double kidticketPrice = (kidTicket + taxes) * numOfKidTickets;
          

            double totalProfi = (adultTickets + kidticketPrice) *0.2 ;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {totalProfi:f2} lv.");
        }
    }
}
