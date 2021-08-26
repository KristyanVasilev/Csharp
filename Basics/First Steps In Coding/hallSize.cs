using System;

namespace trainiLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            double W = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double sizeHall = Math.Floor(H * 100 - 100);
            double sizedesk = Math.Floor (sizeHall / 70);

            double hallLenght = Math.Floor (W * 100 / 120);
            double total = Math.Floor ( sizedesk * hallLenght - 3);

            Console.WriteLine(String.Format("{0:0}", total));

            //Console.WriteLine(String.Format("{0:0}", shirNaChin));
            
            
        }
    }
}
