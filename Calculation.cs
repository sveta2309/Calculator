using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public double Sum(double num1, double num2)
        {
            return Math.Round(num1 + num2, 5);
        }
        public double Diff(double num1, double num2)
        {
            return Math.Round(num1 - num2, 5);
        }
        public double Division(double num1, double num2)
        {
            return Math.Round(num1 / num2, 5);
        }
        public double Multiply(double num1, double num2)
        {
            return Math.Round(num1 * num2, 5);
        }
        public double RemainderOfDivision(double num1, double num2)
        {
            return Math.Round(num1 % num2, 5);
        }
       
    }
}
