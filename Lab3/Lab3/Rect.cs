using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rect 
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rect() { Width = 1; Height = 1; }

        public Rect(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rect(point<int> p01, point<int> p02)
        {
            Width = Math.Abs(p02.X - p01.X);
            Height = Math.Abs(p02.Y - p01.Y);
        }
    }
}
