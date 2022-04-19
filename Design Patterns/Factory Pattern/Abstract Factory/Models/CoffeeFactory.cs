using System;

namespace AbstractFactory
{
    public partial class Program
    {
        internal class CoffeeFactory : IHotDrinkFactory
        {
            public IHotDrink Prepare(int amount)
            {
                Console.WriteLine($"Preparing {amount}ml of hot coffee!");
                return new Coffee();
            }
        }
    }
}
