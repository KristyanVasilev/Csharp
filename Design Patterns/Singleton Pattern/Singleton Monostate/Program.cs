using System;

namespace SingletonMonostate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Manufacture = "Audi";
            car.Model = "A3";
            car.Year = 2010;

            Console.WriteLine(car);

            Car car2 = new Car();
            car2.Year = 2011;

            //Both cars are with same refference and equal
            Console.WriteLine(car);
            Console.WriteLine(car2);
        }
    }
}
