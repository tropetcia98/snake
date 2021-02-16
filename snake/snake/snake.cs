using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
   public class Snake : figure
    {
        direction direction;
        public Snake (Point tail, int length,  direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point l = new Point(tail);
                l.Move(i, direction);
                plist.Add(l);
            }
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.clear();
            head.Draw();

        }
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
    }
}
