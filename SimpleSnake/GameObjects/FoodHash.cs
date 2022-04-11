using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodHash : Food
    {
        private const char foodSymbol = '#';
        private const int DefaultHashPoints = 3;
        public FoodHash(Wall wall)
            : base(wall, foodSymbol, DefaultHashPoints)
        {
        }
    }
}
