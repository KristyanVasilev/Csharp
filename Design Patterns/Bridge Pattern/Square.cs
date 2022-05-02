namespace BridgePattern
{
    public class Square : Shape
    {
        public Square(IRenderer renderer)
            : base(renderer)
        {
            this.Name = "Square";
        }
    }
}

