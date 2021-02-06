using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : figure
    {
       
        public VerticalLine (int x, int yDown, int yUp, char sym)
        {
            plist = new List<Point>();
            for (int y = yDown; y < yUp; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
        
    }
}
