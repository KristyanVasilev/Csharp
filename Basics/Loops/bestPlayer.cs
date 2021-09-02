using System;

namespace bestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goals = int.Parse(Console.ReadLine());
            string bestPlayer = "";
            int goalmaster = 0;

            while (name != "END")
            {

                if (goals > goalmaster)
                {
                    goalmaster = goals;
                    bestPlayer = name;
                    if (goals >= 10)
                    {
                        break;
                    }
                }

                name = Console.ReadLine();
                if (name != "END")
                {
                    goals = int.Parse(Console.ReadLine());
                }
               
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goalmaster >= 3)
            {
                Console.WriteLine($"He has scored {goalmaster} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalmaster} goals.");

            }
        }
    }
}
