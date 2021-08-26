using System;

namespace DepositCalcu
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double Ypercent = double.Parse(Console.ReadLine());

            double Sum = deposit * Ypercent / 100;
            double lihva = Sum / 12;
            double FinalSum = deposit + month * lihva;

            Console.WriteLine(FinalSum);



        }
    }
}
