using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareGreen = double.Parse(Console.ReadLine());
            double priceGreen = squareGreen * 7.61;
           

            double discount = priceGreen * 0.18;
            


            double finalPrice = priceGreen - discount;
            Console.WriteLine($"The final price is: {finalPrice}lv.");
            Console.WriteLine($"The discount is: {discount}lv.");

        }
    }
}
