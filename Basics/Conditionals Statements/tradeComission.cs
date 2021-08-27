using System;

namespace tradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double vSells = double.Parse(Console.ReadLine());
            double finalSum = 0;

            switch (town)
            {
                case "Sofia":
                    if (vSells >= 0 && vSells <= 500)
                    {
                        double comission = vSells * 0.95;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 500 && vSells <= 1000)
                    {
                        double comission = vSells * 0.93;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 1000 && vSells <= 10000)
                    {
                        double comission = vSells * 0.92;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 10000)
                    {
                        double comission = vSells * 0.88;
                        finalSum = vSells - comission;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    //Console.WriteLine($"{finalSum:f2}");
                    break;

                case "Varna":
                    if (vSells >= 0 && vSells <= 500)
                    {
                        double comission = vSells * 0.955;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 500 && vSells <= 1000)
                    {
                        double comission = vSells * 0.925;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 1000 && vSells <= 10000)
                    {
                        double comission = vSells * 0.90;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 10000)
                    {
                        double comission = vSells * 0.87;
                        finalSum = vSells - comission;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    //Console.WriteLine($"{finalSum:f2}");
                    break;

                case "Plovdiv":
                    if (vSells >= 0 && vSells <= 500)
                    {
                        double comission = vSells * 0.945;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 500 && vSells <= 1000)
                    {
                        double comission = vSells * 0.92;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 1000 && vSells <= 10000)
                    {
                        double comission = vSells * 0.88;
                        finalSum = vSells - comission;
                    }
                    else if (vSells > 10000)
                    {
                        double comission = vSells * 0.855;
                        finalSum = vSells - comission;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    //Console.WriteLine($"{finalSum:f2}");
                    break;


                default:
                    Console.WriteLine("error");
                    break;

                    Console.WriteLine($"{finalSum:f2}");
            }
        }
            
    }
}
