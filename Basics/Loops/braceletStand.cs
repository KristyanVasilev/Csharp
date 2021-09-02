using System;

namespace braceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	Първи ред – джобните на Тереза на ден – реално число в интервала[1.00...100.00]
            //•	Втори ред – парите, които тя печели на ден от продажби – реално число в интервала[1.00...1000.00]
            //•	Трети ред – разходите на Тереза за целия период – реално число в интервала[1.00...1000.00]
            //•	Четвърти ред – цената на подаръка – реално число в интервала[1.00...10000.00]

            double terezaMoney = double.Parse(Console.ReadLine());
            double terezaGain = double.Parse(Console.ReadLine());
            double terezaSpend = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double jobni = 5 * terezaMoney;
            double specheleni = 5 * terezaGain;
            double gain = jobni + specheleni;
            double totalGain = gain - terezaSpend;
            if (totalGain >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalGain:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {Math.Abs(giftPrice-totalGain):f2} BGN.");
            }

        }
    }
}
