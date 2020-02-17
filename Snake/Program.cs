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
            Console.SetWindowSize(80, 27);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            



            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '%');
            Point food = foodCreator.CreateFood();
            food.Draw();
            int score = 0;
            int speed = 100;
            int flag = 0;
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    END endScr = new END(25, 10, score);
                    endScr.DrawEnd();
                    Console.ReadKey();
                    
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score = score + 100;
                    Write writeScore = new Write(60, 25, score);
                    writeScore.DrawScore();
                    if (flag == 10 && speed != 50)
                    {
                        speed = speed - 10;
                        flag = 0;
                    }
                    else if (speed==50)
                    {
                        flag = 0;
                    }
                    else
                    {
                        flag++;
                    }
                    Write writeSpeed = new Write(10, 25, speed);
                    writeSpeed.DrawSpeed();


                }
                else
                {
                    snake.Move();
                    Write writeScore = new Write(60,25,score);
                    writeScore.DrawScore();

                    Write writeSpeed = new Write(10, 25, speed);
                    writeSpeed.DrawSpeed();

                }
                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

         
            
        }
    }
}
