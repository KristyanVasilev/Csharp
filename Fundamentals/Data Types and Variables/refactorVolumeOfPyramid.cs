using System;

namespace refactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length, Width, Height = 0;
            Length = double.Parse(Console.ReadLine());
            Width = double.Parse(Console.ReadLine());
            Height = double.Parse(Console.ReadLine());

            var Volume = (Length * Width * Height) / 3 ;
            
            Console.Write($"Length: Width: Height: Pyramid Volume: {Volume:f2}");

        }
    }
}
