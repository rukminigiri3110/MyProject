using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class TernaryEvenOdd
    {
        static void Main(String[]args)
        {
            int n;
            Console.WriteLine("Enter a Number=");
            n = int.Parse(Console.ReadLine());
            String str = (n % 2 == 0) ? "Even":"Odd";

            Console.WriteLine(n +  "is"  + str);
            Console.ReadLine();
        }
    }
}
