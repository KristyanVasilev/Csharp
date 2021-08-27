using System;

namespace balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int othersColours = 0;
          
            for (int i = 0; i < numberOfBalls; i++)
            {
                string colours = (Console.ReadLine());

                if (colours == "red")
                {
                    totalPoints += 5;
                    red++;
                }
                else if (colours == "orange")
                {
                    totalPoints += 10;
                    orange++;
                }
                else if (colours == "yellow")
                {
                    totalPoints += 15;
                    yellow++;
                }
                else if (colours == "white")
                {
                    totalPoints += 20;
                    white++;
                }
                else if (colours == "black")
                {
                    totalPoints = Math.Floor(totalPoints /= 2);
                    black++;
                }
                else
                {
                    othersColours++;
                }

            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {othersColours}");
            Console.WriteLine($"Divides from black balls: {black}");

        }
    }
}
