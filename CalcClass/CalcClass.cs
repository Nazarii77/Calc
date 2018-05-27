using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public class CalcClass
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }


        public double Multipy(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Mod(double a, double b)
        {
            return a % b;
        }

        public double Exp(double a, double b)
        {
            return Math.Pow(b, a);
        }
    }
}
