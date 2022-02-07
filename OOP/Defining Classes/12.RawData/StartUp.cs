using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int j = 5; j <= 12; j += 2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j + 1]);
                    Tire tire = new Tire(tireAge, tirePressure);
                    tires[counter] = tire;
                    counter++;
                }
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            List<Car> filteredCars = new List<Car>();
            if (command == "fragile")
            {
                filteredCars = cars
                    .Where(c => c.Cargo.Type == "fragile"
                    && c.Tire.Any(p => p.Pressure < 1))
                    .ToList();
            }
            else
            {
                filteredCars = cars
                   .Where(c => c.Cargo.Type == "flammable"
                   && c.Engine.Power > 250)
                   .ToList();
            }

            filteredCars.ForEach(x => Console.WriteLine(x.Model));
        }
    }
}

