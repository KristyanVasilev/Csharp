using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _09.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> sets = new Queue<int>();
            int maxPriceSet = int.MinValue;

            while (hats.Count > 0 && scarfs.Count > 0)
            {
                var currHat = hats.Peek();
                var currScarf = scarfs.Peek();

                if (currHat > currScarf)
                {
                    var value = currScarf + currHat;
                    hats.Pop();
                    scarfs.Dequeue();
                    if (value > maxPriceSet)
                    {
                        maxPriceSet = value;
                    }
                    sets.Enqueue(value);
                }
                else if (currScarf > currHat)
                {
                    hats.Pop();
                }
                else if (currHat == currScarf)
                {
                    scarfs.Dequeue();
                    var hat = hats.Pop();
                    hats.Push(hat += 1);
                }
            }

            Console.WriteLine($"The most expensive set is: {maxPriceSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
