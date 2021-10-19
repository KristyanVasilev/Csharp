using System;
using System.Collections.Generic;
using System.Linq;
namespace T09._Pokemon_Don_t_Go.ex
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int currentElemnt;
            int sum = 0;

            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    currentElemnt = sequence[0];
                    sum += currentElemnt;
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > sequence.Count - 1)
                {
                    currentElemnt = sequence[sequence.Count - 1];
                    sum += currentElemnt;
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    currentElemnt = sequence[index];
                    sum += currentElemnt;
                    sequence.RemoveAt(index);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (currentElemnt < sequence[i])
                    {
                        sequence[i] -= currentElemnt;
                    }
                    else
                    {
                        sequence[i] += currentElemnt;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
