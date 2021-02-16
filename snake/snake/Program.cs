﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)

        {
            //console.SetBufferSize(80, 25);
            //HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            //upline.Drow();
            //downline.Drow();
            //leftline.Drow();
            //rightline.Drow();




            Point p1 = new Point(1, 3,'*') ;
            
           
            
            p1.Draw();


            Point p2 = new Point(4,5,'#');
            
            p2.Draw();

            Point p3 = new Point(8, 9, '@');
            p3.Draw();

            Point p4 = new Point(15, 20, '+');
            p4.Draw();
            Console.ReadLine();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(2);
          

            List<Point> p = new List<Point>();
            p.Add(p1);
            p.Add(p2);
            p.Add(p3);
            p.Add(p4);
            

            List<char> symbol = new List<char>();
            symbol.Add('^');
            symbol.Add('+');
            symbol.Add('?');
            foreach (char q in symbol)
            {
                Console.WriteLine(q);
            }

            HorizontalLine Line = new HorizontalLine(5,10,8,'+');
            Line.Drow();

            VerticalLine VertLine = new VerticalLine(15, 5, 10, '%');
            VertLine.Drow();
            Point snake1 = new Point(6, 6, '*');
            
           Snake snake = new Snake(snake1, 10, direction.RIGHT);
            snake.Drow();
            snake.Moved();
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                   
                }
                Thread.Sleep(100);
                snake.Moved();
                
            }
           







            
        }
       
        

    }
}
