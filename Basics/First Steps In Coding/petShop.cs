using System;

namespace PetShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogNum = double.Parse(Console.ReadLine());
            int othersPet = int.Parse(Console.ReadLine());
            double dogFood = dogNum * 2.50;
            int othersPetsF = othersPet * 4;

            Console.WriteLine($"{dogFood + othersPetsF} lv.");
        }
    }
}
