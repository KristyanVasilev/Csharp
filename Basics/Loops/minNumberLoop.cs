using System;

namespace minNumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNum = int.MaxValue;

            while (command != "Stop")
            {
                int currentNum = int.Parse(command);
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
