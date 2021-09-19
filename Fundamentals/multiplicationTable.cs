using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int prodcut = n * i;
                Console.WriteLine($"{n} X {i} = {prodcut}");
            }
        }
    }
}
