using System;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double totalSpace = height * width * 4;
            totalSpace -= totalSpace * (percent / 100.00);
            totalSpace = Math.Ceiling(totalSpace); // !!!

            string input = Console.ReadLine();

            while (input != "Tired!")
            {
                int paintLiters = int.Parse(input); // 10

                totalSpace -= paintLiters;

                if (totalSpace == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (totalSpace < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(totalSpace)} l paint left!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Tired!")
            {
                Console.WriteLine($"{totalSpace} quadratic m left.");
            }

        }
    }
}