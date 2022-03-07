using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius can't be negative or null.");
                }
                radius = value; 
            }
        }

        public override double CalculateArea()
            => Math.PI * this.radius * this.radius;

        public override double CalculatePerimeter()
            => 2 * Math.PI * this.radius;

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            double inRadius = this.radius - 0.4;
            double outRadius = this.radius + 0.4;

            for (double j = this.radius; j >= -this.radius; --j)
            {
                for (double i = -this.radius; i < outRadius; i += 0.5)
                {
                    double value = i * i + j * j;
                    if (value >= inRadius * inRadius && value <= outRadius * outRadius)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();                
            }
            return sb.ToString();
        }
    }
}
