using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                if (commands == "green")
                {
                    for (int i = 0; i < numberOfCarsThatCanPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(commands);
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");

        }
    }
}
