using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryprice = double.Parse(Console.ReadLine()); //48
            double bananaskg = double.Parse(Console.ReadLine());
            double orangeskg = double.Parse(Console.ReadLine());
            double berrykg = double.Parse(Console.ReadLine());
            double strawberrykg = double.Parse(Console.ReadLine());


            //cena qgodi
            double berry = (strawberryprice / 2); // 48 /2 = 24
            double oranges = berry - (berry * 0.4); // 24 - (0.4 * 24)= 14.4
            double bananas = berry- (berry * 0.8); // 24 - (0.8 * 24)= 4.8
            
            
            double strawberrytotal = strawberryprice * strawberrykg; // 1.7 * 48 = 81.6
            double totalban = bananas * bananaskg;
            double totalorang = oranges * orangeskg;
            double totalberry = berry * berrykg;
           
            double totalsum = totalberry + strawberrytotal + totalorang + totalban ;

            Console.WriteLine(totalsum);


        }
    }
}
