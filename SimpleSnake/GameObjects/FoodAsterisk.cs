using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterisk : Food
    {
        private const char foodSymbol = '*';
        private const int DefaultAsteriksPoints = 1;

        public FoodAsterisk(Wall wall)
            : base(wall, foodSymbol, DefaultAsteriksPoints)
        {
        }
    }
}
