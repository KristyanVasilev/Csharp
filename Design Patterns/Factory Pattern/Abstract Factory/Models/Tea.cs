using System;

namespace AbstractFactory
{
    public partial class Program
    {
        internal class Tea : IHotDrink
        {
            public void Consume()
            {
                Console.WriteLine("Drinking hot Tea!");
            }
        }
    }
}
