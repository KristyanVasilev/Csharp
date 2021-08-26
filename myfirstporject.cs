using System;

namespace myfirstporject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int numProjects = int.Parse(Console.ReadLine());

            int hours = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numProjects} project/s.");



















        }
    }
}
