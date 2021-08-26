using System;

namespace BirthdayP
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentforplace = double.Parse(Console.ReadLine());

            double Cake = rentforplace * 20 / 100; // true
            double drinks = Cake - (Cake * 45 / 100); 
            double Animation = rentforplace / 3; 

            double totalsum = rentforplace + Cake + drinks + Animation;

            Console.WriteLine(totalsum);
        }
    }
}
