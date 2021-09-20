using System;

namespace padawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceOFLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double freeBelts = 0;

            if (numOfStudents >= 6)
            {
                freeBelts = numOfStudents / 6;
            }

            double totalMoney = priceOFLightsabers * (Math.Ceiling(numOfStudents * 1.1)) + priceOfRobes * numOfStudents + priceOfBelts * (numOfStudents - freeBelts);

            if (totalMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoney - money:f2}lv more.");
            }
        }
    }
}
