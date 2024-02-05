using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Square
    {
       
            public int Width { get; set; }
            public Square() { Width = 1; }
             public Square(int width)
             {
                  Width = width;
             }
            public Square(point<int> p01, point<int> p02)
            {
                Width = Math.Abs(p02.X - p01.X);
               
            }
       
    }
}
