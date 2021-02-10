using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
   public class Snake : figure
    {
        public Snake (Point tail, int length,  direction direction)
        {
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point l = new Point(tail);
                l.Move(i, direction);
                plist.Add(l);
            }
        }
    }
}
