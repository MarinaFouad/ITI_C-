using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class ExtentionArea
    {
        public static int squareArea(this Square Sq01)
        {
            return Sq01.Width * Sq01.Width;
        }

        public static int RectArea(this Rect Rect01)
        {
            return Rect01.Width * Rect01.Height;
        }

    }
}
