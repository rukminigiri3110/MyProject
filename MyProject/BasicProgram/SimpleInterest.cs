using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class SimpleInterest
    {
        static void Main(String[]args)
        {
            int P, T, R;
            double SI;
            P = 3400;
            T = 5;
            R = 5;
            Console.WriteLine("Enter Principal Amount=" + P);
            Console.WriteLine("Enter Time=" + T);
            Console.WriteLine("Enter Rate=" + R);
            SI = (P * T * R) / 100;
            Console.WriteLine("Simple Interest is " + SI);
        }
    }
}
