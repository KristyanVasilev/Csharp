using System;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int dalcm = int.Parse(Console.ReadLine());
            int shircm = int.Parse(Console.ReadLine());
            int viscm = int.Parse(Console.ReadLine());
            
            double procent = double.Parse(Console.ReadLine());

            double obemna  = dalcm * shircm * viscm ; //tuka
            double totalza = obemna * 0.001;
            double totalpro = procent * 0.01;
            double total = totalza * (1 - totalpro);

            Console.WriteLine(total);
        }
    }
}
