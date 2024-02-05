using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Calculate
    {
        public delegate int CalcDeleg(int num1 , int num2);
        
            public int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Sub(int num1, int num2)
            {
                return num1 - num2;
            }
            public int Div(int num1, int num2)
            {
                return num1 / num2;
            }

            public int Multi(int num1, int num2)
            {
                return num1 * num2;
            }
        public int Calculator(int num1, int num2, CalcDeleg calcDeleg1)
        {
            return calcDeleg1(num1, num2);
        }
    }
    }

