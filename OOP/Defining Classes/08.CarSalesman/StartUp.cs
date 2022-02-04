using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                var engine = new Engine()
                {
                    Model = model,
                    Power = power
                };
                if (input.Length == 4)
                {
                    engine.Displacement = int.Parse(input[2]);
                    engine.Efficiency = input[3];
                }
                else if (input.Length == 3)
                {
                    bool isDisplacement = int.TryParse(input[2], out var disp);
                    if (isDisplacement)
                    {
                        engine.Displacement = disp;
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engine = input[1];
                Engine lookForEngine = engines.FirstOrDefault(x => x.Model == engine);

                var car = new Car()
                {
                    Model = model,
                    Engine = lookForEngine
                };

                if (input.Length == 4)
                {
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                else if (input.Length == 3)
                {
                    bool isWeight = int.TryParse(input[2], out var weight);
                    if (isWeight)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                string displacementInfo = car.Engine.Displacement.HasValue ? 
                    $"    Displacement: {car.Engine.Displacement}" : 
                    $"    Displacement: n/a";
                Console.WriteLine(displacementInfo);

                string efficiencyInfo = car.Engine.Efficiency != null ?
                    $"    Efficiency: {car.Engine.Efficiency}" :
                    $"    Efficiency: n/a";
                Console.WriteLine(efficiencyInfo);

                string weightInfo = car.Weight.HasValue ?
                    $"  Weight: {car.Weight}" :
                    $"  Weight: n/a";
                Console.WriteLine(weightInfo);

                string colorInfo = car.Color != null ?
                    $"  Color: {car.Color}" :
                    $"  Color: n/a";
                Console.WriteLine(colorInfo);
            }
        }
    }
}

