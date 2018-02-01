using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Calculator.Library
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            double result = x;

            if (exp == 0)
            {
                result = 1;
            }
            for (int i = 1; i < exp; i++)
            {
                result = result * x;
            }

            return result;
        }
    }
}
