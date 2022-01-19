using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletCount = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();
                bulletCount++;
                if (bullet <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else Console.WriteLine("Ping!");

                if (((bulletCount % gunBarrelSize).Equals(0)) && (bullets.Count > 0))  Console.WriteLine("Reloading!");           
            }

            Console.WriteLine(locks.Count == 0 ? $"{bullets.Count} bullets left. Earned ${intelligenceValue - bulletCount * bulletPrice}" : $"Couldn't get through. Locks left: {locks.Count}");
        }
    }
    
}
