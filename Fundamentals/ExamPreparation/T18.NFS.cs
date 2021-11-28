using System;
using System.Collections.Generic;
using System.Linq;

namespace T18.NFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{car}|{mileage}|{fuel}"
            int numsOfCars = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < numsOfCars; i++)
            {
                string[] currCar = Console.ReadLine().Split("|");
                int mileage = int.Parse(currCar[1]);
                int fuel = int.Parse(currCar[2]);
                cars.Add(currCar[0], new List<int>());
                cars[currCar[0]].Add(mileage);
                cars[currCar[0]].Add(fuel);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] currCmd = command.Split(" : ");
                //•	"Drive : {car} : {distance} : {fuel}":
                if (currCmd[0] == "Drive")
                {
                    string currCar = currCmd[1];
                    int distance = int.Parse(currCmd[2]);
                    int fuel = int.Parse(currCmd[3]);
                    List<int> carData = cars[currCar];
                    if (carData[1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[currCar][0] += distance;
                        cars[currCar][1] -= fuel;
                        Console.WriteLine($"{currCar} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (cars[currCar][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {currCar}!");
                        cars.Remove(currCar);
                    }
                }
                //Refuel : {car} : {fuel}":
                else if (currCmd[0] == "Refuel")
                {
                    string currCar = currCmd[1];
                    int fuel = int.Parse(currCmd[2]);
                    int oldFuel = cars[currCar][1];
                    cars[currCar][1] += fuel;
                    if (cars[currCar][1] > 75)
                    {
                        cars[currCar][1] = 75;
                        Console.WriteLine($"{currCar} refueled with {75 - oldFuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{currCar} refueled with {fuel} liters");
                    }
                }
                //•	"Revert : {car} : {kilometers}":
                else if (currCmd[0] == "Revert")
                {
                    string currCar = currCmd[1];
                    int kmToDecrease = int.Parse(currCmd[2]);
                    cars[currCar][0] -= kmToDecrease;
                    if (cars[currCar][0] < 10000)
                    {
                        cars[currCar][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{currCar} mileage decreased by {kmToDecrease} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
