using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] nameReverse = str.ToCharArray();
            Array.Reverse(nameReverse);
            string ReversedName = new string(nameReverse);
            return ReversedName;
        }
    }
}
