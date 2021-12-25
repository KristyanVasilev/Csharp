using System;
using System.Collections.Generic;


namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>();

            foreach (var child in children)
            {
                kids.Enqueue(child);
            }

            while (kids.Count > 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    var potatoKid = kids.Dequeue();
                    kids.Enqueue(potatoKid);
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
