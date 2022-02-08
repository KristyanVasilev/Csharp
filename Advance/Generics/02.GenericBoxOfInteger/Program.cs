using System;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            var box = new Box<int>();

            for (int i = 0; i < value; i++)
            {
                box.Store.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box);
        }
    }
}
