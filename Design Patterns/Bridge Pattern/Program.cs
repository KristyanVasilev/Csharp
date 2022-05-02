using System;

namespace BridgePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var raster = new RasterSquare();
            var vector = new VectorSquare();
            var square = new Square(vector);
            square.Name = "Gosho kvadrata";
            Console.WriteLine(square.ToString());
        }
    }
}

