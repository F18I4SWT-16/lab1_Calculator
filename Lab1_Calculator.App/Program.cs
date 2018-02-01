using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_Calculator.Library;

namespace Lab1_Calculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("2 + 2 = " + calc.Add(2,2));

            Console.WriteLine("2 - 2 = " + calc.Subtract(2,2));

            Console.WriteLine("2 * 2 = " + calc.Multiply(2,2));

            Console.WriteLine("2^2 = " + calc.Power(2,2));

            Console.WriteLine("2^1 = " + calc.Power(2,1));

            Console.WriteLine("2^0 = " + calc.Power(2,0));

            Console.ReadKey();
        }
    }
}
