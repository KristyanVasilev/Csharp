using System;

namespace AbstractFactory
{
    public partial class Program
    {
        internal class TeaFactory : IHotDrinkFactory
        {
            public IHotDrink Prepare(int amount)
            {
                Console.WriteLine($"Preparing {amount}ml of hot tea!");
                return new Tea();
            }
        }
    }
}
