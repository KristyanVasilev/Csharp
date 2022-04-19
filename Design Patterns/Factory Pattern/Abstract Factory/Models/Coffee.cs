using System;

namespace AbstractFactory
{
    public partial class Program
    {
        internal class Coffee : IHotDrink
        {
            public void Consume()
            {
                Console.WriteLine("Drinking hot Coffee!");
            }
        }
    }
}
