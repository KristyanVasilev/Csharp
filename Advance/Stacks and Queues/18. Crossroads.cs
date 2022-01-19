using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int greenLight = int.Parse(Console.ReadLine());
        int freeWindow = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();
        int passedCars = 0;
        string commands = Console.ReadLine();

        while (commands != "END")
        {
            if (commands == "green")
            {
                int secondsToPass = greenLight + freeWindow;
                int currGreenLight = greenLight;
                while (currGreenLight > 0 && cars.Count > 0)
                {
                    string currCar = cars.Dequeue();
                    currGreenLight -= currCar.Length;
                    secondsToPass -= currCar.Length;
                    passedCars++;
                    if (secondsToPass < 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currCar} was hit at {currCar[currCar.Length - Math.Abs(secondsToPass)]}.");
                        return;
                    }
                }
            }
            else cars.Enqueue(commands);
          
            commands = Console.ReadLine();
        }

        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{passedCars} total cars passed the crossroads.");
    }
}