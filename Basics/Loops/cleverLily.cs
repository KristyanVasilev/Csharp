using System;

namespace cleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            double oddCounter = 0;
            int moneyGift = 10;

            for (int i = 1; i <= age ; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyGift;
                    moneyGift += 10;

                    savedMoney--;
                }
                else
                {
                    oddCounter++;  
                }
            }

            double totalToysPrice = oddCounter * toyPrice;
            double totalMoney = totalToysPrice + savedMoney;

            double diff = (Math.Abs(totalMoney - washingmachinePrice));

            if (totalMoney >= washingmachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");

            }



        }
    }
}
