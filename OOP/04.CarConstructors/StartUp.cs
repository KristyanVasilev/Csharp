using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            var firstcar = new Car();
            var secondCar = new Car(make, model, year);
            var thridCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine(firstcar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(thridCar.WhoAmI());
        }
    }
}
