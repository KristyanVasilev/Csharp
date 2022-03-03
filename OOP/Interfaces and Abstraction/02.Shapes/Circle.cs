using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            this.Radius = radius;
        }


        public int Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public void Draw()
        {
            double inRadius = this.radius - 0.4;
            double outRadius = this.radius + 0.4;

            for (int j = this.radius; j >= -this.radius; --j)
            {
                for (double i = -this.radius; i < outRadius; i += 0.5)
                {
                    double value = i * i + j * j;
                    if (value >= inRadius * inRadius && value <= outRadius * outRadius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
