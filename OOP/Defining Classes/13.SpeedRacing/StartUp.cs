using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double FuelConsumptionPerKilometer = double.Parse(input[2]);

                var car = new Car(model,fuelAmount, FuelConsumptionPerKilometer);
                cars.Add(model, car);
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                string currCarModel = command[1];
                double distance = double.Parse(command[2]);
                var carToDrive = cars[currCarModel];
                carToDrive.Drive(distance);

                command = Console.ReadLine().Split();
            }
            
            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}


