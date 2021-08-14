using System;

namespace addBags
{
    class Program
    {
        static void Main(string[] args)
        {

            double lugagePrice = double.Parse(Console.ReadLine());
            double lugageKg = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int numberOflugage = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (daysToTravel > 30)
            {
                lugagePrice = lugagePrice * 1.1;

                if (lugageKg <= 10)
                {
                    totalPrice = lugagePrice * 1.2;
                    //totalPrice *= numberOflugage;
                }
                else if (lugageKg > 10 && lugageKg <= 20)
                {
                    totalPrice = lugagePrice * 1.5;
                    totalPrice *= numberOflugage;
                }
                else if (lugageKg > 20)
                {
                    //int taxes = int.Parse(Console.ReadLine());
                    totalPrice = lugagePrice * numberOflugage;
                }
                Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
            }



            else if (daysToTravel >= 7 && daysToTravel <= 30)
            {
                lugagePrice = lugagePrice * 1.15;

                if (lugageKg <= 10)
                {
                    totalPrice = lugagePrice * 1.2;
                    totalPrice *= numberOflugage;
                }
                else if (lugageKg > 10 && lugageKg <= 20)
                {
                    totalPrice = lugagePrice * 1.5;
                    totalPrice *= numberOflugage;
                }
                else if (lugageKg > 20)
                {
                    //int taxes = int.Parse(Console.ReadLine());
                    totalPrice = lugagePrice  * numberOflugage;
                }
                Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
            }
            else if (daysToTravel < 7)
            {
                lugagePrice = lugagePrice * 1.4;

                if (lugageKg <= 10)
                {
                    totalPrice = lugagePrice * 1.2;
                    totalPrice *= numberOflugage;
                }
                else if (lugageKg > 10 && lugageKg <= 20)
                {
                    totalPrice = lugagePrice * 1.5;
                    totalPrice *= numberOflugage;
                }
                else if (lugageKg > 20)
                {
                    //int taxes = int.Parse(Console.ReadLine());
                    totalPrice = lugagePrice * numberOflugage;
                }
                Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
            }


        }
    }
}
