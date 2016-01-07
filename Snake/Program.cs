using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(1, 3, '@');
            p1.Draw();

            Point p2 = new Point(15, 19, '%');
            p2.Draw();

            HorizontalLine upLine = new HorizontalLine(0, 79, 0, '#');
            upLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 1, 23, '#');
            leftLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 79, 23, '#');
            downLine.Draw();
            VerticalLine rightLine = new VerticalLine(79, 1, 23, '#');
            rightLine.Draw();

            //snake draw

            Snake snake = new Snake(p2, 3, Direction.UP);
            snake.Draw();
            snake.Move();
            Thread.Sleep(200);
            snake.Move();
            Thread.Sleep(200);
            snake.Move();
            Thread.Sleep(200);
            snake.Move();
            Thread.Sleep(200);
            snake.Move();
            Thread.Sleep(200);
            



            Console.ReadLine();



        }

    }
}
