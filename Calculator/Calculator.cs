﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {

        }

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
            return Math.Pow(x, exp);
        }

        public void Test(double methodUT, double expectedResult)
        {
            Console.WriteLine(methodUT == expectedResult ? "Test passed" : "Test failed");
        }
    }
}
