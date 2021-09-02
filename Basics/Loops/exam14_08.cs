using System;

namespace exam14_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	1 грам мазнини = 9 калории
            //•	1 грам протеини = 4 калории
            //•	1 грам въглехидрати = 4 калории

            double maznina = 9;
            double protein = 4;
            double vagle = 4;

            //            •	Процент на мазнините - цяло число в интервала[0…100]
            //•	Процент на протеините - цяло число в интервала[0…100]
            //•	Процент на въглехидратите - цяло число в интервала[0…100]
            //•	Общ брой калории - цяло число в интервала[1000…15000]
            //•	Процент на съдържанието на вода - цяло число в интервала[0…100]

            double mazninaProcent = double.Parse(Console.ReadLine());
            double proteinProcent = double.Parse(Console.ReadLine());
            double vagleProcent = double.Parse(Console.ReadLine());
            double totalKalorii = double.Parse(Console.ReadLine());
            double waterProcent = double.Parse(Console.ReadLine());

            //            (60 % от  2500) / 9 = 166.6 - общите грамове от мазнини
            //(25 % от  2500) / 4 = 156.25 - общите грамове от протеини
            //(15 % от 2500) / 4 = 93.75 - общите грамове от въглехидрати

            double totalMaznini = ((totalKalorii  / 100) * mazninaProcent)/ maznina;
            //Console.WriteLine($"{totalMaznini:f2}");
            double totalProtein = ((totalKalorii / 100) * proteinProcent) / protein;
            //Console.WriteLine($"{totalProtein:f2}");
            double totalvagle = ((totalKalorii / 100) * vagleProcent) / vagle;
            //Console.WriteLine($"{totalvagle:f2}");
            double totalFood = totalMaznini + totalProtein + totalvagle;
            //Console.WriteLine($"{totalFood:f2}");
            double kaloriesPerGram = totalKalorii / totalFood;

            double final = (kaloriesPerGram / 100) * (100 - waterProcent) ;

            Console.WriteLine($"{final:f4}");


        }
    }
}
