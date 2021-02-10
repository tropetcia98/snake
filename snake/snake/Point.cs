using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
   public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            Console.WriteLine();
        }

        public Point(int _x, int _y, char _sym)
        {
             x = _x;
            y = _y;
            sym = _sym;


        }
        public Point (Point l)
        {
            x = l.x;
            y = l.y;
            sym = l.sym;
        }
        public void Move (int offset, direction direction)
        {
            if (direction == direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction==direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == direction.UP)
            {
                x = x + offset;
            }
            else if (direction == direction.DOWN)
            {
                x = x - offset;
            }


        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
