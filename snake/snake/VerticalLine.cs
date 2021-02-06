using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> vlist;
        public VerticalLine (int x, int yleft, int yright, char sym)
        {
            vlist = new List<Point>();
            for (int y = yleft; y < yright; y++)
            {
                Point p = new Point(x, y, sym);
                vlist.Add(p);

            }
        }
        public void Drow ()
        {
            foreach (Point p in vlist)
            {
                p.Draw();
            }
        }
    }
}
