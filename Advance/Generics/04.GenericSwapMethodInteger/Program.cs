using System;
using System.Linq;

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

            int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(positions[0], positions[1]);

            Console.WriteLine(box);
        }
    }
}
