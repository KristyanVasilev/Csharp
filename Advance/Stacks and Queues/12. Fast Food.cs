using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> customers = new Queue<int>(orders);
            int maxOrder = int.MinValue;

            while (customers.Count > 0)
            {
                int order = customers.Peek();
                if (maxOrder < order)
                {
                    maxOrder = order;
                }
                if (quantityOfFood - order < 0)
                {
                    break;
                }

                order = customers.Dequeue();
                quantityOfFood -= order;
            }

            Console.WriteLine(maxOrder);
            Console.WriteLine(customers.Count > 0 ? $"Orders left: {string.Join(" ", customers)}" : "Orders complete");
        }
    }
}
