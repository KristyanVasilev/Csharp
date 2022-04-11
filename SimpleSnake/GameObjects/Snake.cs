using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char DefaultSnakeSymbol = '\u25CF';
        private Queue<Point> snakeElements;
        private readonly Food[] foods;
        private readonly Wall wall;
        private int foodIndex = 0;

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.foods = new Food[]
            {
                new FoodAsterisk(this.wall),
                new FoodDollar(this.wall),
                new FoodHash(this.wall)
            };

            CreatSnake();
        }

        private void CreatSnake()
        {
            this.snakeElements = new Queue<Point>();
            for (int i = 1; i <= 6; i++)
            {
                var point = new Point(i, 2);
                this.snakeElements.Enqueue(point);
                point.Draw(DefaultSnakeSymbol);
            }
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }

       public bool TryMove(Point point)
        {
            Point snakeHead = this.snakeElements.Last();

            int nexLeft = snakeHead.LeftX + point.LeftX;
            int nextRight = snakeHead.TopY + point.TopY;

            bool isSnake = this.snakeElements.Any(x => x.LeftX == nexLeft && x.TopY == nextRight);

            if (isSnake)
            {
                return false;
            }

            bool isWall = nexLeft < 0 || nextRight < 0 || nexLeft >= this.wall.LeftX || nextRight >= this.wall.TopY;

            if (isWall)
            {
                return false;
            }

            bool isFood = this.foods[foodIndex].LeftX == nexLeft && this.foods[foodIndex].TopY == nextRight;

            if (isFood)
            {
                this.Eat(nexLeft, nextRight);
            }

            var snakePoint = new Point(nexLeft, nextRight);
            this.snakeElements.Enqueue(snakePoint);
            snakePoint.Draw(DefaultSnakeSymbol);

            var lastPoint = this.snakeElements.Dequeue();
            lastPoint.Draw(' ');

            return true;
        }

        private void Eat(int nexLeft, int nextRight)
        {
            Food food = foods[foodIndex];

            for (int i = 0; i < food.Points; i++)
            {
                this.snakeElements.Enqueue(new Point(nexLeft, nextRight));
            }

            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }
    }
}
