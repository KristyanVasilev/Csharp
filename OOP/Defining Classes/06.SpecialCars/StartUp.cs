using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string tireCommand = Console.ReadLine();
            List<Tire[]> tireList = new List<Tire[]>();
            while (tireCommand != "No more tires")
            {
                double[] currTires = tireCommand.Split().Select(double.Parse).ToArray();

                var tires = new Tire[4]
                {
                     new Tire(currTires[0], currTires[1]),
                     new Tire(currTires[2], currTires[3]),
                     new Tire(currTires[4], currTires[5]),
                     new Tire(currTires[6], currTires[7])
                };
                tireList.Add(tires);
                tireCommand = Console.ReadLine();
            }

            string engineCommand = Console.ReadLine();
            List<Engine> engineList = new List<Engine>();
            while (engineCommand != "Engines done")
            {
                double[] currEngine = engineCommand.Split().Select(double.Parse).ToArray();

                var engine = new Engine(currEngine[0], currEngine[1]);
                engineList.Add(engine);
                engineCommand = Console.ReadLine();
            }

            string carCommand = Console.ReadLine();
            List<Car> carList = new List<Car>();
            while (carCommand != "Show special")
            {
                string[] currCar = carCommand.Split();
                string carMake = currCar[0];
                string carModel = currCar[1];
                double carYear = double.Parse(currCar[2]);
                double fuelQuantity = double.Parse(currCar[3]);
                double fuelConsumption = double.Parse(currCar[4]);
                int engineIndex = int.Parse(currCar[5]);
                int tireIndex = int.Parse(currCar[6]);

                var car = new Car(carMake, carModel, carYear, fuelQuantity, fuelConsumption, engineList[engineIndex], tireList[tireIndex]);
                double pressureSum = GetTirePressureSum(car.Tires);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && pressureSum >= 9 && pressureSum <= 10)
                {
                    car.Drive(20);
                    carList.Add(car);
                }
                carCommand = Console.ReadLine();
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static double GetTirePressureSum(Tire[] tires)
        {
            double pressureSum = 0;
            for (int i = 0; i < 4; i++)
            {
                pressureSum += tires[i].Pressure;
            }
            return pressureSum;
        }
    }
}
