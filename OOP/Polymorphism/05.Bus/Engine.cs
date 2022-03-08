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
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());
            ReadCommands(car, truck, bus, n);

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static void ReadCommands(IVehicle car, IVehicle truck, IVehicle bus, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
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
                        else if (command[1] == "Bus")
                        {
                            bus.IsEmpty = false;
                            if (bus.CanDrive(distance))
                            {
                                bus.Drive(distance);
                                Console.WriteLine($"Bus travelled {distance} km");
                            }
                            else
                            {
                                Console.WriteLine("Bus needs refueling");
                            }
                        }
                    }
                    else if (command[0] == "DriveEmpty")
                    {
                        double distance = double.Parse(command[2]);

                        bus.IsEmpty = true;
                        if (bus.CanDrive(distance))
                        {
                            bus.Drive(distance);
                            Console.WriteLine($"Bus travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
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
                        else if (command[1] == "Bus")
                        {
                            bus.Refuel(litres);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
