using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class ArithmaticOperation
    {
        static void Main(String[]args)
        {
            int result;
            int num1 = 23, num2 = 32;
            result = (num1 + num2);
            Console.WriteLine("Addition Operator: " + result);
            result = (num1 - num2);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (num1 * num2);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (num1 / num2);
            Console.WriteLine("Division Operator: " + result);
            result = (num1 % num2);
            Console.WriteLine("Modulus Operator: " + result);
        }
    }
}
