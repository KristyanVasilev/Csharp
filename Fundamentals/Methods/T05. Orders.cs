using System;

namespace T05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (typeOfProduct)
            {
                case "coke":
                    TotalCokePrice(quantity);
                    break;

                case "water":
                    TotalWaterPrice(quantity);
                    break;

                case "coffee":
                    TotalCoffeePrice(quantity);
                    break;

                case "snacks":
                    TotalSnacksPrice(quantity);
                    break;
            }


        }

        private static void TotalSnacksPrice(int quantity)
        {
            double totalPrice = quantity * 2;
            Console.WriteLine($"{totalPrice:f2}");
        }

        private static void TotalCoffeePrice(int quantity)
        {
            double totalPrice = quantity * 1.50;
            Console.WriteLine($"{totalPrice:f2}");
        }

        private static void TotalWaterPrice(int quantity)
        {
            double totalPrice = quantity * 1;
            Console.WriteLine($"{totalPrice:f2}");
        }

        private static void TotalCokePrice(int quantity)
        {
            double totalPrice = quantity * 1.4;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
