using System;

namespace fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double finalSum = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        finalSum = quantity * 2.50;
                    }
                    else if (fruit == "apple")
                    {
                        finalSum = quantity * 1.20;
                    }
                    else if (fruit == "orange")
                    {
                        finalSum = quantity * 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        finalSum = quantity * 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        finalSum = quantity * 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        finalSum = quantity * 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        finalSum = quantity * 3.85;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    Console.WriteLine($"{finalSum:f2}");
                    break;

                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        finalSum = quantity * 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        finalSum = quantity * 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        finalSum = quantity * 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        finalSum = quantity * 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        finalSum = quantity * 3;
                    }
                    else if (fruit == "pineapple")
                    {
                        finalSum = quantity * 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        finalSum = quantity * 4.20;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    Console.WriteLine($"{finalSum:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }


        }
    }
}
