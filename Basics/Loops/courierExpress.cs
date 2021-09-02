using System;

namespace courierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Тегло на пратката в килограми – реално число в интервала[0.01... 150.00]
            //2.Тип услуга –  текст със следните възможности: "standard" или "express"
            //3.Разстояние в километри – цяло число в интервала[1... 1000]

            double kgPratka = double.Parse(Console.ReadLine());
            string typeUsluga = Console.ReadLine();
            double kmRaz = double.Parse(Console.ReadLine());
            double totalprize = 0;

            switch (typeUsluga)
            {
                case "standard":
                    if (kgPratka < 1)
                    {
                         totalprize = kmRaz * 0.03;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {totalprize:f2} lv.");

                    }
                    else if (kgPratka >= 1 && kgPratka < 10)
                    {
                         totalprize = kmRaz * 0.05;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {totalprize:f2} lv.");
                    }
                    else if (kgPratka >=10 && kgPratka < 40)
                    {
                        totalprize = kmRaz * 0.10;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {totalprize:f2} lv.");
                    }
                    else if (kgPratka >= 40 && kgPratka < 90)
                    {
                        totalprize = kmRaz * 0.15;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {totalprize:f2} lv.");
                    }
                    else if (kgPratka >= 90 && kgPratka < 150)
                    {
                        totalprize = kmRaz * 0.20;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {totalprize:f2} lv.");
                    }
                    break;

                case "express":
                    if (kgPratka < 1)
                    {
                        totalprize = kmRaz * 0.03;
                        double nadcenkaKg = 0.03 * 0.8;
                        double nadcenka2 = kgPratka * nadcenkaKg;
                        double totalnadcenka = kmRaz * nadcenka2;
                        double total = totalprize + totalnadcenka;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {total:f2} lv.");
                    }
                    else if (kgPratka >= 1 && kgPratka < 10)
                    {
                        totalprize = kmRaz * 0.05;
                        double nadcenkaKg = 0.05 * 0.4;
                        double nadcenka2 = kgPratka * nadcenkaKg;
                        double totalnadcenka = kmRaz * nadcenka2;
                        double total = totalprize + totalnadcenka;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {total:f2} lv.");
                    }
                    else if (kgPratka >= 10 && kgPratka < 40)
                    {
                        totalprize = kmRaz * 0.10;
                        double nadcenkaKg = 0.10 * 0.05;
                        double nadcenka2 = kgPratka * nadcenkaKg;
                        double totalnadcenka = kmRaz * nadcenka2;
                        double total = totalprize + totalnadcenka;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {total:f2} lv.");
                    }
                    else if (kgPratka >= 40 && kgPratka < 90)
                    {
                        totalprize = kmRaz * 0.15;
                        double nadcenkaKg = 0.15 * 0.02;
                        double nadcenka2 = kgPratka * nadcenkaKg;
                        double totalnadcenka = kmRaz * nadcenka2;
                        double total = totalprize + totalnadcenka;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {total:f2} lv.");
                    }
                    else if (kgPratka >= 90 && kgPratka < 150)
                    {
                        totalprize = kmRaz * 0.20;
                        double nadcenkaKg = 0.20 * 0.01;
                        double nadcenka2 = kgPratka * nadcenkaKg;
                        double totalnadcenka = kmRaz * nadcenka2;
                        double total = totalprize + totalnadcenka;
                        Console.WriteLine($"The delivery of your shipment with weight of {kgPratka:f3} kg. would cost {total:f2} lv.");
                    }
                    break;
//                    Надценка на кг: 2 % от 0.15 лв. = 0.003 лв.
//Надценка за км: 87 кг.по 0.003 лв. = 0.261 лв.
//Общо надценка: 130 км.по 0.261 лв. = 33.93 лв.
//Обща стойност: 19.50 лв. + 33.93 лв. = 53.43 лв.

            }

        }
    }
}
