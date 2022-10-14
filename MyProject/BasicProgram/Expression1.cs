using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Expression1
    {
        static void Main(String[]args)
        {
            Console.WriteLine(((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));
        }
    }

    class Operator
    {
        static void Main(String[] args)
        {
            int a = 5; int b = 4; int c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
        }
    }

}
