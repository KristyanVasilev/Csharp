using System;

namespace maxNumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNum = int.MinValue;

            while (command != "Stop")
            {
                int currentNum = int.Parse(command);
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
