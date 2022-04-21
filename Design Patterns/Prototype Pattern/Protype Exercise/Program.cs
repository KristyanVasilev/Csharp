using System;

namespace PrototypeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var start = new Point();
            start.X = 5;
            start.Y = 10;
            var end = new Point();
            end.X = 5;
            end.Y = 10;
            Line line = new Line(start, end);

            Line prototyypeLine = line.DeepCopy();
            prototyypeLine.Start.X = 2;
            prototyypeLine.End.Y = 242;

            Console.WriteLine(line);
            Console.WriteLine(prototyypeLine);
        }
    }
}
