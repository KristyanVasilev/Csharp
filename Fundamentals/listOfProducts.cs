using System;
using System.Linq;
using System.Collections.Generic;


namespace listOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(); 

            for (int i = 0; i < totalProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {products[j]}");
            }
        }
    }
}
