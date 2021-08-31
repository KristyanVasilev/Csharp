using System;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numOfJudges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfJudges; i++)
            {
                string juryName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                academyPoints += juryName.Length * points / 2;

                if (academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }

            }

            if (academyPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - academyPoints:f1} more!");
            }

        }
    }
}