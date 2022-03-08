using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            IVehicle car = new Car(carFuelQuantity, carFuelConsumption);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine());
            ReadCommands(car, truck, n);

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }

        private static void ReadCommands(IVehicle car, IVehicle truck, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Drive")
                {
                    double distance = double.Parse(command[2]);
                    if (command[1] == "Car")
                    {
                        if (car.CanDrive(distance))
                        {
                            car.Drive(distance);
                            Console.WriteLine($"Car travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (command[1] == "Truck")
                    {
                        if (truck.CanDrive(distance))
                        {
                            truck.Drive(distance);
                            Console.WriteLine($"Truck travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else if (command[0] == "Refuel")
                {
                    double litres = double.Parse(command[2]);
                    if (command[1] == "Car")
                    {
                        car.Refuel(litres);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(litres);
                    }
                }
            }
        }
    }
}
