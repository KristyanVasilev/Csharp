using System;

namespace fuelTankPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine(); // "Diesel", "Gasoline", "Gas"
            double litersFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine(); // "Yes", "No"

            bool chekCard = true;

            if (clubCard == "No")
            {
                chekCard = false;
            }
            else if (clubCard == "Yes")
            {
                chekCard = true;
            }

            double diesel = 2.33;
            double dieselDiscount = 0.12;
            double gasoline = 2.22;
            double gasolineDiscount = 0.18;
            double gas = 0.93;
            double gasDiscount = 0.08;

            if (chekCard)
            {
                diesel -= dieselDiscount;
                gasoline -= gasolineDiscount;
                gas -= gasDiscount;
            }

            double fuelPrice = 0.0;
            double discount20 = 0.08;
            double discount25 = 0.10;

            switch (fuelType)
            {
                case "Diesel":
                    fuelPrice = diesel * litersFuel;
                    break;
                case "Gasoline":
                    fuelPrice = gasoline * litersFuel;
                    break;
                case "Gas":
                    fuelPrice = gas * litersFuel;
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }

            if (litersFuel >= 20 && litersFuel <= 25)
            {
                fuelPrice = fuelPrice - (fuelPrice * discount20);
            }
            else if (litersFuel > 25)
            {
                fuelPrice = fuelPrice - (fuelPrice * discount25);
            }
            Console.WriteLine($"{fuelPrice:f2} lv.");
        }
    }
}
    

