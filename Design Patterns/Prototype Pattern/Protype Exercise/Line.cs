namespace PrototypeExercise
{
    public class Line
    {
        public Line(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
        }

        public Point Start { get; private set; }

        public Point End { get; set; }

        public Line DeepCopy()
        {
            var newStart = new Point { X = Start.X, Y = Start.Y };
            var newEnd = new Point { X = End.X, Y = End.Y };
            return new Line(newStart, newEnd);
        }

        public override string ToString()
        {
            return $"{nameof(Start.X)} is {Start.X} and {nameof(Start.Y)} is {Start.Y}" +
                   $"{nameof(End.X)} is {End.X} and {nameof(End.Y)} is {End.Y}";
        }
    }
}
