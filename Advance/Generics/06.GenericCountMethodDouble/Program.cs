using System;
using System.Linq;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < value; i++)
            {
                box.Store.Add(double.Parse(Console.ReadLine()));
            }

            double itemToCompare = double.Parse(Console.ReadLine());
          
            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}
