using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());

            // Фирма получава заявка за изработването на проект, за който са необходими определен брой часове.Фирмата разполага с определен брой дни.
            // През 10 % от дните служителите са на обучение и не могат да работят по проекта. Един нормален работен ден във фирмата е 8 часа.
            //     Всеки служител може да работи по проекта в извънработно време по 2 часа на ден.
            //Часовете трябва да са закръглени към по - ниско цяло число(Например –> 6.98 часа се закръглят на 6 часа).
            //Напишете програма, която изчислява дали фирмата може да завърши проекта навреме и колко часа не достигат или остават.

            double workDays = days * 0.10;
            double workHours = (days - workDays) * 8;
            double plusHours = numOfWorkers * (2 * days) ;
            double totalWorkHours = Math.Floor(workHours + plusHours);
            

            if (totalWorkHours >= neededHours)
            {
               double hoursLeft = totalWorkHours - neededHours;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else if (totalWorkHours < neededHours)
            {
                double hoursNeed = neededHours - totalWorkHours;
                Console.WriteLine($"Not enough time!{hoursNeed} hours needed.");
            }
           
        }
    }
}
