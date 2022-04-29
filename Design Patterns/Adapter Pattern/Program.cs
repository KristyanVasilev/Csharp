using System;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 4;
            IRectangle squareAdapter = new SquareToRectangleAdapter(square);
            Console.WriteLine(squareAdapter.Area());
        }
    }
}
