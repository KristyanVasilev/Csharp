using System;
using System.Linq;

namespace _05.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int exceptionsCount = 0;
            while (exceptionsCount < 3)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);

                        numbers[index] = element;
                    }
                    else if (command[0] == "Print")
                    {
                        int start = int.Parse(command[1]);
                        int end = int.Parse(command[2]);
                        if (end <0 || end > numbers.Length-1)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        for (int i = start; i <= end; i++)
                        {
                            if (i == end)
                            {
                                Console.WriteLine(numbers[i]);
                            }
                            else
                            {
                                Console.Write(numbers[i] + ", ");
                            }
                        }
                    }
                    else if (command[0] == "Show")
                    {
                        int index = int.Parse(command[1]);
                        Console.WriteLine(numbers[index]);
                    }
                }
                catch (FormatException)
                {
                    exceptionsCount++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
                catch
                {
                    exceptionsCount++;
                    Console.WriteLine("The index does not exist!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
