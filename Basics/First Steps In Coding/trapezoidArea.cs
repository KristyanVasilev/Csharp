﻿using System;

namespace trapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double S = (b1 + b2) * h / 2;

            Console.WriteLine(String.Format("{0:0.00}", S));

        }
    }
}
