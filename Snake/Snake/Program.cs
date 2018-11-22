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
            Console.SetBufferSize(80, 25);

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();


            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();

            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            leftline.Draw();
            VerticalLine rightline = new VerticalLine(78, 0, 24, '+');
            rightline.Draw();
            //Отрисовка точек
            Point p = new Point(4, 5, '#');

            p.Draw();
            Console.ReadLine();
        }
        
    }

}
