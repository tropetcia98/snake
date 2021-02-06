using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Console.ReadLine();
        }
       
        

    }
}
