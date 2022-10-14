using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class PNZero
    {
        static void Main(String[]args)
        {
            int n;
            Console.WriteLine("Enter a Number =");
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {
                Console.WriteLine("Number is Zero=");
            }
            else if(n>0)
            {
                Console.WriteLine("Number is Positive=");
            }
            else
            {
                Console.WriteLine("Number Is Negative=");
            }
        }
    }
}
