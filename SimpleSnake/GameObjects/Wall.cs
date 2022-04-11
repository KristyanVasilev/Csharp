using System;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char WallSymbol = '\u25A0';
        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            InitializeWall();
        }

        public void InitializeWall()
        {
            DrawHorizontal(0);
            DrawHorizontal(this.TopY);
            
            DrawVertical(0);
            DrawVertical(this.LeftX);
        }

        private void DrawVertical(int cordinate)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(cordinate, topY, WallSymbol);
            }
        }

        private void DrawHorizontal(int cordinate)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, cordinate, WallSymbol);
            }
        }
    }
}
