using System;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Първият ред съдържа числото n – брой километри – цяло число в интервала[1…5000]
            //•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
            double km = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            
            //            •	Такси. Начална такса: 0.70 лв. Дневна тарифа: 0.79 лв. / км. Нощна тарифа: 0.90 лв. / км.
            //•	Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
            //•	Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.
            //Напишете програма, която въвежда броя километри n и период от деня (ден или нощ) и изчислява цената на най-евтиния транспорт.

            if (dayOrNight == "day" && km < 20)
            {
                double price = km * 0.79 + 0.7;
                Console.WriteLine($"{price:f2}");
            }
            else if (dayOrNight == "night" && km < 20)
            {
                double price = km * 0.90 + 0.7;
                Console.WriteLine($"{price:f2}");
            }
            else if (dayOrNight == "day"  && km >= 20 && km < 100)
            {
                double price = km * 0.09;
                Console.WriteLine($"{price:f2}");
            }
            else if (dayOrNight == "night" && km >= 20 && km < 100)
            {
                double price = km * 0.09;
                Console.WriteLine($"{price:f2}");
            }
            else if (dayOrNight == "day" && km >= 100)
            {
                double price = km * 0.06;
                Console.WriteLine($"{price:f2}");
            }
            else if (dayOrNight == "night" && km >= 100)
            {
                double price = km * 0.06;
                Console.WriteLine($"{price:f2}");
            }


        }
    }
}
