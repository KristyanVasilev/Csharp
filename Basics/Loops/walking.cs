using System;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {           
            string steps = Console.ReadLine();
            double totalSteps = 0;
            double goalsteps = 10000;

            while (steps != "Going home")
            {
                double currentsteps = double.Parse(steps);
                totalSteps += currentsteps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(totalSteps-goalsteps)} steps over the goal!");
                    return;
                }               
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                double stepsToHome = double.Parse(Console.ReadLine());
                double totalSteps1 = stepsToHome + totalSteps;
                if (totalSteps1 >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(totalSteps1 - goalsteps)} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{(Math.Abs(totalSteps - goalsteps)) - stepsToHome} more steps to reach goal.");
                }
            }          
        }
    }
}
