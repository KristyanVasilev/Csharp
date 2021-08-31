using System;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {

            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int numOfTickets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double pricePerTicket = 0;

            switch (stage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 55.50;
                            break;
                        case "Premium":
                            pricePerTicket = 105.20;
                            break;
                        case "VIP":
                            pricePerTicket = 118.90;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 75.88;
                            break;
                        case "Premium":
                            pricePerTicket = 125.22;
                            break;
                        case "VIP":
                            pricePerTicket = 300.40;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 110.10;
                            break;
                        case "Premium":
                            pricePerTicket = 160.66;
                            break;
                        case "VIP":
                            pricePerTicket = 400;
                            break;
                    }
                    break;
            }

            double totalPrice = pricePerTicket * numOfTickets;
            bool hasFreePhoto = false;

            if (totalPrice > 4000)
            {
                totalPrice -= totalPrice * 0.25;
                hasFreePhoto = true;
            }
            else if (totalPrice > 2500)
            {
                totalPrice -= totalPrice * 0.10;
            }

            if (photo == 'Y' && !hasFreePhoto)
            {
                totalPrice += 40 * numOfTickets;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}