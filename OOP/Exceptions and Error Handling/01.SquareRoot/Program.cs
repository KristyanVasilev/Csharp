﻿using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 0) throw new ArgumentException("Invalid number.");
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
