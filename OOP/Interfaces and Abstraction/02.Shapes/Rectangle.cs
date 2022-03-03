using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;

        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }

        public void Draw()
        {
            DrawnLine(this.width, '*', '*');
            for (int i = 0; i < this.height; i++)
            {
                DrawnLine(this.width, '*', ' ');
            }
            DrawnLine(this.width, '*', '*');
        }

        private void DrawnLine(int width, char endChar, char midChar)
        {
            Console.Write(endChar);
            for (int i = 1; i < width; i++)
            {
                Console.Write(midChar);
            }
            Console.WriteLine(endChar);
        }
    }
}
