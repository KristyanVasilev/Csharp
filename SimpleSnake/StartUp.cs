namespace SimpleSnake
{
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using SimpleSnake.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Console.SetCursorPosition(30, 5);

            Wall wall = new Wall(100, 20);

            Snake snake = new Snake(wall);
            //while (true)
            //{
            //    snake.TryMove(new Point(1, 0));
            //    Thread.Sleep(200);
            //}

            var engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
