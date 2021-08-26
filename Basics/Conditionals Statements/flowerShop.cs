using System;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Брой магнолии – цяло число в интервала[0 … 50]
            //•	Брой зюмбюли – цяло число в интервала[0 … 50]
            //•	Брой рози – цяло число в интервала[0 … 50]
            //•	Брой кактуси – цяло число в интервала[0 … 50]
            //•	Цена на подаръка – реално число в интервала[0.00 … 500.00]

            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            //            •	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5 % данъци.

            double magnoliaPrice = magnolia * 3.25;
            double hyacinthPrice = hyacinth * 4;
            double rosesPrice = roses * 3.5;
            double cactusPrice = cactus * 8;

            double totalprice = magnoliaPrice + hyacinthPrice + rosesPrice + cactusPrice;
            double priceAfterTaxes = totalprice - (totalprice * 0.05);

            //            •	Ако парите СА стигнали: 
            //                "She is left with {останали} leva." – сумата трябва да е закръглена към по - малко цяло число(пр. 1.90-> 1).
            //•	Ако парите НЕ достигат: 
            //                "She will have to borrow {останали} leva." – сумата трябва да е закръглена към по - голямо цяло число(пр. 1.10-> 2).

            if (priceAfterTaxes >= giftPrice)
            {
                double moneyLeft = Math.Floor(priceAfterTaxes - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyNeed = Math.Ceiling(giftPrice - priceAfterTaxes);
                Console.WriteLine($"She will have to borrow {moneyNeed} leva.");
            }


        }
    }
}
