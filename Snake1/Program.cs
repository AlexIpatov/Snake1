using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            rightLine.Drow();
            leftLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT );
            snake.Drow();
            snake.Move();

            Console.CursorVisible = false;
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key );


                }
                Thread.Sleep(100);
                snake.Move();
            }



        }

    }
}
