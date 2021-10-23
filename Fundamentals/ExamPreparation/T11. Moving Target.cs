using System;
using System.Linq;
using System.Collections.Generic;

namespace T11._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "End")
            {
                if (cmd[0] == "Shoot")
                {
                    int index = int.Parse(cmd[1]);
                    int power = int.Parse(cmd[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0) targets.RemoveAt(index);
                    }
                }
                else if (cmd[0] == "Add")
                {
                    int index = int.Parse(cmd[1]);
                    int value = int.Parse(cmd[2]);
                    if (index >= 0 && index < targets.Count - 1) targets.Insert(index, value);
                    else Console.WriteLine("Invalid placement!");
                }
                else if (cmd[0] == "Strike")
                {
                    int index = int.Parse(cmd[1]);
                    int radius = int.Parse(cmd[2]);
                    int strikedTarget = targets[index];
                    if (index - radius < 0 || index + radius > targets.Count-1)
                    {
                        Console.WriteLine("Strike missed!");
                        break;
                    }
                    else
                    {
                        for (int i = index - radius; i < index + radius; i++)
                        {
                            targets.RemoveAt(i);
                        }
                        targets.Remove(strikedTarget);
                        // targets.RemoveRange(index - radius, index + radius);
                    }

                }
                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
