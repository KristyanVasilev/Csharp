using System;

namespace _02._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           DrawFigure(n);
        }

        private static void DrawFigure(int row)
        {
            if (row == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', row));

            DrawFigure(row - 1);

            Console.WriteLine(new string('#',row));
        }
    }
}
