using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '@');
            p1.Draw();

            Point p2 = new Point(5, 9, '%');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 9, 14, '#');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(3, 6, 12, '$');
            vLine.Draw();
            
            Console.ReadLine();



        }

    }
}
