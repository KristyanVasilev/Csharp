using System;

namespace housepainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            //steni
            double Spredna = X * X - (1.2 * 2);
            double Szadna = X * X;
            double Sdqsno = X * Y - (1.5 * 1.5);
            double Slqvo = X * Y - (1.5 * 1.5);
            double Ssteni = Spredna + Szadna + Sdqsno + Slqvo;

            //pokriv
            double Pravo1 = X * Y;
            double Pravo2 = X * Y;
            double Triangle1 = X * H / 2;
            double Triangle2 = X * H / 2;
            double Spokriv = Pravo1 + Pravo2 + Triangle1 + Triangle2;

            double zelena = Ssteni / 3.4;
            double chervena = Spokriv / 4.3;

            Console.WriteLine(String.Format("{0:0.00}", zelena));
            Console.WriteLine(String.Format("{0:0.00}", chervena));

        }
    }
}
