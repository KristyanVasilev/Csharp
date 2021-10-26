using System;

namespace T09._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string enemyDistance = Console.ReadLine();
            int count = 0;

            while (enemyDistance != "End of battle")
            {
                int distance = int.Parse(enemyDistance);
                if (energy >= distance)
                {
                    energy -= distance;
                    count++;
                    if (count % 3 == 0) energy += count;
                }
                else Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");

                enemyDistance = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
        }
    }
}
