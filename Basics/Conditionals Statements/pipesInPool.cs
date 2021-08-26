using System;

namespace pipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            
            double totalWaterFlown = H * P1 + H * P2;
            double percent = (totalWaterFlown / V) * 100;

            
            double percentOfP1 = ((H * P1) / totalWaterFlown) * 100;
            
            double percentOfP2 = ((H * P2) / totalWaterFlown) * 100;


            if (totalWaterFlown <= V)
            {
                Console.WriteLine($"The pool is {percent:f2}% full. Pipe 1: {percentOfP1:f2}%. Pipe 2: {percentOfP2:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {totalWaterFlown - V:f2} liters.");
            }











        }
    }
}
