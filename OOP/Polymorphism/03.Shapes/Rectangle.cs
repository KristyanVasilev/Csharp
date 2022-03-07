using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;

        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return height; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can't be negative or null");
                }
                height = value; 
            }
        }

        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can't be negative or null");
                }
                width = value; 
            }
        }

        public override double CalculateArea()
             => this.height * this.width;

        public override double CalculatePerimeter()
             => (2 * this.height) + (2 * this.width);

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DrawnLine(this.width, '*', '*'));
            for (int i = 0; i < this.height; i++)
            {
                sb.Append(DrawnLine(this.width, '*', ' '));
            }
            sb.Append(DrawnLine(this.width, '*', '*'));
            return sb.ToString();
        }

        private StringBuilder DrawnLine(double width, char endChar, char midChar)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(endChar);
            for (int i = 1; i < width; i++)
            {
                sb.Append(midChar);
            }
            sb.AppendLine(endChar.ToString());
            return sb;
        }
    }
}
