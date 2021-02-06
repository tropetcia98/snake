﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> plist;
        public HorizontalLine(int xleft, int xright, int y, char sym) 
        {

            plist = new List<Point>();
                for (int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
            
           
           
           

        }
        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
                    
            }
        }
    }
}
