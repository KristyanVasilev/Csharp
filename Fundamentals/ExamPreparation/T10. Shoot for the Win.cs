using System;
using System.Linq;
using System.Collections.Generic;

namespace T10._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string indexOfTargets = Console.ReadLine();
            int count = 0;

            while (indexOfTargets != "End")
            {
                int index = int.Parse(indexOfTargets);
                if (index >= 0 && index <= targets.Count - 1)
                {
                    int shotedTarget = targets[index];
                    for (int i = 0; i < targets.Count ; i++)
                    {
                        if (targets[i] > shotedTarget && targets[i] != -1) targets[i] -= shotedTarget;
                        else if (targets[i] <= shotedTarget && targets[i] != -1) targets[i] += shotedTarget;
                       
                    }
                    targets[index] = -1;
                    count++;
                }
                indexOfTargets = Console.ReadLine();
            }
            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(String.Join(" ", targets));
        }
    }
}
