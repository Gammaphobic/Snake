﻿using System;
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

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();


            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();

            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            leftline.Draw();
            VerticalLine rightline = new VerticalLine(78, 0, 24, '+');
            rightline.Draw();
            //Отрисовка точек
            Point p = new Point(3, 4, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {


                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                    Thread.Sleep(300);

                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);

                }
            }

        }
        
    }

}
