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

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
/* NOTE: You need a StartUp class with the namespace CarManufacturer.
Create a class named Car. The class should have private fields for:
•	make: string
•	model: string
•	year: int
The class should also have public properties for:
•	Make: string
•	Model: string
•	Year: int
*/