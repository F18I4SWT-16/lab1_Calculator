using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Calculator.Library
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            Accumulator = a / b; 
            return Accumulator;
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

            Accumulator = result;
            return Accumulator;
        }

        


    }
}
