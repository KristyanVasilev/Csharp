using System;

namespace zelenchukovaborsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double veggiPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double veggiKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double veggitotalprice = veggiPrice * veggiKg;
            double fruittotalprice = fruitPrice * fruitKg;

            double totalveggi = veggitotalprice / 1.94;
            double totalfruit = fruittotalprice / 1.94;

            double totalearn = totalveggi + totalfruit;

            Console.WriteLine(String.Format("{0:0.00}", totalearn));
        }
    }
}
