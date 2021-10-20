using System;
using System.Linq;

namespace T03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string commands = Console.ReadLine();
            int cupidCurrPosition = 0;

            while (commands != "Love!")
            {
                string[] cmd = commands.Split();
                int jump = int.Parse(cmd[1]);

                if (cupidCurrPosition + jump >= neighborhood.Length) cupidCurrPosition = 0;
                else cupidCurrPosition += jump;

                neighborhood[cupidCurrPosition] -= 2;
                if (neighborhood[cupidCurrPosition] == 0) Console.WriteLine($"Place {cupidCurrPosition} has Valentine's day.");

                if (neighborhood[cupidCurrPosition] < 0) Console.WriteLine($"Place {cupidCurrPosition} already had Valentine's day.");

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {cupidCurrPosition}.");
            if (!neighborhood.Any(number => number > 0)) Console.WriteLine("Mission was successful."); //Ако няма числа по-голями от 0
            else Console.WriteLine($"Cupid has failed {neighborhood.Count(number => number > 0)} places.");
            // [10,0,10,0,10].Count number => number > 0, Минава и ми връща бройката колко пъти имам числа по-голями от 0.

        }
    }
}
