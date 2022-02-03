using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 1999;
            car.FuelQuantity = 80;
            car.FuelConsumption = 15;
            car.Drive(100);
            car.Drive(600);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
/* The class should also have properties for:
    •	Make: string
    •	Model: string
    •	Year: int
    •	FuelQuantity: double
    •	FuelConsumption: double
The class should also have methods for:
    •  Drive(double distance): void – this method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero. If it is remove from the fuel quantity the result of the multiplication between the distance and the fuel consumption. Otherwise write on the console the following message:  
"Not enough fuel to perform this trip!"
    •	WhoAmI(): string – returns the following message: 
"Make: {this.Make}
 Model: {this.Model}
 Year: {this.Year}
 Fuel: {this.FuelQuantity:F2}"
*/

