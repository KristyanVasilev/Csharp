using System;

namespace sumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            int sumOfPrime = 0;
            int sumOfNonPrime = 0;

            while (start != "stop")
            {
                int number = int.Parse(start);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");                    
                }
                else 
                {
                    int counter = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        sumOfPrime += number;
                    }
                    else
                    {
                        sumOfNonPrime += number;
                    }
                }
                start = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrime}");
        }
    }
}
